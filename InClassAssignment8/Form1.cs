using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Amanda Pace
//Bill Hughes, CST-117
//15 November 2020
//InClassAssignment 8

//This is my own work.
namespace InClassAssignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Methods implemented when button is pressed in order to make calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            //FatCalories Method =====================

                //Variable from user
                int fatGram = Convert.ToInt32(txtFatInput.Text);

                //Calling method
                Methods getMethod1 = new Methods();

                //Inputting var into method, getting result
                int calFat = getMethod1.FatCalories(fatGram);

                //Displays result in form label
                lblCalFat.Text = calFat.ToString();


            //CarbCalories Method======================

                //Variable from user
                int carbGram = Convert.ToInt32(txtCarbInput.Text);

                //Calling method
                Methods getMethod2 = new Methods();

                //Inputting var into method, getting result
                int calCarb = getMethod2.CarbCalories(carbGram);

                //Displays result in form label
                lblcalCarb.Text = calCarb.ToString();
        }
    }
}
