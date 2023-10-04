using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErianFizzBuzz
{
    public partial class FrmFizz : Form
    {
        public FrmFizz()
        {
            InitializeComponent();
        }

        private void bttnGaan_Click(object sender, EventArgs e)
        {
            try { 
            // geeft de number een variable
            int aantal = int.Parse(txtAantal.Text);
                // herhaalt het steeds tot het aantal
                for (int i = 0; i <= aantal; i++)
                {// checked of het fizz, buzz of fizzbuzz is
                    
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        lbxFizz.Items.Add("fizzbuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        lbxFizz.Items.Add("fizz");
                    }

                    else if (i % 5 == 0)
                    {
                        lbxFizz.Items.Add("buzz");
                    }

                    

                    else
                    {// print het cijfers uit
                        lbxFizz.Items.Add(i);
                    }

                }
                
            }

            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }
    }
}
