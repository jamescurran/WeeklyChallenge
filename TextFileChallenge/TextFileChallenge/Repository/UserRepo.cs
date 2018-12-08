using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileChallenge.Repository
{
    public class UserRepo
    {
        private IUserPolicy _policy;
        public UserRepo(IUserPolicy policy)
        {
            _policy = policy;
        }

        public List<UserModel> Read()
        {
            var lines = File.ReadAllLines(_policy.Filename);
            if (!_policy.CheckHeader(lines[0]))
                throw  new ApplicationException("Bad file format");

            return lines.Skip(1).Select(line => line.Split(',')).Select(_policy.Create).ToList();
        }

        public void Write(IEnumerable<UserModel> coll)
        {
            using (var str = File.OpenWrite(_policy.Filename))
            using (var sw = new StreamWriter(str))
            {
                sw.WriteLine(_policy.Heading);
                foreach(var user in coll)
                    sw.WriteLine(_policy.OutputFormat, user.FirstName, user.LastName, user.Age, user.IsAlive?1:0);
            }
        }

    }
}
