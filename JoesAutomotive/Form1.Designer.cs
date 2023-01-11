namespace JoesAutomotive
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.partsTB = new System.Windows.Forms.TextBox();
            this.laborLB = new System.Windows.Forms.Label();
            this.partsLB = new System.Windows.Forms.Label();
            this.miscGB = new System.Windows.Forms.GroupBox();
            this.miscCBL = new System.Windows.Forms.CheckedListBox();
            this.flushisGB = new System.Windows.Forms.GroupBox();
            this.flushesCBL = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costsGB = new System.Windows.Forms.GroupBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.partsandlaborTB = new System.Windows.Forms.TextBox();
            this.serviceTB = new System.Windows.Forms.TextBox();
            this.totalLB = new System.Windows.Forms.Label();
            this.taxLB = new System.Windows.Forms.Label();
            this.serviceLB = new System.Windows.Forms.Label();
            this.laborTB = new System.Windows.Forms.TextBox();
            this.partsandlaborLB = new System.Windows.Forms.Label();
            this.oilandlubeCBL = new System.Windows.Forms.CheckedListBox();
            this.clearBUT = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.miscGB.SuspendLayout();
            this.flushisGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.costsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laborTB);
            this.groupBox2.Controls.Add(this.partsTB);
            this.groupBox2.Controls.Add(this.laborLB);
            this.groupBox2.Controls.Add(this.partsLB);
            this.groupBox2.Location = new System.Drawing.Point(193, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(175, 80);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // partsTB
            // 
            this.partsTB.Location = new System.Drawing.Point(59, 20);
            this.partsTB.Name = "partsTB";
            this.partsTB.Size = new System.Drawing.Size(100, 20);
            this.partsTB.TabIndex = 2;
            this.partsTB.TextChanged += new System.EventHandler(this.partsTB_TextChanged);
            // 
            // laborLB
            // 
            this.laborLB.AutoSize = true;
            this.laborLB.Location = new System.Drawing.Point(8, 49);
            this.laborLB.Name = "laborLB";
            this.laborLB.Size = new System.Drawing.Size(49, 13);
            this.laborLB.TabIndex = 1;
            this.laborLB.Text = "Labor (h)";
            // 
            // partsLB
            // 
            this.partsLB.AutoSize = true;
            this.partsLB.Location = new System.Drawing.Point(7, 23);
            this.partsLB.Name = "partsLB";
            this.partsLB.Size = new System.Drawing.Size(46, 13);
            this.partsLB.TabIndex = 0;
            this.partsLB.Text = "Parts ($)";
            // 
            // miscGB
            // 
            this.miscGB.Controls.Add(this.miscCBL);
            this.miscGB.Location = new System.Drawing.Point(12, 83);
            this.miscGB.Name = "miscGB";
            this.miscGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miscGB.Size = new System.Drawing.Size(175, 80);
            this.miscGB.TabIndex = 12;
            this.miscGB.TabStop = false;
            this.miscGB.Text = "Misc";
            // 
            // miscCBL
            // 
            this.miscCBL.CheckOnClick = true;
            this.miscCBL.FormattingEnabled = true;
            this.miscCBL.Items.AddRange(new object[] {
            "Inspection ($15.00)",
            "Replace Muffler ($100.00)",
            "Tire Rotation ($20.00)"});
            this.miscCBL.Location = new System.Drawing.Point(7, 20);
            this.miscCBL.Name = "miscCBL";
            this.miscCBL.Size = new System.Drawing.Size(162, 49);
            this.miscCBL.TabIndex = 0;
            this.miscCBL.SelectedIndexChanged += new System.EventHandler(this.miscCBL_SelectedIndexChanged);
            // 
            // flushisGB
            // 
            this.flushisGB.Controls.Add(this.flushesCBL);
            this.flushisGB.Location = new System.Drawing.Point(193, 12);
            this.flushisGB.Name = "flushisGB";
            this.flushisGB.Size = new System.Drawing.Size(175, 65);
            this.flushisGB.TabIndex = 11;
            this.flushisGB.TabStop = false;
            this.flushisGB.Text = "Flushes";
            // 
            // flushesCBL
            // 
            this.flushesCBL.CheckOnClick = true;
            this.flushesCBL.FormattingEnabled = true;
            this.flushesCBL.Items.AddRange(new object[] {
            "Radiator Flush ($30.00)",
            "Transmission Flush ($80.00)"});
            this.flushesCBL.Location = new System.Drawing.Point(6, 19);
            this.flushesCBL.Name = "flushesCBL";
            this.flushesCBL.Size = new System.Drawing.Size(161, 34);
            this.flushesCBL.TabIndex = 0;
            this.flushesCBL.SelectedIndexChanged += new System.EventHandler(this.flushesCBL_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oilandlubeCBL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // costsGB
            // 
            this.costsGB.Controls.Add(this.clearBUT);
            this.costsGB.Controls.Add(this.partsandlaborLB);
            this.costsGB.Controls.Add(this.totalTB);
            this.costsGB.Controls.Add(this.taxTB);
            this.costsGB.Controls.Add(this.partsandlaborTB);
            this.costsGB.Controls.Add(this.serviceTB);
            this.costsGB.Controls.Add(this.totalLB);
            this.costsGB.Controls.Add(this.taxLB);
            this.costsGB.Controls.Add(this.serviceLB);
            this.costsGB.Location = new System.Drawing.Point(24, 170);
            this.costsGB.Name = "costsGB";
            this.costsGB.Size = new System.Drawing.Size(348, 122);
            this.costsGB.TabIndex = 19;
            this.costsGB.TabStop = false;
            this.costsGB.Text = "Costs";
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(120, 98);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 7;
            // 
            // taxTB
            // 
            this.taxTB.Location = new System.Drawing.Point(120, 72);
            this.taxTB.Name = "taxTB";
            this.taxTB.ReadOnly = true;
            this.taxTB.Size = new System.Drawing.Size(100, 20);
            this.taxTB.TabIndex = 6;
            // 
            // partsandlaborTB
            // 
            this.partsandlaborTB.Location = new System.Drawing.Point(120, 46);
            this.partsandlaborTB.Name = "partsandlaborTB";
            this.partsandlaborTB.ReadOnly = true;
            this.partsandlaborTB.Size = new System.Drawing.Size(100, 20);
            this.partsandlaborTB.TabIndex = 5;
            // 
            // serviceTB
            // 
            this.serviceTB.Location = new System.Drawing.Point(120, 19);
            this.serviceTB.Name = "serviceTB";
            this.serviceTB.ReadOnly = true;
            this.serviceTB.Size = new System.Drawing.Size(100, 20);
            this.serviceTB.TabIndex = 4;
            // 
            // totalLB
            // 
            this.totalLB.AutoSize = true;
            this.totalLB.Location = new System.Drawing.Point(62, 101);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(52, 13);
            this.totalLB.TabIndex = 3;
            this.totalLB.Text = "Total Fee";
            // 
            // taxLB
            // 
            this.taxLB.AutoSize = true;
            this.taxLB.Location = new System.Drawing.Point(66, 75);
            this.taxLB.Name = "taxLB";
            this.taxLB.Size = new System.Drawing.Size(48, 13);
            this.taxLB.TabIndex = 2;
            this.taxLB.Text = "Tax (5%)";
            // 
            // serviceLB
            // 
            this.serviceLB.AutoSize = true;
            this.serviceLB.Location = new System.Drawing.Point(56, 22);
            this.serviceLB.Name = "serviceLB";
            this.serviceLB.Size = new System.Drawing.Size(58, 13);
            this.serviceLB.TabIndex = 0;
            this.serviceLB.Text = "Service ($)";
            // 
            // laborTB
            // 
            this.laborTB.Location = new System.Drawing.Point(59, 46);
            this.laborTB.Name = "laborTB";
            this.laborTB.Size = new System.Drawing.Size(100, 20);
            this.laborTB.TabIndex = 3;
            this.laborTB.TextChanged += new System.EventHandler(this.laborTB_TextChanged);
            // 
            // partsandlaborLB
            // 
            this.partsandlaborLB.AutoSize = true;
            this.partsandlaborLB.Location = new System.Drawing.Point(17, 49);
            this.partsandlaborLB.Name = "partsandlaborLB";
            this.partsandlaborLB.Size = new System.Drawing.Size(97, 13);
            this.partsandlaborLB.TabIndex = 8;
            this.partsandlaborLB.Text = "Parts and Labor ($)";
            // 
            // oilandlubeCBL
            // 
            this.oilandlubeCBL.CheckOnClick = true;
            this.oilandlubeCBL.ColumnWidth = 10;
            this.oilandlubeCBL.FormattingEnabled = true;
            this.oilandlubeCBL.Items.AddRange(new object[] {
            "Oil Change ($26.00)",
            "Lube job ($18.00)"});
            this.oilandlubeCBL.Location = new System.Drawing.Point(6, 19);
            this.oilandlubeCBL.Name = "oilandlubeCBL";
            this.oilandlubeCBL.Size = new System.Drawing.Size(120, 34);
            this.oilandlubeCBL.TabIndex = 1;
            this.oilandlubeCBL.SelectedIndexChanged += new System.EventHandler(this.oilandlubeCBL_SelectedIndexChanged);
            // 
            // clearBUT
            // 
            this.clearBUT.Location = new System.Drawing.Point(253, 65);
            this.clearBUT.Name = "clearBUT";
            this.clearBUT.Size = new System.Drawing.Size(75, 23);
            this.clearBUT.TabIndex = 9;
            this.clearBUT.Text = "Clear";
            this.clearBUT.UseVisualStyleBackColor = true;
            this.clearBUT.Click += new System.EventHandler(this.clearBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.costsGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.miscGB);
            this.Controls.Add(this.flushisGB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.miscGB.ResumeLayout(false);
            this.flushisGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.costsGB.ResumeLayout(false);
            this.costsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox partsTB;
        private System.Windows.Forms.Label laborLB;
        private System.Windows.Forms.Label partsLB;
        private System.Windows.Forms.GroupBox miscGB;
        private System.Windows.Forms.CheckedListBox miscCBL;
        private System.Windows.Forms.GroupBox flushisGB;
        private System.Windows.Forms.CheckedListBox flushesCBL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox costsGB;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox taxTB;
        private System.Windows.Forms.TextBox partsandlaborTB;
        private System.Windows.Forms.TextBox serviceTB;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label taxLB;
        private System.Windows.Forms.Label serviceLB;
        private System.Windows.Forms.TextBox laborTB;
        private System.Windows.Forms.Label partsandlaborLB;
        private System.Windows.Forms.CheckedListBox oilandlubeCBL;
        private System.Windows.Forms.Button clearBUT;
    }
}

