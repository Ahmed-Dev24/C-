using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace First_Project__Calculator_
{
    public partial class Form1 : Form
    {
        double num1, num2 , total ;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            first.Text = "100";
            second.Text = "4.56";
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(first.Text );
            num2 = double.Parse(second.Text);
            total = num1 + num2;
            total++ ;
            rch.Text = total.ToString();
            rch.ForeColor = Color.SeaShell;
            rch.BackColor = Color.Navy;
            button5.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(first.Text);
            num2 = double.Parse(second.Text);
            total = num1 - num2;
            rch.Text = total.ToString();
            rch.BackColor = Color.Salmon;
            rch.ForeColor = Color.SlateGray;
            button3.BackColor = Color.Red;
         }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(first.Text);
            num2 = double.Parse(second.Text);
            total = num1 * num2;
            rch.Text = total.ToString();
            rch.ForeColor = Color.Sienna;
            rch.BackColor = Color.Aqua;
            button4.BackColor = Color.BlueViolet;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(first.Text);
            num2 = double.Parse(second.Text);
            total = num1 / num2;
            rch.Text = total.ToString();
            rch.BackColor = Color.Black;
            rch.ForeColor = Color.MistyRose;
            button6.BackColor = Color.Yellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label9.Text ="R1 : "+lblresult.Text +" / R2 : "+ rch.Text;
            label9.ForeColor = Color.DarkCyan;
            button7.BackColor = Color.DarkSalmon;
            button7.ForeColor = Color.Snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tbname.ForeColor = Color.Fuchsia;
            Tbname.BackColor = Color.LightBlue;
            label1.ForeColor = Color.DarkCyan;
            lblresult.ForeColor = Color.Azure;
            lblresult.BackColor = Color.LightSteelBlue;
            label2.ForeColor = Color.Green;
            Tbsalary.BackColor = Color.Green;
            Tbsalary.ForeColor = Color.Snow;
            label3.ForeColor = Color.Red;
            Tbprice.BackColor = Color.Red;
            Tbprice.ForeColor = Color.BlanchedAlmond;
            Tbvat.BackColor = Color.Black;
            Tbvat.ForeColor = Color.White;


            String name = Tbname.Text;
            double salary , usd , vat , totalbfvat , totalsalary , VAT ;
            salary = double.Parse(Tbsalary.Text);
            usd = double.Parse(Tbprice.Text);
            vat = double.Parse(Tbvat.Text);
            totalbfvat = salary * usd;
            totalsalary = totalbfvat - totalbfvat *vat;
            VAT = totalbfvat - totalsalary ; 
            lblresult.Text = name + " Your total Salary after VAT is: "+ totalsalary +  " The VAT Value is: " + VAT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(first.Text);
            num2 = double.Parse(second.Text);
            total = num1 + num2;
            /**/
            rch.Text = total.ToString();
            /*       
             How to make the text in the center                            
                                         */
            rch.ForeColor = Color.Crimson;
            rch.BackColor = Color.Silver;
            button2.BackColor = Color.Cornsilk;
        }
    }
}
