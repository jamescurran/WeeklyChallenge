using DbCommon;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Dashboard : Form
    {
        private readonly BindingList<SystemUserModel> _users = new BindingList<SystemUserModel>();

        private readonly Repository _repository;

        public Dashboard()
        {
            InitializeComponent();

            userDisplayList.DataSource = _users;
            userDisplayList.DisplayMember = "FullName";

            string connectionString = ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString;
            _repository = new Repository(connectionString);

            ReadUsers();
        }


        private void createUserButton_Click(object sender, EventArgs e)
        {
            _repository.AddUser(firstNameText.Text, lastNameText.Text);

            ReadUsers();

            firstNameText.Text = "";
            lastNameText.Text = "";
            firstNameText.Focus();
        }
        private void applyFilterButton_Click(object sender, EventArgs e) => ReadFilteredUsers();


        private void ReadFilteredUsers()
        {
            _users.Clear();
            _users.AddRange(_repository.ReadFilteredUsersAs<SystemUserModel>(filterUsersText.Text));
        }

        private void ReadUsers()
        {
            _users.Clear();
            _users.AddRange(_repository.ReadUsersAs<SystemUserModel>());
        }
    }

}
    

