using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irobot_simulation
{
    public partial class simulation : Form
    {

        int Lshort = 0, Llong = 0;
        double Vd = 0, Vr = 0, R = 0, pi = 3.14;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

      

        public simulation()
        {
            InitializeComponent();

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Llong = int.Parse(Llong_text.Text);
            Lshort = int.Parse(Lshort_text.Text);
            Double.TryParse(vd_text.Text, out Vd);
            Double.TryParse(vr_text.Text, out Vr);
            Double.TryParse(r_text.Text, out R);
            new_CCPN(Lshort, Llong, Vd, Vr, R, pi);
            back_and_forth(Lshort, Llong, Vd, Vr, R, pi);
            boundary_sweep(Lshort, Llong, Vd, Vr, R, pi);

            





        }

        private void new_CCPN(int Lshort,int Llong,double Vd,double Vr,double R,double pi)
        {
            double new_Cclean = 1 - (((2 * R * R * (4 - pi) * ((int)(Lshort / R))) / (16 * Lshort * Llong)));
            double new_CTlong = (((((Lshort - R) / R) * (Llong - 2 * R)) + R) / Vd);
            double new_CTshort = 2 * ((Lshort - R) / Vd);
            double new_CTrotation = 90 * 2 * ((((Lshort - R) / R) - 1) / Vr);
            double new_CTotal = new_CTlong + new_CTshort + new_CTrotation;


            cp_box.Text = new_Cclean.ToString();
            cp_time.Text = new_CTotal.ToString();

        }

        private void back_and_forth(int Lshort, int Llong, double Vd, double Vr, double R, double pi)
        {
            double bnf_Cclean = 1 - ((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / (16 * Lshort * Llong));
            double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
            double bnf_Tshort = ((Lshort - R) / Vd);
            double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);
            double bnf_Ttotal = bnf_Tlong + bnf_Tshort + bnf_Trotation;

            t1.Text = bnf_Tlong.ToString();
            t2.Text = bnf_Tshort.ToString();
            t3.Text = bnf_Trotation.ToString();
            bnf_box.Text = bnf_Cclean.ToString();
            bf_time.Text = bnf_Ttotal.ToString();

        }



        private void boundary_sweep(int Lshort, int Llong, double Vd, double Vr, double R, double pi)
        {

            double boundry_Cclean = 1 - (((R * R * (4 - pi) * ((2 * (Lshort - R) + 2) / R) / (16 * Lshort * Llong))));
            double alpha = (int)((Lshort - R) / R) + 1;
            double boundry_Tlong = alpha * ((2 * (Llong - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Tshort = alpha * ((2 * (Lshort - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Trotation = ((90 * 2 * alpha) / Vr);
            double boundry_Treturn = Math.Sqrt(((Math.Pow(((Llong - R) / (2)), 2) + (Math.Pow((Lshort - R) / 2, 2)) / Vd)));
            double bounday_Ttotal = boundry_Treturn + boundry_Tshort + boundry_Tlong;

            bs_box.Text = boundry_Cclean.ToString();
            bs_time.Text = bounday_Ttotal.ToString();

        }







    }
}
