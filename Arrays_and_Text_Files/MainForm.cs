using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arrays_and_Text_Files
{
    public partial class MainForm : Form
    {
        // set form level variables here
        int qty;                                            // declared variable to reference quantity value for qty_textbox
        decimal subtotal;                                   // variable for subtotal to reference in subtotal_textbox; will need to multiply by value of qty
        decimal tax;                                        // variable for tax to reference in subtotal_textbox; will need to calculate 5% of subtotal value
        decimal total;                                      // variable for subtotal to reference in subtotal_textbox; will need to add subtotal and tax values

        // declare arrays here
        decimal[,] prices;                                  // variable for 2D array for prices, will need to be a 4x6 rectangular array
        string[] size = {"S", "M" , "L" , "XL"};            // variable for clothes size
        string[] style = { "Plain Black/White", "Plain Colour", "White w/Black Logo", "Colour w/Black Logo", "Black w/Silver Logo", "Colour w/Silver Logo"};


        string path = "ABC_Textiles_Prices.txt";            // this is an external file placed in the bin folder of my repository 

       


        // set the txt file integers into a 2D array

        // 

        public MainForm()
        {
            InitializeComponent();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // load the txt file
        private void MainForm_Load(object sender, EventArgs e)      // created by selecting the form, going to Events in properties, and selecting "Load" event handler
        {

        }
    }
}
