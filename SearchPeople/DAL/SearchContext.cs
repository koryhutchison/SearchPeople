/*
 * This is the simple database context class that allows the program to create the DbSet to work with the entire program. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SearchPeople.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SearchPeople.DAL
{
    public class SearchContext : DbContext
    {

        public SearchContext() : base("SearchContext")
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}