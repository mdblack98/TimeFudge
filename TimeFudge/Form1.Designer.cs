using TimeFudge;

namespace TimeFudge
{
    partial class TimeFudgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeFudgeForm));
            this.buttonFudge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFudge
            // 
            this.buttonFudge.Location = new System.Drawing.Point(1, 22);
            this.buttonFudge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFudge.Name = "buttonFudge";
            this.buttonFudge.Size = new System.Drawing.Size(100, 28);
            this.buttonFudge.TabIndex = 0;
            this.buttonFudge.Text = "Fudge";
            this.buttonFudge.UseVisualStyleBackColor = true;
            this.buttonFudge.Click += new System.EventHandler(this.buttonFudge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Seconds";
            this.label1.Text = "Seconds";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(191, 30);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 17);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TimeFudge.Properties.Settings.Default, "Seconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownSeconds.DecimalPlaces = 2;
            this.numericUpDownSeconds.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSeconds.Location = new System.Drawing.Point(107, 26);
            this.numericUpDownSeconds.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownSeconds.TabIndex = 1;
            this.numericUpDownSeconds.Value = global::TimeFudge.Properties.Settings.Default.Seconds;
            // 
            // TimeFudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 55);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.buttonFudge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeFudgeForm";
            this.Text = "TimeFudge v1.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeFudge_FormClosing);
            this.Load += new System.EventHandler(this.TimeFudge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFudge;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label3;
    }
}

