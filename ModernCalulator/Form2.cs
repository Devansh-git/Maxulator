using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCalulator
{
    public partial class Form2 : Form
    {
        
        

        Form1 parentForm;
        public Form2(Form1 f)
        {
            

            InitializeComponent();
            parentForm = f;
          

        }




        private void button1_Click(object sender, EventArgs e)
        {
            
            lblError.Text = "";
            
            double x1 = Convert.ToDouble(txtx1.Text), x2 = Convert.ToDouble(txtx2.Text),
                y1 = Convert.ToDouble(txty1.Text), y2 = Convert.ToDouble(txty2.Text),
                z1 = Convert.ToDouble(txtz1.Text), z2 = Convert.ToDouble(txtz2.Text);

          
          

            double a1, a2;

            a1 = ((z1 * x2) - (z2 * x1)) / ((x2 * y1) - (y2 * x1));

            a2 = (z1-(y1*a1))/x1;

            txta1.Text = Convert.ToString(a1);
            txta2.Text = Convert.ToString(a2);

            if (txta1.Text == "NaN" || txta1.Text == "NaN")
            {
                lblError.Text = "If the output is NaN, it means either the equations have no solution or you have enterred a wrong Input";
            }
        }

        private void btnSD_Click(object sender, EventArgs e)
        {

            double a1, a2;

            a1 = Convert.ToDouble(txta1.Text);
            a2 = Convert.ToDouble(txta2.Text);

            parentForm.getData(a1, a2);
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
