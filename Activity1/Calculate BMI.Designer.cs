namespace Activity1
{
    partial class Calculate_BMI
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
            this.td_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR BMI IS";
            // 
            // td_result
            // 
            this.td_result.AcceptsReturn = true;
            this.td_result.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.td_result.Enabled = false;
            this.td_result.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_result.ForeColor = System.Drawing.Color.DarkRed;
            this.td_result.Location = new System.Drawing.Point(301, 111);
            this.td_result.Margin = new System.Windows.Forms.Padding(0);
            this.td_result.Name = "td_result";
            this.td_result.ReadOnly = true;
            this.td_result.Size = new System.Drawing.Size(265, 51);
            this.td_result.TabIndex = 3;
            this.td_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.td_result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity1.Properties.Resources.asa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Calculate_BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(655, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.td_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calculate_BMI";
            this.Text = "Calculate_BMI";
            this.Load += new System.EventHandler(this.Calculate_BMI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox td_result;
        private System.Windows.Forms.Button button1;
    }
}