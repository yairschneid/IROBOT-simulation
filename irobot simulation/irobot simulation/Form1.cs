﻿using System;
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
        double Vd = 0.0, Vr = 0, R = 0, pi = 3.14, Radius=0;
        int selectRand = 0;

        double TotalTime_CCPP_Set = 0.0, TotalTime_backNforth_Set = 0.0,TotalTime_boundarySweep_Set= 0.0; 
        double TotalCoverage_CCPP_Set = 0.0, TotalCoverage_backNforth_Set= 0.0, TotalCoverage_boundarySweep_Set= 0.0;
        double Average_backNforth, Average_boundarySweep, Average_newMethod;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        //temp local variables
        double temp_CCPP_TotalTime = 0.0, temp_CCPP_Coverage = 0.0;
        double temp_backNforth_Coverage = 0.0, temp_backNforth_TotalTime = 0.0;
        double  temp_boundarySweep_Coverage = 0.0, temp_boundarySweep_TotalTime = 0.0;


        public simulation()
        {
            InitializeComponent();

          
        }

      
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // Room is Round
            {
                dgv.Rows.Clear();
                testdgv.Rows.Clear();
                dgv.Refresh();
                testdgv.Rows.Clear();

                // intialize the variables
                TotalTime_CCPP_Set = 0.0;
                TotalTime_backNforth_Set = 0.0;
                TotalTime_boundarySweep_Set = 0.0;
                TotalCoverage_CCPP_Set = 0.0;
                TotalCoverage_backNforth_Set = 0.0;
                TotalCoverage_boundarySweep_Set = 0.0;
                Average_backNforth = 0.0;
                Average_boundarySweep = 0.0;
                Average_newMethod = 0.0;

                // rand number to choose quantity of each method 
                var rnd = new Random(Guid.NewGuid().GetHashCode());
                selectRand = rnd.Next(0, 11);
                raA.Text = selectRand.ToString();
                raB.Text = (10 - selectRand).ToString();

                for (int j = 0; j < 10; j++)
                {
                    //intialize the variables each set
                    TotalTime_CCPP_Set = 0.0;
                    TotalTime_backNforth_Set = 0.0;
                    TotalTime_boundarySweep_Set = 0.0;
                    TotalCoverage_CCPP_Set = 0.0;
                    TotalCoverage_backNforth_Set = 0.0;
                    TotalCoverage_boundarySweep_Set = 0.0;


                    for (int i = 0; i < 1000; i++)
                    {
                        // randome numbers aaa
                        rnd = new Random(Guid.NewGuid().GetHashCode());
                        Lshort = rnd.Next(5, 51);
                        Llong = rnd.Next(10, 151);
                        Radius = Llong * pi;
                        Vd = rnd.NextDouble() * (0.50 - 0.28) + 0.28;
                        Vr = rnd.Next(75, 136);
                        R = rnd.NextDouble() * (0.50 - 0.40) + 0.40;

                        testdgv.Columns[1].HeaderText = "Radius";
                        testdgv.Rows.Add(i, Radius, Llong, Vr, Vd, R);

                        // call to functions to calculate
                        //CCPP_Func(Lshort, Llong, Vd, Vr, R, pi);
                        backNforthRoundRoom_Func(Radius, Llong, Vd, Vr, R, pi, j);
                        boundarySweepRoundRoom_Func(Radius, Llong, Vd, Vr, R, pi, j);

                        dgv2.Rows.Add(i, Math.Round(temp_backNforth_TotalTime, 1), Math.Round(temp_boundarySweep_TotalTime, 1), Math.Round(temp_CCPP_TotalTime, 1));
                    }

                    if (j <= selectRand)
                    {
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_CCPP_Set / 1000) / 3, 1));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_backNforth_Set / 1000) / 3);
                    }
                    else
                    {
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_CCPP_Set / 1000) / 5, 1));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_boundarySweep_Set / 1000) / 5);
                    }
                }

                dgv.Rows.Add("Average", Math.Round((Average_backNforth / 10), 1), Math.Round((Average_boundarySweep / 10), 1), Math.Round((Average_newMethod / 10), 1));
            }
            else
            {
                dgv.Rows.Clear();
                testdgv.Rows.Clear();
                dgv.Refresh();
                testdgv.Rows.Clear();


                // intialize the variables
                TotalTime_CCPP_Set = 0.0;
                TotalTime_backNforth_Set = 0.0;
                TotalTime_boundarySweep_Set = 0.0;
                TotalCoverage_CCPP_Set = 0.0;
                TotalCoverage_backNforth_Set = 0.0;
                TotalCoverage_boundarySweep_Set = 0.0;
                Average_backNforth = 0.0;
                Average_boundarySweep = 0.0;
                Average_newMethod = 0.0;

                // rand number to choose quantity of each method 
                var rnd = new Random(Guid.NewGuid().GetHashCode());
                selectRand = rnd.Next(0, 11);
                raA.Text = selectRand.ToString();
                raB.Text = (10 - selectRand).ToString();

                for (int j = 0; j < 10; j++)
                {
                    //intialize the variables each set
                    TotalTime_CCPP_Set = 0.0;
                    TotalTime_backNforth_Set = 0.0;
                    TotalTime_boundarySweep_Set = 0.0;
                    TotalCoverage_CCPP_Set = 0.0;
                    TotalCoverage_backNforth_Set = 0.0;
                    TotalCoverage_boundarySweep_Set = 0.0;


                    for (int i = 0; i < 1000; i++)
                    {
                        // randome numbers aaa
                        rnd = new Random(Guid.NewGuid().GetHashCode());
                        Lshort = rnd.Next(5, 51);
                        Llong = rnd.Next(10, 151);
                        Vd = rnd.NextDouble() * (0.50 - 0.28) + 0.28;
                        Vr = rnd.Next(75, 136);
                        R = rnd.NextDouble() * (0.50 - 0.40) + 0.40;

                        testdgv.Rows.Add(i, Lshort, Llong, Vr, Vd, R);

                        // call to functions to calculate
                        //CCPP_Func(Lshort, Llong, Vd, Vr, R, pi);
                        backNforth_Func(Lshort, Llong, Vd, Vr, R, pi, j);
                        boundarySweep_Func(Lshort, Llong, Vd, Vr, R, pi, j);

                        dgv2.Rows.Add(i, Math.Round(temp_backNforth_TotalTime, 1), Math.Round(temp_boundarySweep_TotalTime, 1), Math.Round(temp_CCPP_TotalTime, 1));


                    }



                    if (j <= selectRand)
                    {
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_CCPP_Set / 1000) / 3, 1));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_backNforth_Set / 1000) / 3);

                    }
                    else
                    {
                        dgv.Rows.Add(j + 1, Math.Round((TotalTime_backNforth_Set / 1000) / 3, 1), Math.Round((TotalTime_boundarySweep_Set / 1000) / 5, 1), Math.Round((TotalTime_CCPP_Set / 1000) / 5, 1));
                        Average_backNforth += ((TotalTime_backNforth_Set / 1000) / 3);
                        Average_boundarySweep += ((TotalTime_boundarySweep_Set / 1000) / 5);
                        Average_newMethod += ((TotalTime_boundarySweep_Set / 1000) / 5);
                    }
                }

                dgv.Rows.Add("Average", Math.Round((Average_backNforth / 10), 1), Math.Round((Average_boundarySweep / 10), 1), Math.Round((Average_newMethod / 10), 1));

            }





        }

        private void boundarySweepRoundRoom_Func(double radius, int llong, double vd, double vr, double r, double pi, int typeMethod)
        {           
            throw new NotImplementedException();
        }

        private void backNforthRoundRoom_Func(double radius, int llong, double vd, double vr, double r, double pi, int typeMethod)
        {
            temp_backNforth_Coverage = 1 - ((2 * R * R * (4 - pi) * ((int)(radius / R) + 1)) / (16 * Math.Pow(pi * radius, 2)));
            double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
            double bnf_Tshort = ((Lshort - R) / Vd);
            double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);
            temp_backNforth_TotalTime = bnf_Tlong + bnf_Tshort + bnf_Trotation;

            TotalTime_backNforth_Set += temp_backNforth_TotalTime;
            TotalCoverage_backNforth_Set += temp_backNforth_Coverage;

            if (typeMethod <= selectRand)
            {
                TotalTime_CCPP_Set += temp_backNforth_TotalTime;
                TotalCoverage_CCPP_Set += temp_backNforth_Coverage;
            }
        }

        private void CCPP_Func(int Lshort,int Llong,double Vd,double Vr,double R,double pi,int typeMethod)
        {           
            temp_CCPP_Coverage = 1 - (((2 * R * R * (4 - pi) * ((int)(Lshort / R))) / (16 * Lshort * Llong)));
            double new_CTlong = (((((Lshort - R) / R) * (Llong - 2 * R)) + R) / Vd);
            double new_CTshort = 2 * ((Lshort - R) / Vd);
            double new_CTrotation = 90 * 2 * ((((Lshort - R) / R) - 1) / Vr);
            temp_CCPP_TotalTime = new_CTlong + new_CTshort + new_CTrotation;


            TotalCoverage_CCPP_Set += temp_CCPP_Coverage;
            TotalTime_CCPP_Set += temp_CCPP_TotalTime;
        }

        private void backNforth_Func(int Lshort, int Llong, double Vd, double Vr, double R, double pi,int typeMethod)
        {
            temp_backNforth_Coverage = 1 - ((2 * R * R * (4 - pi) * ((int)(Lshort / R) + 1)) / (16 * Lshort * Llong));
            double bnf_Tlong = (((Llong - R) * (Lshort / R)) / Vd);
            double bnf_Tshort = ((Lshort - R) / Vd);
            double bnf_Trotation = 90 * 2 * ((Lshort / R) / Vr);
            temp_backNforth_TotalTime = bnf_Tlong + bnf_Tshort + bnf_Trotation;
          
            TotalTime_backNforth_Set += temp_backNforth_TotalTime;
            TotalCoverage_backNforth_Set += temp_backNforth_Coverage;

            if(typeMethod<=selectRand)
            {
                TotalTime_CCPP_Set += temp_backNforth_TotalTime;
                TotalCoverage_CCPP_Set += temp_backNforth_Coverage;
            }
        }

        private void boundarySweep_Func(int Lshort, int Llong, double Vd, double Vr, double R, double pi,int typeMethod)
        {

            temp_boundarySweep_Coverage = 1 - (((R * R * (4 - pi) * ((2 * (Lshort - R) + 2) / R) / (16 * Lshort * Llong))));

            double alpha = (int)((Lshort - R) / R);
            double boundry_Tlong = alpha * ((2 * (Llong - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Tshort = alpha * ((2 * (Lshort - R * alpha) + R * (alpha - 1)) / Vd);
            double boundry_Trotation = ((90 * 2 * alpha) / Vr);
            double boundry_Treturn = Math.Sqrt(((Math.Pow(((Llong - R) / (2)), 2) + (Math.Pow((Lshort - R) / 2, 2)) / Vd)));

            temp_boundarySweep_TotalTime = boundry_Trotation + boundry_Tshort + boundry_Tlong;
     
            TotalCoverage_boundarySweep_Set += temp_boundarySweep_Coverage;
            TotalTime_boundarySweep_Set += temp_boundarySweep_TotalTime;
           
            if (typeMethod > selectRand)
            {
                TotalTime_CCPP_Set += temp_boundarySweep_TotalTime;
                TotalCoverage_CCPP_Set += temp_boundarySweep_Coverage;
            }
        }
    }
}
