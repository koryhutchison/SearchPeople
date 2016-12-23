/*
 * This is the class that will initialize the database on the computer and seed in the information that I have hard coded in. These are just some examples of names that 
 * I thought have some similarity. If you look, the name "Adam" is in both Adam Pratt, Brett Adamson, and Rachel Adams. That would be a good name to put in to test my search.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SearchPeople.Models;
using System.IO;


namespace SearchPeople.DAL
{
    public class SearchInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SearchContext>
    {
        protected override void Seed(SearchContext context)
        {
            var people = new List<Person>
            {
                new Person{PersonID=1,FirstName="Kory",LastName="Hutchison",StreetAddress="298 E. 1960 N.",City="Orem",State="UT",Zip=84057,Age=22,Interests="Apple Products, BYU, and Golf",Picture="/Content/Images/KoryHutchison.jpg"},
                new Person{PersonID=2,FirstName="Derek",LastName="Hutchison",StreetAddress="200 E. 400 N.",City="Provo",State="UT",Zip=84606,Age=23,Interests="Golf, College Sports, and Music",Picture="/Content/Images/DerekHutchison.jpg"},
                new Person{PersonID=3,FirstName="Hailey",LastName="Randall",StreetAddress="300 E. 1857 N.",City="Provo",State="UT",Zip=84606,Age=25,Interests="Arts, Crafts, and Personal Business",Picture="/Content/Images/HaileyRandall.jpg"},
                new Person{PersonID=4,FirstName="Tyler",LastName="Randall",StreetAddress="300 E. 1857 N.",City="Provo",State="UT",Zip=84606,Age=27,Interests="Technology and Sports",Picture="/Content/Images/TylerRandall.jpg"},
                new Person{PersonID=5,FirstName="Adam",LastName="Pratt",StreetAddress="936 Wymount Ter",City="Provo",State="UT",Zip=84606,Age=23,Interests="Software Deveolpment and Sports",Picture="/Content/Images/AlexPratt.png"},
                new Person{PersonID=6,FirstName="Brett",LastName="Adamson",StreetAddress="1611 Grandview Ln",City="Provo",State="UT",Zip=84604,Age=23,Interests="Web Development, Skyrim, and Football",Picture="/Content/Images/BrettAdamson.jpg"},
                new Person{PersonID=7,FirstName="Nathan",LastName="Marrs",StreetAddress="1114 Birch Ln",City="Provo",State="UT",Zip=84604,Age=20,Interests="Music and Video Games",Picture="/Content/Images/NathanMarrs.jpg"},
                new Person{PersonID=8,FirstName="Rachel",LastName="Adams",StreetAddress="475 E. 3945 N.",City="West Valley",State="UT",Zip=84120,Age=35,Interests="Cooking and spending time with family",Picture="/Content/Images/RachelAdams.jpg"},
                new Person{PersonID=9,FirstName="Carolyn",LastName="Alder",StreetAddress="284 E. 3940 N.",City="Centerville",State="UT",Zip=84014,Age=85,Interests="Buying things, Making treats, and going on vacations",Picture="/Content/Images/Monga.JPG"},
                new Person{PersonID=10,FirstName="Alex",LastName="Alder",StreetAddress="3953 E. 4854 N.",City="Bountiful",State="UT",Zip=84010,Age=18,Interests="Everything Android, Computers, and all forms of technology",Picture="/Content/Images/AlexAlders.jpg"}
            };

            people.ForEach(m => context.Persons.Add(m));
            context.SaveChanges();
        }
    }
}