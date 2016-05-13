using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HKOWebMVC4.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using HKOWebMVC4.Models.HKOWebModels.Korisnik;

namespace HKOWebMVC4.DAL.Repository.UserRepositories
{
    public class UserRepository
    {
        #region members
        private static ApplicationDbContext dbContext = new ApplicationDbContext();
        private static UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(dbContext);
        private static UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);
        #endregion

        #region methods
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

        public List<KorisnikOdabranaZanimanja> getSelectedProffesionForCurrentUser()
        {
            var currentUser = fetchCurrentUser().UserProfileInfo;
            var poZanimanjaList = getSelectedProffesionsForUser(currentUser);
            return poZanimanjaList;
        }

        public List<KorisnikOdabranaZanimanja> getSelectedProffesionsForUser(UserProfileInfo user)
        {
            var poZanimanjaList = dbContext.KorisnikOdabranaZanimanja.Where(p => p.userProfile.Id == user.Id).ToList();
            return poZanimanjaList;
        }

        #endregion
    }
}