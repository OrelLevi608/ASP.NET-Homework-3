using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Web09042024
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Client> LstClient = new List<Client>(); // הגדרת רשימה עבור לקוחות
            List<City> LstCity = new List<City>();
            List<Category> LstCategory = new List<Category>();
            List<Product> LstProduct = new List<Product>();

            // Clients \\
            Client Tmp;
            Tmp = new Client()
            {
                CodeClie = 1,
                FirstNameClie = "Shalom",
                LastNameClie = "Cohen",
                CodeCityClie = 78897,
                PhoneCline = 0523696612,
                EmailClie = "shalom123@gmail.com",
                PasswordClie = "12361",
                StatusClie = "Action",
                AddDateClie = new DateTime(2024, 02, 02)
            };
            LstClient.Add(Tmp);

            Tmp = new Client()
            {
                CodeClie = 2,
                FirstNameClie = "Dana",
                LastNameClie = "Levi",
                CodeCityClie = 90001,
                PhoneCline = 0541234567,
                EmailClie = "dana_levi@gmail.com",
                PasswordClie = "98765",
                StatusClie = "Active",
                AddDateClie = new DateTime(2024, 03, 01)
            };
            LstClient.Add(Tmp);

            Tmp = new Client()
            {
                CodeClie = 3,
                FirstNameClie = "Yossi",
                LastNameClie = "Cohen",
                CodeCityClie = 67890,
                PhoneCline = 0531231231,
                EmailClie = "yossi.cohen@gmail.com",
                PasswordClie = "12345",
                StatusClie = "Pending",
                AddDateClie = new DateTime(2024, 03, 02)
            };
            LstClient.Add(Tmp);

            Tmp = new Client()
            {
                CodeClie = 4,
                FirstNameClie = "Sara",
                LastNameClie = "Ben-David",
                CodeCityClie = 34567,
                PhoneCline = 0527654321,
                EmailClie = "sara.bd@gmail.com",
                PasswordClie = "67890",
                StatusClie = "Inactive",
                AddDateClie = new DateTime(2024, 03, 03)
            };
            LstClient.Add(Tmp);
            Application["Clients"] = LstClient; // שמירת רשימת הלקוחות בתוך הזיכרון מסוג אפליקיישן

            //--------------------

            // Cities \\
            City Cit;
            Cit = new City()
            {
                CodeCity = 101,
                NameCity = "Jerusalem",
                StatusCity = "Active",
                AddDateCity = new DateTime(2024, 04, 23)
            };
            LstCity.Add(Cit);

            Cit = new City()
            {
                CodeCity = 102,
                NameCity = "Tel Aviv",
                StatusCity = "Active",
                AddDateCity = new DateTime(2024, 04, 23)
            };
            LstCity.Add(Cit);

            Cit = new City()
            {
                CodeCity = 103,
                NameCity = "Haifa",
                StatusCity = "Active",
                AddDateCity = new DateTime(2024, 04, 23)
            };
            LstCity.Add(Cit);

            Cit = new City()
            {
                CodeCity = 104,
                NameCity = "Be'er Sheva",
                StatusCity = "Active",
                AddDateCity = new DateTime(2024, 04, 23)
            };
            LstCity.Add(Cit);
            Application["Cities"] = LstCity; // שמירת רשימת הערים בתוך הזיכרון מסוג אפליקיישן
            //--------------------

            // Categories \\
            Category Cat;
            Cat = new Category()
            {
                CodeCat = 1,
                NameCat = "Dairy products.",  // מוצרי חלב
                DescriptionCat = "Includes all types of milk.",
                ImageNameCat = "dairy_products_collection.jpg",
                ParentCodeCat = 10,
                StatusCat = "Active",
                AddDateCat = new DateTime(2024, 04, 23)
            };
            LstCategory.Add(Cat);

            Cat = new Category()
            {
                CodeCat = 2,
                NameCat = "vegetables", // ירקות
                DescriptionCat = "Organic vegetables.",
                ImageNameCat = "vegetables.jpg",
                ParentCodeCat = 20,
                StatusCat = "Active",
                AddDateCat = new DateTime(2024, 04, 23)
            };
            LstCategory.Add(Cat);

            Cat = new Category()
            {
                CodeCat = 3,
                NameCat = "Fruits",  // פירות
                DescriptionCat = "Organic fruits",
                ImageNameCat = "fruits.jpg",
                ParentCodeCat = 30,
                StatusCat = "Active",
                AddDateCat = new DateTime(2024, 04, 23)
            };
            LstCategory.Add(Cat);

            Cat = new Category()
            {
                CodeCat = 4,
                NameCat = "Disposable dishes", // סכום חד פעמי
                DescriptionCat = "A powerful disposable tool",
                ImageNameCat = "Disposable dishes.jpg",
                ParentCodeCat = 40,
                StatusCat = "Active",
                AddDateCat = new DateTime(2024, 04, 23)
            };
            LstCategory.Add(Cat);
            Application["Categories"] = LstCategory; // שמירת רשימת קטגוריות בתוך הזיכרון מסוג אפליקיישן

            //--------------------

            // Products \\
            Product Pro;
            Pro = new Product()
            {
                CodeProd = 10,
                NameProd = "Whole Milk",
                PriceProd = 550,
                DescriptionProd = "1 liter of whole milk, rich and nutritious",
                NameImageProd = "whole_milk.jpg",
                CodeCategoryProd = 1, 
                StatusProd = "Active",
                AddDateProd = new DateTime(2024, 04, 23)
            };
            LstProduct.Add(Pro);

            Pro = new Product()
            {
                CodeProd = 20,
                NameProd = "Cucumber", 
                PriceProd = 1,
                DescriptionProd = "Fresh, crisp cucumbers, perfect for salads and snacking",
                NameImageProd = "Cucumber.jpg",
                CodeCategoryProd = 2,
                StatusProd = "Active",
                AddDateProd = new DateTime(2024, 04, 23)
            };
            LstProduct.Add(Pro);

            Pro = new Product()
            {
                CodeProd = 30,
                NameProd = "Apple",
                PriceProd = 2,
                DescriptionProd = "Juicy and sweet red apples, perfect for a healthy snack",
                NameImageProd = "apple.jpg",
                CodeCategoryProd = 3,
                StatusProd = "Active",
                AddDateProd = new DateTime(2024, 04, 23)
            };
            LstProduct.Add(Pro);

            Pro = new Product()
            {
                CodeProd = 40,
                NameProd = "Disposable Plates",
                PriceProd = 3,
                DescriptionProd = "Pack of 20 disposable plates, eco-friendly and perfect for parties",
                NameImageProd = "disposable_plates.jpg",
                CodeCategoryProd = 4,
                StatusProd = "Active",
                AddDateProd = new DateTime(2024, 04, 23)
            };
            LstProduct.Add(Pro);
            Application["Products"] = LstProduct;  // שמירת רשימת מוצרים בתוך הזיכרון מסוג אפליקיישן

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}