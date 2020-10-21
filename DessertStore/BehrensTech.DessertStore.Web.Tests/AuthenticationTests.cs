using BehrensTech.DessertStore.Web.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehrensTech.DessertStore.Web.Tests
{
    [TestClass]
    public class AuthenticationTests
    {
        [TestMethod]
        public void AuthenticationWorks()
        {
            // arrange
            var loginModel = new LoginModel();

            var userName = "cbehrens";
            var password = "RIPEVH";

            // act
            var result = loginModel.Authenticate(userName, password);

            // assert
            Assert.IsTrue(result, "Authentication failed with the " +
                "proper username and password");
        }

        [TestMethod]
        public void AuthenticationFails()
        {
            // arrange
            var loginModel = new LoginModel();

            var username = "cbehrens";
            var password = "wrongpassword";

            // act
            var result = loginModel.Authenticate(username, password);

            // assert
            Assert.IsFalse(result, "Authentication succeeded" +
                "when it should have failed.");
        }
    }
}
