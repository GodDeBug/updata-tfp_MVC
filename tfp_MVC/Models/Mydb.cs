using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tfp_MVC.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<tfp_MVC.Models.StuCJInfo> Xueshengxinxis { get; set; }

        public System.Data.Entity.DbSet<tfp_MVC.Models.StuInfo> StuInfoes { get; set; }
    }
}