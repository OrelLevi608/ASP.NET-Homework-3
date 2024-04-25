using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<City> LstCity = (List<City>)Application["Cities"]; // הגדרת רשימה עבור ערים
            for (int i = 0; i < LstCity.Count; i++) // לולאה שעוברת על רשימת הערים שקיימים במערכת
            {
                DDLRegisCity.Items.Add(new ListItem(LstCity[i].NameCity)); // DropDownList הצגת הרשימה למשתמש לתוך הדף הרשמה ויצרת רשמיה לבחירה עבור המשתמש באמצעות 
                DDLRegisCodeCity.Items.Add(new ListItem(LstCity[i].CodeCity + "")); // DropDownList הצגת הרשימה למשתמש לתוך הדף הרשמה ויצרת רשמיה לבחירה עבור המשתמש באמצעות 
            }
        }

        protected void BtnRegis_Click(object sender, EventArgs e) // פונקציה של כפתור הרשמה
        {
            List<Client> LstClient = (List<Client>)Application["Clients"];
            string email = TextRegisEmail.Text; // email הפנייה לתיבת הטקסט שהמשתמש מזין את הערך ומבצע פעולת השמה לתוך המשתנה
            string password = TextRegisPass.Text; // password הפנייה לתיבת הטקסט שהמשתמש מזין את הערך ומבצע פעולת השמה לתוך המשתנה
            bool userExists = false;  // משתנה לבדיקה אם המשתמש כבר קיים


            for (int i = 0; i < LstClient.Count; i++) // לולאה שתעבור על רשימת הלקוחות ותבדוק האם הלקוח כבר קיים במערכת עם אותו דוא"ל וסיסמה
            {
                if (LstClient[i].EmailClie == email)
                {
                    userExists = true; // true אם נמצא משתמש, מעדכנים את המשתנה ל
                    LtlMsg.Text = "User already exists"; // הצגת הודעה
                    break; // יציאה מהלולאה
                }
            }

            if (!userExists)  // אם המשתמש לא קיים,יוצר לקוח חדש
            {
                Client newClient = new Client // Client יצירת אובייקט חדש מסוג 
                {
                    EmailClie = email,  // (email לוקח את הערך שהמשתמש הזין ומעביר אותו לתוכנה שקיימת במערכת (אובייקט החדש עם הערך שנקלט מהמשתמש
                    PasswordClie = password  // (password לוקח את הערך שהמשתמש הזין ומעביר אותו לתוכנה שקיימת במערכת (אובייקט החדש עם הערך שנקלט מהמשתמש
                };
                LstClient.Add(newClient); // הוספת הלקוח לרשימה
                Application["Clients"] = LstClient; // עדכון הרשימה באפליקציה

                Session["Login"] = newClient; // שמירת הלקוח בסשן
                Response.Redirect("ProductList.aspx"); // העברה לעמוד רשימת מוצרים
            }
        }
        




    }
}