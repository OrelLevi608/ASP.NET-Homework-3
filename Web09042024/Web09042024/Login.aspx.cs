using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            List<Client> LstClient = (List<Client>)Application["Clients"]; // הגדרת רשימה עבור לקוחות

            string Email = TextEmail.Text; // Login מבצע פעולת השמה של הערך שהמשתמש הכניס בתוך התיבת טקסט של המייל בדף ה
            string Pass = TextPass.Text; // Int ומבצע המרה של הערך ל Login מבצע פעולת השמה של הערך שהמשתמש הכניס בתוך התיבת טקסט של הסיסמה בדף ה

            for (int i = 0; i < LstClient.Count; i++) // (Client) לולאה שעוברת על מחלקה של הלקוחות
            {
                if (LstClient[i].EmailClie == Email && LstClient[i].PasswordClie == Pass) // אם נמצא לקוח עם המייל והסיסמה אז כנס
                {
                    Session["Login"] = LstClient[i]; // ושמור בתוכו את האוביקט של הלקוח Login יצירת משתנה מסוג סשן בשם 
                    Response.Redirect("ProductList.aspx"); // נעביר את הגולש לעמוד רשימת מוצרים
                    
                }
            }

            LtlMsg.Text = "Email or password error"; // במידה והסימה או כתובת המייל לא נכונה תוצג הודעה זו



        }
    }
}