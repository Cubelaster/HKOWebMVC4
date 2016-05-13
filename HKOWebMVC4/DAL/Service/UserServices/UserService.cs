using HKOWebMVC4.DAL.Repository.UserRepositories;
using HKOWebMVC4.Models;
using HKOWebMVC4.Models.HKOWebModels.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKOWebMVC4.DAL.Repository.UserServices
{
    class UserService
    {
        private UserRepository userRepo = new UserRepository();
        public ApplicationUser fetchUserById(string userId)
        {
            return userRepo.fetchUserById(userId);
        }

        public ApplicationUser fetchCurrentUser()
        {
            return userRepo.fetchCurrentUser();
        }

        public ApplicationUser updateUserProfileInfo(ApplicationUser user, ApplicationUser newUser)
        {
            return userRepo.updateUserProfileInfo(user, newUser);
        }

        public List<KorisnikOdabranaZanimanja> getSelectedProffesionForCurrentUser()
        {
            return userRepo.getSelectedProffesionForCurrentUser();
        }

        public List<KorisnikOdabranaZanimanja> getSelectedProffesionsForEmployer(UserProfileInfo user)
        {
            return userRepo.getSelectedProffesionsForUser(user);
        }
    }
}
