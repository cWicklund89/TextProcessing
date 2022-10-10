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
    public partial class LoginForm : Form
    {

        // Public Property used for indicating the if the user is logged between the parent form and this form
        public bool UserLoggedIn { get; set; }

        public LoginForm()
        {
            InitializeComponent();

            // Disable the Auto Validation
            this.AutoValidate = AutoValidate.Disable;
        }

        /// <summary>
        /// Close the Login Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates the User Name to ensure that something was entered.  If there were
        /// specific business rules than those would be implemented here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// Validates a password and determines if the entry is valid.  
        /// </summary>
        /// <param name="password">Input password to validate</param>
        /// <param name="message">Returns a specific message in the event that the password was not valid</param>
        /// <returns>A boolean value indicating whether the password is valid or not</returns>
        private bool IsPasswordValid(string password, out string message)
        {
            bool isValid = false;
            message = "";
            int upperCount = 0, lowerCount = 0, numberCount = 0, specialCharacterCount = 0;

            const int MIN_LENGTH = 8;

            if (password.Length < MIN_LENGTH)
                message = $"Password must be at least {MIN_LENGTH} characters in length";
            else
            {
                // check for upper, lower, numbers, and special characters by incrementing a counter for each
                foreach (char passwordCharacter in password)
                {
                    if (char.IsUpper(passwordCharacter)) upperCount++;
                    if (char.IsLower(passwordCharacter)) lowerCount++;
                    if (char.IsDigit(passwordCharacter)) numberCount++;
                    if (!char.IsLetterOrDigit(passwordCharacter) &&
                        !char.IsWhiteSpace(passwordCharacter)) specialCharacterCount++;
                }

                // Now check to see if all counts are greater than 0, which means that the at least 1 requirement is satisfied
                if (upperCount > 0 && lowerCount > 0 && numberCount > 0 && specialCharacterCount > 0)
                    isValid = true;
                else if (upperCount == 0)   // Missing Upper Case Letter
                    message = "Password entry requires at least 1 uppercase letter.";
                else if (lowerCount == 0)   // Missing Lower Case Letter
                    message = "Password entry requires at least 1 lowercase letter.";
                else if (numberCount == 0)  // Missing Digit, i.e., Number
                    message = "Password entry requires at least 1 digit.";
                else                       // Missing Special Character
                    message = "Password entry requires at least 1 special character.";
            }

            return isValid;
        }

        /// <summary>
        /// IGNORE IGNORE IGNORE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            /////NOTHING TO SEE HERE
        }

        /// <summary>
        /// Validates the Password Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            string message = null;
            e.Cancel = !IsPasswordValid(passwordTextBox.Text, out message);
            errorProvider1.SetError(passwordTextBox, message);
        }

        /// <summary>
        /// Validaes the Password Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Based on the Password Validation set the property
            UserLoggedIn = ValidateChildren();

            /* We only want to close the window when a password entry is successful.  
                Otherwise, the user should be getting validation messages from the error provider to
                guide correction of the password value
            */
            if (UserLoggedIn)
                this.Close();
        }


    }


}
