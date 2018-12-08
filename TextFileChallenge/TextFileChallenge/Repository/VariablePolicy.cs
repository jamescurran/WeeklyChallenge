using System;

namespace TextFileChallenge.Repository
{
    public class VariablePolicy : IUserPolicy
    {
        private int _inxFirst;
        private int _inxLast;
        private int _inxAge;
        private int _inxAlive;

        public UserModel Create(string[] parts)
        {
            return new UserModel
            {
                FirstName = parts[_inxFirst],
                LastName = parts[_inxLast],
                Age = Int32.Parse(parts[_inxAge]),
                IsAlive = parts[_inxAlive] == "1"
            };
        }

        public bool CheckHeader(string header)
        {
            Heading = header;
            var parts = header.Split(',');
            _inxFirst = Array.IndexOf(parts, "FirstName");
            _inxLast = Array.IndexOf(parts, "LastName");
            _inxAge = Array.IndexOf(parts, "Age");
            _inxAlive = Array.IndexOf(parts, "IsAlive");

            var isvalid = (_inxFirst != -1 && _inxLast != -1 && _inxAge != -1 && _inxAlive != -1);
            if (isvalid)
            {
                var position = new string[4];
                position[_inxFirst] = "{0}";
                position[_inxLast] = "{1}";
                position[_inxAge] = "{2}";
                position[_inxAlive] = "{3}";
                OutputFormat = String.Join(",", position);
            }

            return isvalid;
        }

        public string OutputFormat { get; set; }
        public string Heading { get; set; }
        public string Filename => "AdvancedDataSet.csv";
    }
}
