using HKOWebMVC4.Models;
using NUnit.Framework;

namespace HKOWebMVC4.DAL.Repository.UserRepositories.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void fetchUserByIdTest()
        {
            var sut = new UserRepository();
            ApplicationUser user = sut.fetchUserByUPId(1);

            Assert.That(user.UserProfileInfo.Id.Equals(1) );
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
        }

        //[TestMethod()]
        //public void fetchUserByUPIdTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void fetchCurrentUserTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void updateUserProfileInfoTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void getSelectedProffesionForCurrentUserTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void getSelectedProffesionsForUserTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void removeSelectedProffesionsForUserTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void setSelectedProffesionsForUserTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void fetchUsersByProffesionsListTest()
        //{
        //    Assert.Fail();
        //}
    }
}