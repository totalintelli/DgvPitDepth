namespace DgvPitDepth
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
            this.dgvPitDepth = new System.Windows.Forms.DataGridView();
            this.nudRow1116 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc1116 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow1116)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPitDepth
            // 
            this.dgvPitDepth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitDepth.Location = new System.Drawing.Point(36, 75);
            this.dgvPitDepth.Name = "dgvPitDepth";
            this.dgvPitDepth.RowTemplate.Height = 30;
            this.dgvPitDepth.Size = new System.Drawing.Size(721, 376);
            this.dgvPitDepth.TabIndex = 0;
            // 
            // nudRow1116
            // 
            this.nudRow1116.Location = new System.Drawing.Point(420, 31);
            this.nudRow1116.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRow1116.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRow1116.Name = "nudRow1116";
            this.nudRow1116.Size = new System.Drawing.Size(120, 28);
            this.nudRow1116.TabIndex = 1;
            this.nudRow1116.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRow1116.ValueChanged += new System.EventHandler(this.nudRow1116_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Required Thickness Pit depth Reading Number";
            // 
            // btnCalc1116
            // 
            this.btnCalc1116.Location = new System.Drawing.Point(697, 482);
            this.btnCalc1116.Name = "btnCalc1116";
            this.btnCalc1116.Size = new System.Drawing.Size(75, 34);
            this.btnCalc1116.TabIndex = 3;
            this.btnCalc1116.Text = "실행";
            this.btnCalc1116.UseVisualStyleBackColor = true;
            this.btnCalc1116.Click += new System.EventHandler(this.btnCalc1116_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 528);
            this.Controls.Add(this.btnCalc1116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRow1116);
            this.Controls.Add(this.dgvPitDepth);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow1116)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPitDepth;
        private System.Windows.Forms.NumericUpDown nudRow1116;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc1116;
    }
}

