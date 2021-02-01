using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;


namespace ModernCalulator
{
    public partial class Form1 : Form
    {

        List<variables> xyz = new List<variables>(){ new variables(DateTime.Now.ToShortTimeString(),2,4,5)};
        List<variables> xy = new List<variables>() { };
        List<string> people = new List<string>() { "Student", "Teacher", "Other" };

        JavaScriptSerializer write = new JavaScriptSerializer();


        public Form1()
        {


            InitializeComponent();

            splash s = new splash();
            s.ShowDialog();

            dgdView.DataSource = xyz;
            dgdView2.DataSource = xy;
            pbx1.Image = Image.FromFile("logo1.jpg");
            cboPeople.DataSource = people;
            LoadData();

        }
        private void LoadData()
        {
            string filename = "3variable.json";
            string input = File.ReadAllText(filename);


            dgdView.DataSource = null;
            xyz = write.Deserialize<List<variables>>(input);

            dgdView.DataSource = xyz;

            string filename2 = "2variable.json";
            string input2 = File.ReadAllText(filename2);

            dgdView2.DataSource = null;
            xy = write.Deserialize<List<variables>>(input2);
            dgdView2.DataSource = xy;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int a11=Convert.ToInt32(txta11.Text), a12 = Convert.ToInt32(txta12.Text), a13 = Convert.ToInt32(txta13.Text);   
            int a21 = Convert.ToInt32(txta21.Text), a22 = Convert.ToInt32(txta22.Text), a23 = Convert.ToInt32(txta23.Text);
            int a31 = Convert.ToInt32(txta31.Text), a32 = Convert.ToInt32(txta32.Text), a33 = Convert.ToInt32(txta33.Text);

            int b11 = Convert.ToInt32(txtb11.Text), b12=Convert.ToInt32(txtb12.Text), b13 = Convert.ToInt32(txtb13.Text);
            int b21 = Convert.ToInt32(txtb21.Text), b22 = Convert.ToInt32(txtb22.Text), b23 = Convert.ToInt32(txtb23.Text);
            int b31 = Convert.ToInt32(txtb31.Text), b32 = Convert.ToInt32(txtb32.Text), b33 = Convert.ToInt32(txtb33.Text);


            int c11=a11+b11, c12 = a12 + b12, c13 = a13 + b13;
            int c21 = a21 + b21, c22 = a22 + b22, c23 = a23 + b23;
            int c31 = a31 + b31, c32 = a32 + b32, c33 = a33 + b33;

            txt1.Text = Convert.ToString(c11);
            txt2.Text = Convert.ToString(c12);
            txt3.Text = Convert.ToString(c13);
            txt4.Text = Convert.ToString(c21);
            txt5.Text = Convert.ToString(c22);
            txt6.Text = Convert.ToString(c23);
            txt7.Text = Convert.ToString(c31);
            txt8.Text = Convert.ToString(c32);
            txt9.Text = Convert.ToString(c33);


        }

        private void Sub_Click(object sender, EventArgs e)
        {
            int a11 = Convert.ToInt32(txta11.Text), a12 = Convert.ToInt32(txta12.Text), a13 = Convert.ToInt32(txta13.Text);
            int a21 = Convert.ToInt32(txta21.Text), a22 = Convert.ToInt32(txta22.Text), a23 = Convert.ToInt32(txta23.Text);
            int a31 = Convert.ToInt32(txta31.Text), a32 = Convert.ToInt32(txta32.Text), a33 = Convert.ToInt32(txta33.Text);

            int b11 = Convert.ToInt32(txtb11.Text), b12 = Convert.ToInt32(txtb12.Text), b13 = Convert.ToInt32(txtb13.Text);
            int b21 = Convert.ToInt32(txtb21.Text), b22 = Convert.ToInt32(txtb22.Text), b23 = Convert.ToInt32(txtb23.Text);
            int b31 = Convert.ToInt32(txtb31.Text), b32 = Convert.ToInt32(txtb32.Text), b33 = Convert.ToInt32(txtb33.Text);


            int c11 = a11 - b11, c12 = a12 - b12, c13 = a13 - b13;
            int c21 = a21 - b21, c22 = a22 - b22, c23 = a23 - b23;
            int c31 = a31 - b31, c32 = a32 - b32, c33 = a33 - b33;

            
            
            txt1.Text = Convert.ToString(c11);
            txt2.Text = Convert.ToString(c12);
            txt3.Text = Convert.ToString(c13);
            txt4.Text = Convert.ToString(c21);
            txt5.Text = Convert.ToString(c22);
            txt6.Text = Convert.ToString(c23);
            txt7.Text = Convert.ToString(c31);
            txt8.Text = Convert.ToString(c32);
            txt9.Text = Convert.ToString(c33);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txta11.Text = ""; txta12.Text = ""; txta13.Text = "";
            txta21.Text = ""; txta22.Text = ""; txta23.Text = "";
            txta31.Text = ""; txta32.Text = ""; txta33.Text = "";

            txtb11.Text = ""; txtb12.Text = ""; txtb13.Text = "";
            txtb21.Text = ""; txtb22.Text = ""; txtb23.Text = "";
            txtb31.Text = ""; txtb32.Text = ""; txtb33.Text = "";

            txt1.Text = ""; txt2.Text = ""; txt3.Text = ""; txt4.Text = ""; txt5.Text = "";
            txt6.Text = ""; txt7.Text = ""; txt8.Text = ""; txt9.Text = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int a11 = Convert.ToInt32(txta11.Text), a12 = Convert.ToInt32(txta12.Text), a13 = Convert.ToInt32(txta13.Text);
            int a21 = Convert.ToInt32(txta21.Text), a22 = Convert.ToInt32(txta22.Text), a23 = Convert.ToInt32(txta23.Text);
            int a31 = Convert.ToInt32(txta31.Text), a32 = Convert.ToInt32(txta32.Text), a33 = Convert.ToInt32(txta33.Text);

            int b11 = Convert.ToInt32(txtb11.Text), b12 = Convert.ToInt32(txtb12.Text), b13 = Convert.ToInt32(txtb13.Text);
            int b21 = Convert.ToInt32(txtb21.Text), b22 = Convert.ToInt32(txtb22.Text), b23 = Convert.ToInt32(txtb23.Text);
            int b31 = Convert.ToInt32(txtb31.Text), b32 = Convert.ToInt32(txtb32.Text), b33 = Convert.ToInt32(txtb33.Text);

            int c11 = (a11 * b11) + (a12 * b21) + (a13 * b31);int c12 = (a11 * b12) + (a12 * b22) + (a13 * b32), c13 = (a11 * b13) + (a12 * b23) + (a13 * b33);
            int c21 = (a21 * b11) + (a22 * b21) + (a23 * b31); int c22 = (a21 * b12) + (a22 * b22) + (a23 * b32), c23 = (a21 * b13) + (a22 * b23) + (a23 * b33);
            int c31 = (a31 * b11) + (a32 * b21) + (a33 * b31); int c32 = (a31 * b12) + (a32 * b22) + (a33 * b32), c33 = (a31 * b13) + (a32 * b23) + (a33 * b33);

            txt1.Text = Convert.ToString(c11);
            txt2.Text = Convert.ToString(c12);
            txt3.Text = Convert.ToString(c13);
            txt4.Text = Convert.ToString(c21);
            txt5.Text = Convert.ToString(c22);
            txt6.Text = Convert.ToString(c23);
            txt7.Text = Convert.ToString(c31);
            txt8.Text = Convert.ToString(c32);
            txt9.Text = Convert.ToString(c33);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(12, 207, 200);
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            
            lblError.Text = "";
            
            double a11 = Convert.ToDouble(t11.Text), a12 = Convert.ToDouble(t12.Text), a13 = Convert.ToDouble(t13.Text);
            double a21 = Convert.ToDouble(t21.Text), a22 = Convert.ToDouble(t22.Text), a23 = Convert.ToDouble(t23.Text);
            double a31 = Convert.ToDouble(t31.Text), a32 = Convert.ToDouble(t32.Text), a33 = Convert.ToDouble(t33.Text);

            double ad11 = ((a22 * a33) - (a23 * a32));
            double ad12 = -((a21 * a33) - (a23 * a31));
            double ad13 = ((a21 * a32) - (a22 * a31));
            double ad21 = -((a12 * a33) - (a32 * a13));
            double ad22 = ((a11 * a33) - (a31 * a13));
            double ad23 = -((a11 * a32) - (a31 * a12));
            double ad31 = ((a12 * a23) - (a13 * a22));
            double ad32 = -((a11 * a23) - (a21 * a13));
            double ad33 = ((a11 * a22) - (a12 * a21));


            double sf1 = a11 * ((a22 * a33) - (a23 * a32));
            double sf2 = a12 * ((a21*a33) - (a23*a31)) ;
            double sf3 = a13 * ((a21 * a32) - (a22 * a31));

            double A = sf1 - sf2 + sf3;

            

            double a1 = Convert.ToDouble(t14.Text); double a2 = Convert.ToDouble(t24.Text); double a3 = Convert.ToDouble(t34.Text);

            

            double c11 = ad11;   double c12 = ad21; double c13 = ad31;

            double c22 = ad22;double c21 = ad12;double c23 = ad32;

            double c33 = ad33;double c31 = ad13;double c32 = ad23;


            c11 = c11 / A;
            c12 = c12 / A;
            c13 = c13 / A;
            c21 = c21 / A;
            c22 = c22 / A;
            c23 = c23 / A;
            c31 = c31 / A;
            c32 = c32 / A;
            c33 = c33 / A;

   

            double f1 = (c11 * a1) + (c12 * a2) + (c13 * a3); f1 = Math.Round(f1, 3);
            double f2 = (c21 * a1) + (c22 * a2) + (c23 * a3); f2 = Math.Round(f2, 3);
            double f3 = (c31 * a1) + (c32 * a2) + (c33 * a3);f3 = Math.Round(f3, 3);


            txtX.Text = Convert.ToString(f1);
            txtY.Text = Convert.ToString(f2);
            txtZ.Text = Convert.ToString(f3);


            if (txtX.Text == "NaN" || txtY.Text == "NaN" || txtZ.Text == "NaN")
            { lblError.Text = "If the output is NaN, it means either the equations have no solution or you have enterred a wrong Input"; }
            
            if (chkSave.Checked)
            {
                
                

                string time = DateTime.Now.ToLongTimeString();

                variables v1 = new variables(time, f1, f2, f3);
                dgdView.DataSource = null;


                xyz.Add(v1);

                dgdView.DataSource = xyz;

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        public void getData(double a1,double a2)
        {
            double a3 = 0;

           
            
            dgdView2.DataSource = null;
            string time = DateTime.Now.ToLongTimeString(); 

            variables v1 = new variables(time,a1, a2, a3);
           

            xy.Add(v1);

            dgdView2.DataSource = xy;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = "3variable.json";
       

            string output = write.Serialize(xyz);
            File.WriteAllText(filename, output);


            string filename2 = "2variable.json";
            string output2 = write.Serialize(xy);
            File.WriteAllText(filename2, output2);

        }

      
    }
}
