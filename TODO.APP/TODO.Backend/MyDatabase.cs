using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Nancy.ViewEngines.SuperSimpleViewEngine;
using TODO.Backend.Models;

namespace TODO.Backend
{
    public class MyDatabase:DbContext
    {
        public MyDatabase():base("DefaultConnection")
        {
            
        }
        public DbSet<MyTask> MyTasks { get; set; }

    }
}