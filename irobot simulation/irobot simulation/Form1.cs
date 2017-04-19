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
        int Lshort, Llong;
        double Vd, Vr, R, pi = 3.14;

        double new_Cclean = 1 - (((2 * R * R * (4 - pi) * ((int)(Lshort / R)+1))/ 16 * Lshort * Llong));
        double boundry_Cclean = 1 - (((R * R * (4 - pi) * ((2 * (Lshort - R) + 2) / R) / (16 * Lshort * Llong))));
        double bnf_Cclean = 1 - ((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / (16 * Lshort * Llong));

        double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
        double bnf_Tshort = ((Lshort - R) / Vd);
        double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);

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
    }
}
