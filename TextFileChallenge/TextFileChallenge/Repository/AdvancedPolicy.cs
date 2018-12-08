using System;

namespace TextFileChallenge.Repository
{
    public class AdvancedPolicy : IUserPolicy
    {
        public string OutputFormat => "{2},{1},{3},{0}";

        public string Heading => "Age,LastName,IsAlive,FirstName";

        public string Filename => "AdvancedDataSet.csv";

        public UserModel Create(string[] parts)
        {
            return new UserModel
            {
                FirstName = parts[3],
                LastName = parts[1],
                Age = Int32.Parse(parts[0]),
                IsAlive = parts[2] == "1"
            };
        }
    }
}