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
    public partial class CartForm : Form
    {
        // Public Property used for indicating the if the user is logged between the parent form and this form
        public bool UserLoggedIn { get; set; }

        public CartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Processes the Shopping Cart Event by displaying a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shopping Cart Button Clicked.");
        }

        /// <summary>
        /// Form Initialization like setting the initial state of the shopping cart button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartForm_Load(object sender, EventArgs e)
        {
            shoppingCartButton.Enabled = UserLoggedIn;
        }
    }
}
