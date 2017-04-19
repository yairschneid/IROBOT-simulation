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
        

        public simulation()
        {
            InitializeComponent();

            int Lshort=0, Llong=0;
            double Vd=0, Vr=0, R=0, pi = 3.14;

            double new_Cclean = 1 - (((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / 16 * Lshort * Llong));
            double boundry_Cclean = 1 - (((R * R * (4 - pi) * ((2 * (Lshort - R) + 2) / R) / (16 * Lshort * Llong))));
            double bnf_Cclean = 1 - ((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / (16 * Lshort * Llong));

            double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
            double bnf_Tshort = ((Lshort - R) / Vd);
            double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);
            double bnf_Ttotal = bnf_Tlong + bnf_Tshort + bnf_Trotation;

            double alpha = (int)((Lshort - R) / R) + 1;
            double boundry_Tlong = alpha * ((2 * (Llong - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Tshort = alpha * ((2 * (Lshort - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Trotation = ((90 * 2 * alpha) / Vr);
            double boundry_Treturn = Math.Sqrt(((Math.Pow(((Llong - R) / (2)), 2) + (Math.Pow((Lshort - R) / 2, 2)) / Vd)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
