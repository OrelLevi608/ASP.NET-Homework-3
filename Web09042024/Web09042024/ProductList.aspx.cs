using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Client> LstClient = (List<Client>)Application["Clients"]; // הגדרת רשימה עבור לקוחות
                if (Session["Login"] != null) // אינו ריק - זה אומר שהמשתמש כבר התחבר למערכת Session במידה ו
                {
                    Client Tmp = (Client)Session["Login"]; // (Client) ביצוע המרה ל
                    LtlUeser.Text = $"Hello {Tmp.FirstNameClie} {Tmp.LastNameClie}"; // במידה והמשתמש התחבר כשורה תוצג לא הודעה עם - השם והשם משפחה שלו
                }
                else
                {
                    LtlUeser.Text = "Hello Guest"; // במידה והמשתמש לא התחבר למערכת ונכנס ישירות לדף המוצרים, תוצג לו הודעה - שלום אורח
                }

                List<Product> LstProduct = (List<Product>)Application["Products"];  // Application טעינת רשימת המוצרים 
                for (int i = 0; i < LstProduct.Count; i++)  // (ממשק) HTML לולאה שרצה על כל המוצרים ומוסיפה לדף
                {
                    DDLCodeProd.Items.Add(new ListItem(LstProduct[i].CodeProd + ""));
                    DDLNameProd.Items.Add(new ListItem(LstProduct[i].NameProd));
                    DDLPriceProd.Items.Add(new ListItem(LstProduct[i].PriceProd +""));
                    DDLDescProd.Items.Add(new ListItem(LstProduct[i].DescriptionProd));
                    NameImageProd.Items.Add(new ListItem(LstProduct[i].NameImageProd));
                    DDLCodeCatPord.Items.Add(new ListItem(LstProduct[i].CodeCategoryProd + ""));
                    DDLStatusProd.Items.Add(new ListItem(LstProduct[i].StatusProd));
                    
                }
            }
            

        }
    }
}