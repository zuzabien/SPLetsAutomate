using Atata;
using NUnit.Framework;
using SPLetsAutomate.PageObjects;

namespace SPLetsAutomate
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test]
        [TestCase("test user", "test@blabla.com", "C. Dobla, 5, 28054 Madrid, Spain", "Street X, 28013 Madrid, Spain")]
        [TestCase("John Smith", "john.smith@mailinator.com", "Street Smith 3, London, UK", "Street Smith 6, London, UK")]
        public void Valid_User_Data_Success(string userName, string email, string current, string permanent)
        {
            Go.To<TestPage>().
                FullName.Set(userName).
                Email.Set(email).
                CurrentAddress.Set(current).
                PermanentAddress.Set(permanent).
                SubmitForm().
                Report.Screenshot().
                Name.Should.Equal($"Name:{userName}").
                Email.Should.Equal($"Email:{email}");            
        }

        [Test]
        public void Invalid_User_Data_Error()
        {
            Go.To<TestPage>().
                Email.Set("thisisnotanemail").
                SubmitForm().
                ScrollUp().
                Report.Screenshot().
                OutputTable.Should.Not.BeVisible();
        }
    }
}