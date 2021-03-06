﻿using GWA.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWA.Data.Configurations
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            //one to one 
            HasOptional(s => s.Session)
               .WithRequired(ad => ad.User);

            
        }
    }
}
