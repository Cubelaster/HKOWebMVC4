﻿using HKOWebMVC4.DAL.Repository.UserRepositories;
using HKOWebMVC4.Models;
using HKOWebMVC4.Models.HKOWebModels.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HKOWebMVC4.DAL.Repository.PoslodavacRepository
{
    public class PoslodavacRepository
    {
        #region members
        private static ApplicationDbContext dbContext = new ApplicationDbContext();
        private static UserRepository userRepo = new UserRepository();
        #endregion

        #region methods
        #endregion
    }
}