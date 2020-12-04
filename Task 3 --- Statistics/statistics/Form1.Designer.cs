namespace statistics
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input10 = new System.Windows.Forms.TextBox();
            this.input9 = new System.Windows.Forms.TextBox();
            this.input8 = new System.Windows.Forms.TextBox();
            this.input7 = new System.Windows.Forms.TextBox();
            this.input6 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.standartDeviation = new System.Windows.Forms.Label();
            this.variance = new System.Windows.Forms.Label();
            this.medianText = new System.Windows.Forms.TextBox();
            this.modeText = new System.Windows.Forms.TextBox();
            this.averageText = new System.Windows.Forms.TextBox();
            this.SDText = new System.Windows.Forms.TextBox();
            this.varianceTxt = new System.Windows.Forms.TextBox();
            this.meanText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 72);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 22);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(12, 100);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 22);
            this.input2.TabIndex = 1;
            // 
            // input10
            // 
            this.input10.Location = new System.Drawing.Point(12, 324);
            this.input10.Name = "input10";
            this.input10.Size = new System.Drawing.Size(100, 22);
            this.input10.TabIndex = 4;
            // 
            // input9
            // 
            this.input9.Location = new System.Drawing.Point(12, 296);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(100, 22);
            this.input9.TabIndex = 5;
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(12, 268);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(100, 22);
            this.input8.TabIndex = 6;
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(12, 240);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(100, 22);
            this.input7.TabIndex = 7;
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(12, 212);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(100, 22);
            this.input6.TabIndex = 8;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(12, 184);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(100, 22);
            this.input5.TabIndex = 9;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(12, 156);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 22);
            this.input4.TabIndex = 10;
            this.input4.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(12, 128);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 22);
            this.input3.TabIndex = 11;
            this.input3.TextChanged += new System.EventHandler(this.TextBox12_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input 10 values";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mean";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Median";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(626, 245);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(43, 17);
            this.mode.TabIndex = 17;
            this.mode.Text = "Mode";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(619, 187);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(61, 17);
            this.average.TabIndex = 18;
            this.average.Text = "Average";
            // 
            // standartDeviation
            // 
            this.standartDeviation.AutoSize = true;
            this.standartDeviation.Location = new System.Drawing.Point(585, 133);
            this.standartDeviation.Name = "standartDeviation";
            this.standartDeviation.Size = new System.Drawing.Size(129, 17);
            this.standartDeviation.TabIndex = 19;
            this.standartDeviation.Text = "Standard Deviation";
            // 
            // variance
            // 
            this.variance.AutoSize = true;
            this.variance.Location = new System.Drawing.Point(616, 72);
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(64, 17);
            this.variance.TabIndex = 20;
            this.variance.Text = "Variance";
            this.variance.Click += new System.EventHandler(this.Label9_Click);
            // 
            // medianText
            // 
            this.medianText.Location = new System.Drawing.Point(602, 324);
            this.medianText.Name = "medianText";
            this.medianText.Size = new System.Drawing.Size(100, 22);
            this.medianText.TabIndex = 21;
            // 
            // modeText
            // 
            this.modeText.Location = new System.Drawing.Point(602, 268);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(100, 22);
            this.modeText.TabIndex = 22;
            // 
            // averageText
            // 
            this.averageText.Location = new System.Drawing.Point(602, 212);
            this.averageText.Name = "averageText";
            this.averageText.Size = new System.Drawing.Size(100, 22);
            this.averageText.TabIndex = 23;
            // 
            // SDText
            // 
            this.SDText.Location = new System.Drawing.Point(602, 156);
            this.SDText.Name = "SDText";
            this.SDText.Size = new System.Drawing.Size(100, 22);
            this.SDText.TabIndex = 24;
            // 
            // varianceTxt
            // 
            this.varianceTxt.Location = new System.Drawing.Point(602, 100);
            this.varianceTxt.Name = "varianceTxt";
            this.varianceTxt.Size = new System.Drawing.Size(100, 22);
            this.varianceTxt.TabIndex = 25;
            // 
            // meanText
            // 
            this.meanText.Location = new System.Drawing.Point(602, 37);
            this.meanText.Name = "meanText";
            this.meanText.Size = new System.Drawing.Size(100, 22);
            this.meanText.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meanText);
            this.Controls.Add(this.varianceTxt);
            this.Controls.Add(this.SDText);
            this.Controls.Add(this.averageText);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.medianText);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.standartDeviation);
            this.Controls.Add(this.average);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.input9);
            this.Controls.Add(this.input10);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input10;
        private System.Windows.Forms.TextBox input9;
        private System.Windows.Forms.TextBox input8;
        private System.Windows.Forms.TextBox input7;
        private System.Windows.Forms.TextBox input6;
        private System.Windows.Forms.TextBox input5;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label standartDeviation;
        private System.Windows.Forms.Label variance;
        private System.Windows.Forms.TextBox medianText;
        private System.Windows.Forms.TextBox modeText;
        private System.Windows.Forms.TextBox averageText;
        private System.Windows.Forms.TextBox SDText;
        private System.Windows.Forms.TextBox varianceTxt;
        private System.Windows.Forms.TextBox meanText;
        private System.Windows.Forms.Button button1;
    }
}

