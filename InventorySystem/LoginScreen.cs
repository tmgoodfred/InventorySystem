using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class LoginScreen : Form
    {
        Dictionary<string, string> userPass = new Dictionary<string, string>(); //will temp hold usernames and passwords
        public LoginScreen()
        {
            InitializeComponent();
            userPass.Add("tyler", "password");
            userPass.Add("test", "test");

            /*try   for if I want to check if user already exists if I add a create account button
            {
                userPass.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }*/
        }

        private void loginSubmitBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = "", enteredPassword = "";    //a string to store and compare the user entered info
            string dictPassword = "";                        //a string to store and compare the related dictionary password
            bool userPassFlag = false, passCheck = false;
            while (userPassFlag == false)
            {
                if (usernameTxtBx.Text != null || usernameTxtBx.Text != "")
                {
                    enteredUsername = usernameTxtBx.Text;
                    userPassFlag = true;
                }
                else
                    errorLbl.Text = "Please Enter a Username";
                if (passwordTxtBx.Text != null || passwordTxtBx.Text != "")
                {
                    enteredPassword = passwordTxtBx.Text;
                    userPassFlag = true;
                }
                else
                {
                    errorLbl.Text = "Please Enter a Password";
                    userPassFlag = false;   //I add this here just in case the username is correct, but the password is false. 
                }
            }
            string value = "";
            while (passCheck != true)
            {
                if (userPass.TryGetValue(enteredUsername, out value))
                {
                    if (enteredPassword.Equals(value))
                    {
                        //successful login!
                        var mainScreenForm = new MainScreen();
                        Console.WriteLine("You're in");
                        mainScreenForm.ShowDialog();
                        this.Close();
                        passCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Big Whiff!");
                        errorLbl.Text = "Incorrect Password";
                    }
                }
            }
        }
    }
}
