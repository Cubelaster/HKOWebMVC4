using HKOWebMVC4.DAL.Repository.UserRepositories;
using HKOWebMVC4.Models;
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
    }
}
