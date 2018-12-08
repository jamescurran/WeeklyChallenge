using System;

namespace TextFileChallenge.Repository
{
    public interface IUserPolicy
    {
        UserModel Create(string[] parts);
        String OutputFormat { get; }
        string Heading { get; }
        string Filename { get; }
    }
}