using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HKOWebMVC4.Models;
using HKOWebMVC4.DAL.Repository.UserServices;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace HKOWebMVC4.DAL.Repository.UserRepositories
{
    public class UserRepository
    {
        private static ApplicationDbContext dbContext = new ApplicationDbContext();
        private static UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(dbContext);
        private static UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);
        public ApplicationUser fetchUserById(string userId)
        {
            return userManager.FindById(userId);
        }

        public ApplicationUser fetchCurrentUser()
        {
            ApplicationUser user = userManager.FindById( HttpContext.Current.User.Identity.GetUserId() );
            return user;
        }

        public ApplicationUser updateUserProfileInfo(ApplicationUser user, ApplicationUser newUser)
        {
            user.UserProfileInfo.Ime = newUser.UserProfileInfo.Ime;
            user.UserProfileInfo.Prezime = newUser.UserProfileInfo.Prezime;
            user.UserProfileInfo.JMBAG = newUser.UserProfileInfo.JMBAG;
            user.UserProfileInfo.Država = newUser.UserProfileInfo.Država;
            user.UserProfileInfo.Grad = newUser.UserProfileInfo.Grad;
            user.UserProfileInfo.Adresa = newUser.UserProfileInfo.Adresa;
            dbContext.UserProfileInfo.Attach(user.UserProfileInfo);
            dbContext.Entry(user.UserProfileInfo).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
            return user;
        }
    }
}