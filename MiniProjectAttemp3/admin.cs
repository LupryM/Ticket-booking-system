using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectAttemp3
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intNummatches = Convert.ToInt32(InputBox("How many matches would you like to book", "Number of matches", ""));

            //Delcare 2 new arrays
            string[] NewMatch = new string[intNummatches];
            double[] NewLowestPrice = new double[intNummatches];
            


            for(int i = 0;i<intNummatches;i++)
            {
                //store input from input boxes into arrays
                NewMatch[i] = Convert.ToString(InputBox("Please Enter Match details", "Match", ""));
                NewLowestPrice[i] = Convert.ToDouble(InputBox("Please enter price", "price", ""));
                
                //Store the arrays into a class
                arrayclass.Match = NewMatch;
                arrayclass.LowestPrice = NewLowestPrice;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return to login form
            login f1 = new login();
            this.Visible = false;
            f1.ShowDialog();
        }
    }
}
