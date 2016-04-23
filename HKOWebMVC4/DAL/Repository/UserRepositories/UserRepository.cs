﻿using System;
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
    }
}