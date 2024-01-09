using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuth
{

    [TestFixture]
    public class UserAuthenticatorTests
    {
        private RegisterLogin registerLogin;

        [SetUp]
        public void Setup()
        {
            registerLogin = new RegisterLogin();
        }

        [Test]
        public void TestUserRegistration()
        {
            Assert.IsTrue(registerLogin.Register("john", "password123"));
            Assert.IsFalse(registerLogin.Register("john", "newpassword")); // Should fail, as 'john' is already registered
        }

        [Test]
        public void TestUserLogin()
        {
            registerLogin.Register("alice", "pass123");
            Assert.IsTrue(registerLogin.Login("alice", "pass123"));
            Assert.IsFalse(registerLogin.Login("alice", "wrongpassword"));
            Assert.IsFalse(registerLogin.Login("nonexistentuser", "password"));
        }
    }
}