using System;
using NUnit.Framework;
using Should;
using PBKDFPassworrdHash;

namespace PBKDFPassworrdHash.Tests
{
    [TestFixture]
    public class Tests
    {
        public static void Main()
        {
            string pass = "TestPassword123@@!!";
            string Hash = HashPass(pass);
            bool IsValid = isvalidHash(pass, Hash);


            Console.WriteLine("Create password Hash Test: " + Hash);
            Console.WriteLine("Is the Hash Valid ?: " + IsValid.ToString());
        }

        [Test]
        public static string HashPass(string pass)
        {
            string Output = PasswordController.CreateHash(pass);
            return Output;
        }

        [Test]
        public static bool isvalidHash(string pass, string HP)
        {
            bool Output = PasswordController.ValidatePassword(pass, HP);
            return Output;
        }
    }
}
