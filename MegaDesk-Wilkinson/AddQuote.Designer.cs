namespace MegaDesk_Wilkinson
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxDelivery = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width (inches):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Depth (inches):";
            // 
            // numericUpWidth
            // 
            this.numericUpWidth.Location = new System.Drawing.Point(183, 181);
            this.numericUpWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpWidth.Name = "numericUpWidth";
            this.numericUpWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUpWidth.TabIndex = 5;
            this.numericUpWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(183, 225);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDepth.TabIndex = 6;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Drawers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surface Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Delivery:";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(497, 181);
            this.numericUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownDrawers.TabIndex = 10;
            // 
            // comboBoxSurfaceMaterial
            // 
            this.comboBoxSurfaceMaterial.FormattingEnabled = true;
            this.comboBoxSurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.comboBoxSurfaceMaterial.Location = new System.Drawing.Point(497, 218);
            this.comboBoxSurfaceMaterial.Name = "comboBoxSurfaceMaterial";
            this.comboBoxSurfaceMaterial.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSurfaceMaterial.TabIndex = 11;
            // 
            // comboBoxDelivery
            // 
            this.comboBoxDelivery.FormattingEnabled = true;
            this.comboBoxDelivery.Items.AddRange(new object[] {
            "Rush - 3 Days",
            "Rush - 5 Days",
            "Rush - 7 Days",
            "No Rush"});
            this.comboBoxDelivery.Location = new System.Drawing.Point(497, 257);
            this.comboBoxDelivery.Name = "comboBoxDelivery";
            this.comboBoxDelivery.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDelivery.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get Quote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 39);
            this.label8.TabIndex = 15;
            this.label8.Text = "New Quote";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Size";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDelivery);
            this.Controls.Add(this.comboBoxSurfaceMaterial);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.numericUpWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.ComboBox comboBoxSurfaceMaterial;
        private System.Windows.Forms.ComboBox comboBoxDelivery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}