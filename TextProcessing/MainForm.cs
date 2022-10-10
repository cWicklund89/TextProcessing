using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessing
{
    public partial class MainForm : Form
    {
        // Parent will keep track of whether user is logged in or not
        private bool userLoggedIn;


        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialization activities that should occur when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Responsible for setting our property value to false and disabling Menu Option 1.
            OnLoggedInUpdate(false);
        }

        /// <summary>
        /// Displays Login Dialog for entry of username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            // Set the child's property value with the current value stored in the parent
            loginForm.UserLoggedIn = userLoggedIn;
            // Show the form as a dialog instead of as a normal window
            loginForm.ShowDialog();
            OnLoggedInUpdate(loginForm.UserLoggedIn);
        }

        /// <summary>
        /// This does the heavy lifting for processing the user login dialog feedback.  First, it will get stored
        /// in the parent's class variable.  Next, we have a Menu Option 1, that we really haven't done anything with,
        /// but we are using it to show that menu options can be disabled based on whether the user is logged in or not.
        /// Finally, we are going to check to see if the Shopping cart has been launched.  If it has, then we want to ensure
        /// that we set the state of the button on the instance that was previously created to disable or enable it depending
        /// on the returned value from validation.
        /// </summary>
        /// <param name="didUserLogIn">boolean value indicating whether the user's login attempt was successful</param>
        private void OnLoggedInUpdate(bool didUserLogIn)
        {
            //throw new NotImplementedException();
            Form form;
            const string shoppingCartButton = "shoppingCartButton";

            // Set the parent class attribute value
            userLoggedIn = didUserLogIn;

            // Set the Menu Option 1 state to enabled or disabled depending on whether login was successful
            menuOption1ToolStripMenuItem.Enabled = userLoggedIn;

            // Check to see if the Shopping Cart Form was launched previously.  If it was,
            // then we need to grab the instance, locate the button in its form controls and set 
            // the value of the button's enabled property based on the password validation results.
            if (CheckIfFormCreated(typeof(CartForm), out form))
            {
                if (form != null)
                {
                    if (form.Controls.ContainsKey(shoppingCartButton))
                    {
                        var control = form.Controls[shoppingCartButton];
                        control.Enabled = userLoggedIn;
                    }
                }
            }
        }



        /// <summary>
        /// Will cause the application to close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Will display the shopping cart form.  The button will be used to demonstrate how it can be enabled 
        /// and disabled based on user login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuOption2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form;
            if (!CheckIfFormCreated(typeof(CartForm), out form))
            {
                CartForm cartForm = new CartForm();
                cartForm.MdiParent = this;
                cartForm.WindowState = FormWindowState.Maximized;

                // Just need to set our property before showing the form!!!
                cartForm.UserLoggedIn = userLoggedIn;

                cartForm.Show();
            }
        }

        /// <summary>
        /// Determines whether the window has been created and just needs to be 
        /// activated.
        /// </summary>
        /// <param name="formType">Type of the form being checked</param>
        /// <param name="formInstance">Returns the form Instance</param>
        /// <returns>boolean indicating whether the window was previously created 
        /// and could be activated</returns>
        private bool CheckIfFormCreated(Type formType, out Form formInstance)
        {
            bool formCreated = false;
            formInstance = null;

            // Check all open forms to see if this form has already been instantiated
            foreach (Form form in Application.OpenForms)
            {
                // If the type matches, then activate the form instance
                if (form.GetType() == formType)
                {
                    formCreated = true;
                    formInstance = form;
                    form.Activate();
                    break;
                }
            }

            return formCreated;
        }

        /// <summary>
        /// Sets the userLoggedIn property to false and then locks down the necessary form controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLoggedInUpdate(false);
        }
    }
}
