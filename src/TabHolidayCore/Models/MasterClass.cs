﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabHolidayCore.Models.ViewModels;

namespace TabHolidayCore.Models
{
    public class MasterClass
    {
        public Boolean IsAuthenticated { get; set; }
        public ApplicationUserView User { get; set; }
        public ICollection<Country> Countries { get; set; }        
        public ICollection<string> UserRoles { get; set; }
        public ICollection<string> Roles { get; set; }
        
    }
}
