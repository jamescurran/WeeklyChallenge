using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileChallenge.Repository
{
    internal class SpecialPolicy : IUserPolicy
    {
        public string OutputFormat => @"""{1}"",""{0}"",{3},{2:##.##}";

        public string Heading => "LastName,FirstName,IsAlive,Age";

        public string Filename => "SpecialDataSet.csv";
        public bool CheckHeader(string header)
        {
            return Heading == header;
        }

        public UserModel Create(string[] parts)
        {
            return new UserModel
            {
                FirstName = parts[1].Trim('"', ' '),
                LastName = parts[0].Trim('"', ' '),
                Age = (int) Double.Parse(parts[3]),
                IsAlive = parts[2] == "1"
            };
        }
    }
}
