using System;
using System.Collections.Generic;
using System.Drawing;
/*
 This is the main model for the database that gets all the data.
 */

using System.Linq;
using System.Web;

namespace SearchPeople.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
        public string Picture { get; set; }
    }
}