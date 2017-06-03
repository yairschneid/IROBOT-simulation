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

        

        // simulation variables 
        int Lshort = 0, Llong = 0;
        double Vd = 0.0, Vr = 0, R = 0, pi = 3.14, Radius=0, cov_boundary = 5750, cov_back = 1150;
        int selectRand = 0;
      
        // total time & coverage variables
        double TotalTime_NewMethod_Set = 0.0, TotalTime_backNforth_Set = 0.0,TotalTime_boundarySweep_Set= 0.0; 
        double TotalCoverage_NewMethod_Set = 0.0, TotalCoverage_backNforth_Set= 0.0, TotalCoverage_boundarySweep_Set= 0.0;




        // average variables
        double Average_backNforth = 0.0;
        double Average_boundarySweep = 0.0;
        double Average_newMethod = 0.0;

        double Average_covbackNforth, Average_covboundarySweep, Average_covnewMethod;
      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                manVariables.Enabled = false;
                min_LshortTB.Enabled = false;
                max_LshortTB.Enabled = false;
                min_LlongTB.Enabled = false;
                max_LlongTB.Enabled = false;
                min_VrTB.Enabled = false;
                max_VrTB.Enabled = false;
                min_VdTB.Enabled = false;
                max_VdTB.Enabled = false;
                min_RTB.Enabled = false;
                max_RTB.Enabled = false;
            }
            else
            {
                manVariables.Enabled = true;
            }
            
        }

        private double iteration;
        private int subintervals;
        private double sumReimanIteration;

        private void simulation_Load(object sender, EventArgs e)
        {
        }

        private void manVariables_CheckedChanged(object sender, EventArgs e)
        {

            if (manVariables.Checked)
            {
                min_LshortTB.Enabled = true;
                max_LshortTB.Enabled = true;
                min_LlongTB.Enabled = true;
                max_LlongTB.Enabled = true;
                min_VrTB.Enabled = true;
                max_VrTB.Enabled = true;
                min_VdTB.Enabled = true;
                max_VdTB.Enabled = true;
                min_RTB.Enabled = true;
                max_RTB.Enabled = true;
            }
            else
            {
                min_LshortTB.Enabled = false;
                max_LshortTB.Enabled = false;
                min_LlongTB.Enabled = false;
                max_LlongTB.Enabled = false;
                min_VrTB.Enabled = false;
                max_VrTB.Enabled = false;
                min_VdTB.Enabled = false;
                max_VdTB.Enabled = false;
                min_RTB.Enabled = false;
                max_RTB.Enabled = false;

            }
            
        
        }

     
        public simulation()
        {
            InitializeComponent();
            





        }



        private void button1_Click(object sender, EventArgs e)
        {
            ResetSimulation();
            if (checkBox1.Checked) // Round room shape
            {
                room_shape.Text = " Round ";
                ResetSimulation();  
                // rand number to choose quantity of each method 
                var rnd = new Random(Guid.NewGuid().GetHashCode());
                selectRand = rnd.Next(0, 11);
                raA.Text = selectRand.ToString();
                raB.Text = (10 - selectRand).ToString();

                Average_covbackNforth = 0.0;
                Average_covboundarySweep = 0.0;
                Average_covnewMethod = 0.0;
                Average_backNforth = 0.0;
                Average_boundarySweep = 0.0;
                Average_newMethod = 0.0;

                desc_dgv.Rows.Add("Radius", "5 - 20(m)", "A radius of a circle room");
                desc_dgv.Rows.Add("Vd", "0.28 - 0.50(m/s)", "Direct movement speed of a robot");
                desc_dgv.Rows.Add("Vr", "75 - 135(*/s)", "Rotation speed of the robot");
                desc_dgv.Rows.Add("R", "0.40 - 0.50(m)", "a diameter of the robot");

                for (int j = 0; j < 10; j++)
                {
                    // intialize the variables each set
                    TotalTime_NewMethod_Set = 0.0;
                    TotalTime_backNforth_Set = 0.0;
                    TotalTime_boundarySweep_Set = 0.0;
                    TotalCoverage_NewMethod_Set = 0.0;
                    TotalCoverage_backNforth_Set = 0.0;
                    TotalCoverage_boundarySweep_Set = 0.0;
                 
                  
           

                    for (int i = 0; i < 1000; i++)
                    {
                        // randome numbers 
                        rnd = new Random(Guid.NewGuid().GetHashCode());
                        R = rnd.NextDouble() * (0.50 - 0.40) + 0.40;
                        Radius = rnd.NextDouble() * (20 - 5) + 5;
                       
                       // Lshort = rnd.Next(5, 51);
                        Llong = rnd.Next(10, 151);
                       // Radius = Llong * pi;
                        Vd = rnd.NextDouble() * (0.50 - 0.28) + 0.28;
                        Vr = rnd.Next(75, 136);

                        SimulationVariables_dgv.Columns[1].HeaderText = "Radius";
                        SimulationVariables_dgv.Columns[2].Visible = false;
                        
                        SimulationVariables_dgv.Rows.Add(i, Radius,Llong, Vr, Vd, R);

                        // call to functions to calculate
                        backNforthRoundRoom_Func(Radius, Vd, Vr, R, pi, j);
                        boundarySweepRoundRoom_Func(Radius, Llong, Vd, Vr, R, pi, j);

                    }

                    if (j < selectRand)  // back and forth
                    {
                        cov_dgv.Rows.Add(j + 1, Math.Round((TotalCoverage_backNforth_Set/ cov_back), 3), Math.Round((TotalCoverage_boundarySweep_Set / cov_boundary), 3), Math.Round((TotalCoverage_NewMethod_Set/ cov_back), 3));
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000), 1), Math.Round((TotalTime_boundarySweep_Set / 1000), 1), Math.Round((TotalTime_NewMethod_Set / 1000), 1));
                        Average_backNforth += (TotalTime_backNforth_Set / 1000);
                        Average_boundarySweep += (TotalTime_boundarySweep_Set / 1000);
                        Average_newMethod += (TotalTime_backNforth_Set / 1000) ;
                        Average_covbackNforth += (TotalCoverage_backNforth_Set / cov_back);
                        Average_covboundarySweep += (TotalCoverage_boundarySweep_Set / cov_boundary);
                        Average_covnewMethod += (TotalCoverage_NewMethod_Set / cov_back);
                    }
                    else  // boundary sweep
                    {
                        cov_dgv.Rows.Add(j + 1, Math.Round((TotalCoverage_backNforth_Set / cov_back), 3), Math.Round((TotalCoverage_boundarySweep_Set/cov_boundary), 3), Math.Round((TotalCoverage_NewMethod_Set/ cov_boundary), 3));
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000), 1), Math.Round((TotalTime_boundarySweep_Set / 1000), 1), Math.Round((TotalTime_NewMethod_Set / 1000), 1));
                        Average_backNforth += (TotalTime_backNforth_Set / 1000);
                        Average_boundarySweep += (TotalTime_boundarySweep_Set / 1000) ;
                        Average_newMethod += (TotalTime_boundarySweep_Set / 1000);
                        Average_covbackNforth += (TotalCoverage_backNforth_Set / cov_back);
                        Average_covboundarySweep += (TotalCoverage_boundarySweep_Set / cov_boundary);
                        Average_covnewMethod += (TotalCoverage_NewMethod_Set / cov_boundary);
                    }
                }

                dgv.Rows.Add("Average", Math.Round((Average_backNforth / 10), 1), Math.Round((Average_boundarySweep / 10), 1), Math.Round((Average_newMethod/10 ), 1));
                cov_dgv.Rows.Add("Average", Math.Round((Average_covbackNforth/10 ), 3), Math.Round((Average_covboundarySweep/10), 3), Math.Round((Average_covnewMethod /10), 3));

            }




            else  // rectangle room shape
            {

                room_shape.Text = " Rectangle ";
                ResetSimulation();

                // intialize the variables each set
                TotalTime_NewMethod_Set = 0.0;
                TotalTime_backNforth_Set = 0.0;
                TotalTime_boundarySweep_Set = 0.0;
                TotalCoverage_NewMethod_Set = 0.0;
                TotalCoverage_backNforth_Set = 0.0;
                TotalCoverage_boundarySweep_Set = 0.0;
                Average_backNforth = 0.0;
                Average_boundarySweep = 0.0;
                Average_newMethod = 0.0;
                Average_covbackNforth = 0.0;
                Average_covboundarySweep = 0.0;
                Average_covnewMethod = 0.0;

                desc_dgv.Rows.Add("Llong", "10 - 150(m)", "A length of long side of a room");
                desc_dgv.Rows.Add("Lshort", "5 - 50(m)", "A length of short side of the room");
                desc_dgv.Rows.Add("Vd", "0.28 - 0.50(m/s)", "Direct movement speed of a robot");
                desc_dgv.Rows.Add("Vr", "75 - 135(*/s)", "Rotation speed of the robot");
                desc_dgv.Rows.Add("R", "0.40 - 0.50(m)", "a diameter of the robot");

                // rand number to choose quantity of each method 
                var rnd = new Random(Guid.NewGuid().GetHashCode());
                selectRand = rnd.Next(0, 11);
                raA.Text = selectRand.ToString();  // back and forth
                raB.Text = (10 - selectRand).ToString();  // boundary sweep

               




                for (int j = 0; j < 10; j++)
                {
                    //intialize the variables each set
                    TotalTime_NewMethod_Set = 0.0;
                    TotalTime_backNforth_Set = 0.0;
                    TotalTime_boundarySweep_Set = 0.0;
                    TotalCoverage_NewMethod_Set = 0.0;
                    TotalCoverage_backNforth_Set = 0.0;
                    TotalCoverage_boundarySweep_Set = 0.0;


                    for (int i = 0; i < 1000; i++)
                    {
                        if (manVariables.Checked)
                        {
                            int min_lshortTB = Convert.ToInt32(min_LshortTB.Text);
                            int max_lshortTB = Convert.ToInt32(max_LshortTB.Text);
                            int min_longTB = Convert.ToInt32(min_LlongTB.Text);
                            int max_longTB = Convert.ToInt32(max_LlongTB.Text);
                            int min_vrTB = Convert.ToInt32(min_VrTB.Text);
                            int max_vrTB = Convert.ToInt32(max_VrTB.Text);
                            double min_vdTB = Convert.ToDouble(min_VdTB.Text);
                            double max_vdTB = Convert.ToDouble(max_VdTB.Text);
                            double min_rTB = Convert.ToDouble(min_RTB.Text);
                            double max_rTB = Convert.ToDouble(max_RTB.Text);




                            rnd = new Random(Guid.NewGuid().GetHashCode());
                            Lshort = rnd.Next(min_lshortTB, max_lshortTB);
                            Llong = rnd.Next(min_longTB, max_longTB);
                            Vd = rnd.NextDouble() * (max_vdTB - min_vdTB) + min_vdTB;
                            Vr = rnd.Next(min_vrTB, max_vrTB);
                            R = rnd.NextDouble() * (max_rTB - min_rTB) + min_rTB;

                            backNforth_Func(Lshort, Llong, Vd, Vr, R, pi, j);
                            boundarySweep_Func(Lshort, Llong, Vd, Vr, R, pi, j);

                        }
                        // random numbers 
                        else
                        {
                            rnd = new Random(Guid.NewGuid().GetHashCode());
                            Lshort = rnd.Next(5, 51);
                            Llong = rnd.Next(10, 151);
                            Vd = rnd.NextDouble() * (0.50 - 0.28) + 0.28;
                            Vr = rnd.Next(75, 136);
                            R = rnd.NextDouble() * (0.50 - 0.40) + 0.40;
                            SimulationVariables_dgv.Rows.Add(i, Lshort, Llong, Vr, Vd, R);
                            backNforth_Func(Lshort, Llong, Vd, Vr, R, pi, j);
                            boundarySweep_Func(Lshort, Llong, Vd, Vr, R, pi, j);
                        }
                        SimulationVariables_dgv.Rows.Add(i, Lshort, Llong, Vr, Vd, R);


                    }



                    if (j < selectRand)
                    {

                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_NewMethod_Set / 1000) / 3, 1));
                        cov_dgv.Rows.Add(j + 1, Math.Round((TotalCoverage_backNforth_Set/10),3), Math.Round((TotalCoverage_boundarySweep_Set /10) , 3), Math.Round((TotalCoverage_NewMethod_Set / 10), 3));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_covbackNforth += (TotalCoverage_backNforth_Set / 10);
                        Average_covboundarySweep += (TotalCoverage_boundarySweep_Set / 10);
                        Average_covnewMethod += (TotalCoverage_NewMethod_Set / 10);

                    }
                    else
                    {
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_NewMethod_Set / 1000) / 5, 1));
                        cov_dgv.Rows.Add(j + 1, Math.Round((TotalCoverage_backNforth_Set/10), 3), Math.Round((TotalCoverage_boundarySweep_Set/10 ),3), Math.Round((TotalCoverage_NewMethod_Set / 10), 3));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_covbackNforth += (TotalCoverage_backNforth_Set/10);
                        Average_covboundarySweep += (TotalCoverage_boundarySweep_Set / 10);
                        Average_covnewMethod += (TotalCoverage_NewMethod_Set / 10);

                    }
                }

                dgv.Rows.Add("Average", Math.Round((Average_backNforth / 10), 1), Math.Round((Average_boundarySweep / 10), 1), Math.Round((Average_newMethod / 10), 1));
                cov_dgv.Rows.Add("Average", Math.Round((Average_covbackNforth / 10), 3), Math.Round((Average_covboundarySweep / 10), 3), Math.Round((Average_covnewMethod / 10), 3));

            }





        }


        // ************************************************** Round Room shape **************************************************/



        private void backNforthRoundRoom_Func(double radius, double vd, double vr, double r, double pi, int typeMethod)
        {
            iteration = radius / R;   // circle radius divide by the radius of machine
            subintervals = (int)(radius / iteration)+2 ; // num of intervales

            sumReimanIteration = 0;
            double sumTimeIteration = 0;
            double deltaX=0.0, a=0.0, b=0.0;
            for (int k = 1; k <= subintervals; k++)  // calculate by reimann formula  
            {
                 b = k * iteration;
                 a = (k - 1) * iteration;
                deltaX = (b - a) / subintervals;
                sumTimeIteration += (deltaX * vd);
                sumReimanIteration = sumReimanIteration + deltaX;  // add the delta sum to total sumIteration

            }

            double temp_backNforth_Coverage = sumReimanIteration * 4;
            double bnf_Trotation = 90 * 2 * ((Radius / R) / Vr);
            double temp_backNforth_TotalTime = (sumTimeIteration*4)/vd + bnf_Trotation;

            TotalTime_backNforth_Set += temp_backNforth_TotalTime;
            TotalCoverage_backNforth_Set += temp_backNforth_Coverage;

            // total time & coverage  -> new method

            if (typeMethod < selectRand)
            {

                TotalTime_NewMethod_Set += temp_backNforth_TotalTime;
                TotalCoverage_NewMethod_Set += temp_backNforth_Coverage;
            }


        }



        private void boundarySweepRoundRoom_Func(double radius, int llong, double vd, double vr, double r, double pi, int typeMethod)
        {
            double area = radius * radius * pi;  // area of circle

            double temp_boundarySweep_Coverage = area;

            double alpha = (int)((Lshort - R) / R);
            double boundry_Trotation = ((90 * 2 * alpha) / Vr);

            double temp_boundarySweep_TotalTime = boundry_Trotation + temp_boundarySweep_Coverage * vd;

            // total time & coverage  -> back and forth
            TotalCoverage_boundarySweep_Set += temp_boundarySweep_Coverage;
            TotalTime_boundarySweep_Set += temp_boundarySweep_TotalTime;

            // total time & coverage  -> new method
            if (typeMethod >= selectRand)
            {
                TotalTime_NewMethod_Set += temp_boundarySweep_TotalTime;
                TotalCoverage_NewMethod_Set += temp_boundarySweep_Coverage;
            }

        }










        // ************************************************** Rectangle Room shape **************************************************/

        private void backNforth_Func(int Lshort, int Llong, double Vd, double Vr, double R, double pi,int typeMethod)
        {
            double temp_backNforth_Coverage = 1 - ((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / (16 * Lshort * Llong));
            double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
            double bnf_Tshort = ((Lshort - R) / Vd);
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            double rper = rnd.NextDouble() * (0.99 - 0.90) + 0.9;
            double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);
            double t = temp_backNforth_Coverage > 100 ? temp_backNforth_Coverage * rper : temp_backNforth_Coverage;
            temp_backNforth_Coverage = t;


            double temp_backNforth_TotalTime = bnf_Tlong + bnf_Tshort + bnf_Trotation;


            // total time & coverage  -> back and forth
            TotalTime_backNforth_Set += temp_backNforth_TotalTime;
            TotalCoverage_backNforth_Set += temp_backNforth_Coverage;

            // total time & coverage  -> new method

            if (typeMethod<selectRand)
            {

                TotalTime_NewMethod_Set += temp_backNforth_TotalTime;
                TotalCoverage_NewMethod_Set += temp_backNforth_Coverage;
            }

        }

        private void boundarySweep_Func(int Lshort, int Llong, double Vd, double Vr, double R, double pi,int typeMethod)
        {

            double temp_boundarySweep_Coverage = 1 - (((R * R * (4 - pi) * ((2 * (Lshort - R) + 2) / R) / (16 * Lshort * Llong))));

            double alpha = (int)((Lshort - R) / R);
            double boundry_Tlong = alpha * ((2 * (Llong - R * alpha) + R * (alpha - 1)) / Vd);
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            double rper = rnd.NextDouble() * (0.99 - 0.90) + 0.9;
            double boundry_Tshort = alpha * ((2 * (Lshort - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Trotation = ((90 * 2 * alpha) / Vr);
            double t = temp_boundarySweep_Coverage > 100 ? temp_boundarySweep_Coverage * rper : temp_boundarySweep_Coverage;
            temp_boundarySweep_Coverage = t;
            double boundry_Treturn = Math.Sqrt(((Math.Pow(((Llong - R) / (2)), 2) + (Math.Pow((Lshort - R) / 2, 2)) / Vd)));

            double temp_boundarySweep_TotalTime = boundry_Trotation + boundry_Tshort + boundry_Tlong;

            // total time & coverage  -> back and forth
            TotalCoverage_boundarySweep_Set += temp_boundarySweep_Coverage;
            TotalTime_boundarySweep_Set += temp_boundarySweep_TotalTime;


            // total time & coverage  -> new method
            if (typeMethod >= selectRand)
            {
                TotalTime_NewMethod_Set += temp_boundarySweep_TotalTime;
                TotalCoverage_NewMethod_Set += temp_boundarySweep_Coverage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetSimulation();

        }
        private void ResetSimulation()

        {
            dgv.Rows.Clear();
            desc_dgv.Rows.Clear();
            cov_dgv.Rows.Clear();
            SimulationVariables_dgv.Rows.Clear();
            dgv.Refresh();
            desc_dgv.Refresh();
            cov_dgv.Refresh();
            SimulationVariables_dgv.Refresh();
        }



    }

}
