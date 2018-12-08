using System;

namespace TextFileChallenge.Repository
{
    public class StandardPolicy : IUserPolicy
    {
        public string OutputFormat => "{0},{1},{2},{3}";

        public string Heading => "FirstName,LastName,Age,IsAlive";

        public string Filename => "StandardDataSet.csv";

        public UserModel Create(string[] parts)
        {
            return new UserModel
            {
                FirstName = parts[0],
                LastName = parts[1],
                Age = Int32.Parse(parts[2]),
                IsAlive = parts[3] == "1"
            };
        }
    }
}