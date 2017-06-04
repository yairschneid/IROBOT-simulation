namespace irobot_simulation
{
    partial class simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simulation));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnf_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulationVariables_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cov_dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.raA = new System.Windows.Forms.TextBox();
            this.raB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.desc_dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.room_shape = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.min_LlongTB = new System.Windows.Forms.TextBox();
            this.min_VrTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.min_LshortTB = new System.Windows.Forms.TextBox();
            this.min_VdTB = new System.Windows.Forms.TextBox();
            this.min_RTB = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.max_RTB = new System.Windows.Forms.TextBox();
            this.max_VdTB = new System.Windows.Forms.TextBox();
            this.max_LshortTB = new System.Windows.Forms.TextBox();
            this.max_VrTB = new System.Windows.Forms.TextBox();
            this.max_LlongTB = new System.Windows.Forms.TextBox();
            this.manVariables = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVariables_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cov_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desc_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vd (0.28 -0.50)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1050, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lshort (5 - 50m)";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.set,
            this.bnf_col,
            this.bs_col,
            this.cp_col});
            this.dgv.Location = new System.Drawing.Point(96, 351);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(444, 300);
            this.dgv.TabIndex = 26;
            // 
            // set
            // 
            this.set.HeaderText = "set";
            this.set.Name = "set";
            // 
            // bnf_col
            // 
            this.bnf_col.HeaderText = "Back-and-forth";
            this.bnf_col.Name = "bnf_col";
            // 
            // bs_col
            // 
            this.bs_col.HeaderText = "Boundary sweep";
            this.bs_col.Name = "bs_col";
            // 
            // cp_col
            // 
            this.cp_col.HeaderText = "Our New Method";
            this.cp_col.Name = "cp_col";
            // 
            // SimulationVariables_dgv
            // 
            this.SimulationVariables_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationVariables_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.bs,
            this.ccp,
            this.vdf,
            this.Rd});
            this.SimulationVariables_dgv.Location = new System.Drawing.Point(43, 693);
            this.SimulationVariables_dgv.Name = "SimulationVariables_dgv";
            this.SimulationVariables_dgv.Size = new System.Drawing.Size(646, 236);
            this.SimulationVariables_dgv.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lshort";
            this.Column2.Name = "Column2";
            // 
            // bs
            // 
            this.bs.HeaderText = "Llong";
            this.bs.Name = "bs";
            // 
            // ccp
            // 
            this.ccp.HeaderText = "Vr";
            this.ccp.Name = "ccp";
            // 
            // vdf
            // 
            this.vdf.HeaderText = "Vd";
            this.vdf.Name = "vdf";
            // 
            // Rd
            // 
            this.Rd.HeaderText = "R";
            this.Rd.Name = "Rd";
            // 
            // cov_dgv
            // 
            this.cov_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cov_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cov_dgv.Location = new System.Drawing.Point(710, 351);
            this.cov_dgv.Name = "cov_dgv";
            this.cov_dgv.Size = new System.Drawing.Size(444, 300);
            this.cov_dgv.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "set";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Back-and-forth(%)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Boundary sweep(%)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Our New method(%)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(162, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Random Back and forth";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(162, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Random Boundary sweep";
            // 
            // raA
            // 
            this.raA.Location = new System.Drawing.Point(396, 183);
            this.raA.Name = "raA";
            this.raA.Size = new System.Drawing.Size(100, 20);
            this.raA.TabIndex = 31;
            // 
            // raB
            // 
            this.raB.Location = new System.Drawing.Point(396, 216);
            this.raB.Name = "raB";
            this.raB.Size = new System.Drawing.Size(100, 20);
            this.raB.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label20.Location = new System.Drawing.Point(465, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(285, 42);
            this.label20.TabIndex = 33;
            this.label20.Text = "IRobot Cleaning";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Check to simulate a round room";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.ForeColor = System.Drawing.Color.DarkGreen;
            this.label21.Location = new System.Drawing.Point(133, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(345, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "results of the vacuum cleaning robot’s efficiency";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label22.ForeColor = System.Drawing.Color.DarkGreen;
            this.label22.Location = new System.Drawing.Point(711, 328);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(443, 20);
            this.label22.TabIndex = 36;
            this.label22.Text = "results of the vacuum cleaning robot’s cleaning area coverage";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label23.ForeColor = System.Drawing.Color.Maroon;
            this.label23.Location = new System.Drawing.Point(233, 660);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 20);
            this.label23.TabIndex = 37;
            this.label23.Text = "Simulation variables";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(802, 660);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(155, 20);
            this.label24.TabIndex = 38;
            this.label24.Text = "Description variables";
            // 
            // desc_dgv
            // 
            this.desc_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desc_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.desc_dgv.Location = new System.Drawing.Point(806, 694);
            this.desc_dgv.Name = "desc_dgv";
            this.desc_dgv.Size = new System.Drawing.Size(417, 236);
            this.desc_dgv.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Parameter";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Value Range";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 170;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label25.Location = new System.Drawing.Point(233, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 20);
            this.label25.TabIndex = 40;
            this.label25.Text = "Room Shape:";
            // 
            // room_shape
            // 
            this.room_shape.AutoSize = true;
            this.room_shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.room_shape.ForeColor = System.Drawing.Color.Red;
            this.room_shape.Location = new System.Drawing.Point(354, 135);
            this.room_shape.Name = "room_shape";
            this.room_shape.Size = new System.Drawing.Size(0, 20);
            this.room_shape.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Llong (10 - 150m)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(661, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Vr ( 75 - 135)";
            // 
            // min_LlongTB
            // 
            this.min_LlongTB.Enabled = false;
            this.min_LlongTB.Location = new System.Drawing.Point(765, 188);
            this.min_LlongTB.Name = "min_LlongTB";
            this.min_LlongTB.Size = new System.Drawing.Size(100, 20);
            this.min_LlongTB.TabIndex = 44;
            // 
            // min_VrTB
            // 
            this.min_VrTB.Enabled = false;
            this.min_VrTB.Location = new System.Drawing.Point(765, 224);
            this.min_VrTB.Name = "min_VrTB";
            this.min_VrTB.Size = new System.Drawing.Size(100, 20);
            this.min_VrTB.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(661, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "R (0.40 - 0.50)";
            // 
            // min_LshortTB
            // 
            this.min_LshortTB.Enabled = false;
            this.min_LshortTB.Location = new System.Drawing.Point(765, 147);
            this.min_LshortTB.Name = "min_LshortTB";
            this.min_LshortTB.Size = new System.Drawing.Size(100, 20);
            this.min_LshortTB.TabIndex = 47;
            // 
            // min_VdTB
            // 
            this.min_VdTB.Enabled = false;
            this.min_VdTB.Location = new System.Drawing.Point(765, 257);
            this.min_VdTB.Name = "min_VdTB";
            this.min_VdTB.Size = new System.Drawing.Size(100, 20);
            this.min_VdTB.TabIndex = 48;
            // 
            // min_RTB
            // 
            this.min_RTB.Enabled = false;
            this.min_RTB.Location = new System.Drawing.Point(765, 285);
            this.min_RTB.Name = "min_RTB";
            this.min_RTB.Size = new System.Drawing.Size(100, 20);
            this.min_RTB.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(792, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "MIN";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(933, 112);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 52;
            this.label27.Text = "MAX";
            // 
            // max_RTB
            // 
            this.max_RTB.Enabled = false;
            this.max_RTB.Location = new System.Drawing.Point(910, 285);
            this.max_RTB.Name = "max_RTB";
            this.max_RTB.Size = new System.Drawing.Size(100, 20);
            this.max_RTB.TabIndex = 57;
            // 
            // max_VdTB
            // 
            this.max_VdTB.Enabled = false;
            this.max_VdTB.Location = new System.Drawing.Point(910, 257);
            this.max_VdTB.Name = "max_VdTB";
            this.max_VdTB.Size = new System.Drawing.Size(100, 20);
            this.max_VdTB.TabIndex = 56;
            // 
            // max_LshortTB
            // 
            this.max_LshortTB.Enabled = false;
            this.max_LshortTB.Location = new System.Drawing.Point(910, 147);
            this.max_LshortTB.Name = "max_LshortTB";
            this.max_LshortTB.Size = new System.Drawing.Size(100, 20);
            this.max_LshortTB.TabIndex = 55;
            // 
            // max_VrTB
            // 
            this.max_VrTB.Enabled = false;
            this.max_VrTB.Location = new System.Drawing.Point(910, 224);
            this.max_VrTB.Name = "max_VrTB";
            this.max_VrTB.Size = new System.Drawing.Size(100, 20);
            this.max_VrTB.TabIndex = 54;
            // 
            // max_LlongTB
            // 
            this.max_LlongTB.Enabled = false;
            this.max_LlongTB.Location = new System.Drawing.Point(910, 188);
            this.max_LlongTB.Name = "max_LlongTB";
            this.max_LlongTB.Size = new System.Drawing.Size(100, 20);
            this.max_LlongTB.TabIndex = 53;
            // 
            // manVariables
            // 
            this.manVariables.AutoSize = true;
            this.manVariables.Location = new System.Drawing.Point(799, 84);
            this.manVariables.Name = "manVariables";
            this.manVariables.Size = new System.Drawing.Size(186, 17);
            this.manVariables.TabIndex = 58;
            this.manVariables.Text = "Check to insert manually variables";
            this.manVariables.UseVisualStyleBackColor = true;
            this.manVariables.CheckedChanged += new System.EventHandler(this.manVariables_CheckedChanged);
            // 
            // simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1288, 805);
            this.Controls.Add(this.manVariables);
            this.Controls.Add(this.max_RTB);
            this.Controls.Add(this.max_VdTB);
            this.Controls.Add(this.max_LshortTB);
            this.Controls.Add(this.max_VrTB);
            this.Controls.Add(this.max_LlongTB);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.min_RTB);
            this.Controls.Add(this.min_VdTB);
            this.Controls.Add(this.min_LshortTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.min_VrTB);
            this.Controls.Add(this.min_LlongTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_shape);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.desc_dgv);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.raB);
            this.Controls.Add(this.raA);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cov_dgv);
            this.Controls.Add(this.SimulationVariables_dgv);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "simulation";
            this.Text = "simulation";
            this.Load += new System.EventHandler(this.simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVariables_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cov_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desc_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView SimulationVariables_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccp;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rd;
        private System.Windows.Forms.DataGridView cov_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn set;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnf_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn bs_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp_col;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox raA;
        private System.Windows.Forms.TextBox raB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView desc_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label room_shape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox min_LlongTB;
        private System.Windows.Forms.TextBox min_VrTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox min_LshortTB;
        private System.Windows.Forms.TextBox min_VdTB;
        private System.Windows.Forms.TextBox min_RTB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox max_RTB;
        private System.Windows.Forms.TextBox max_VdTB;
        private System.Windows.Forms.TextBox max_LshortTB;
        private System.Windows.Forms.TextBox max_VrTB;
        private System.Windows.Forms.TextBox max_LlongTB;
        private System.Windows.Forms.CheckBox manVariables;
    }
}

