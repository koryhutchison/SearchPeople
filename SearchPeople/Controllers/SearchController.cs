/*
 * Program Title: People Search
 * Author: Kory Hutchison
 * Date: 12/23/2016
 * 
 * This is the main controller of the program. The People Search program is a simple MVC application that displays a search box, and the user can enter a search or click
 * the button to get all of the data. If the user searches, the application will check the search against the first and last names of the records in the database, and return all the 
 * records that contain that search keyword in either their first or last name. Once the user has completed thier search, they will then be able to click on the details link to 
 * bring them to a page that shows the person with their picture and data. 
 * 
 * This program was also made in Visual Studio 2013, and I am aware that the default SQL Server name has changed for Visual Studio 2015. So if you are going to run the program with 
 * Visual Studio 2015, then change the conneciton string in the Web.config file and change the v11.0 part to MSSQLLocalDB and it should work. 
 */

using SearchPeople.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchPeople.Controllers
{
    public class SearchController : Controller
    {
        private SearchContext db = new SearchContext();

        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        //This is the method that returns the JSON data for all the records in the database.
        public JsonResult GetAllPeople()
        {
            var people = db.Persons.ToList();
            return new JsonResult { Data = people, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //This is the method that returns all the people from the database that have search keyword in either their first or last name. It also returns it as JSON data.
        public JsonResult GetPersonWithKeyword(string prefix)
        {
            var peopleFirstName = db.Persons.Where(a => a.FirstName.Contains(prefix)).ToList();
            var peopleLastName = db.Persons.Where(a => a.LastName.Contains(prefix)).ToList();
            var combinedList = peopleFirstName.Concat(peopleLastName);
            return new JsonResult { Data = combinedList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}