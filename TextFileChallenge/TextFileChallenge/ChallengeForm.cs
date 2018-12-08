using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileChallenge.Repository;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        private readonly BindingList<UserModel> _users = new BindingList<UserModel>();

        private UserRepo _repo;

        public ChallengeForm()
        {
            InitializeComponent();

            Initialize();

            WireUpDropDown();
        }

        private void Initialize()
        {
            rbStandard.Checked = true;
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = _users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }
        private void LoadUsers()
        {
            _users.Clear();
            _users.AddRange(_repo.Read());

            WireUpDropDown();
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
                _repo.Write(_users);
        }

        private void policyRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            IUserPolicy policy;
            switch (( sender as RadioButton)?.Text)
            {
                case "Standard":
                    policy  = new StandardPolicy();
                    break;
                case "Advanced":
                    policy = new AdvancedPolicy();
                    break;
                case "Special":
                    policy = new SpecialPolicy();
                    break;

                default:
                    throw new ApplicationException("Unknown policy");
            }
            _repo = new UserRepo(policy);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

    }

    public static class Extensions
    {
        public static void AddRange<T>(this ICollection<T> coll, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                coll.Add(item);
            }
        }
    }

}
