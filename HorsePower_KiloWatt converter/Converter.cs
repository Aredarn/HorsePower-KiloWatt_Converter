using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorsePower_KiloWatt_converter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }


        //declares the key variables for the program.
        string Upper_L, Lower_L;
        int User_Value;
        double FinalValue;

        //constant variables for the convert (official values based off google.com search)
        const double kwTOhp = 1.34102209, hpTOkw = 0.745699872;


        private void Convert_Click_Click(object sender, EventArgs e)
        {
            
            Upper_L = Upper_Format_Label.Text;
            Lower_L = Lower_Format_Label.Text;
            
            try 
            {
                User_Value = int.Parse(Value_TextBox.Text);

                if (Upper_L == "Kw")
                {
                    FinalValue = User_Value * kwTOhp;

                }
                else
                {
                    FinalValue = User_Value * hpTOkw;
                }
                Final_Value_Label.Text = $"{FinalValue:0}";
            }
            catch
            {
                Final_Value_Label.Text = "Give a number";
            }
        }

        private void Swap_Format_Click_Click(object sender, EventArgs e)
        {
            Upper_L = Upper_Format_Label.Text;
            Lower_L = Lower_Format_Label.Text;

            if(Upper_L == "Hp")
            {
                Lower_Format_Label.Text = "Hp";
                Upper_Format_Label.Text = "Kw";
            }
            else
            {
                Lower_Format_Label.Text = "Kw";
                Upper_Format_Label.Text = "Hp";
            }
        }
    }
}
