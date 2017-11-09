namespace Activity1
{
    partial class RangeView
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
            this.td_range = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // td_range
            // 
            this.td_range.AcceptsReturn = true;
            this.td_range.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.td_range.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_range.ForeColor = System.Drawing.Color.DarkRed;
            this.td_range.Location = new System.Drawing.Point(287, 121);
            this.td_range.Margin = new System.Windows.Forms.Padding(0);
            this.td_range.Name = "td_range";
            this.td_range.ReadOnly = true;
            this.td_range.Size = new System.Drawing.Size(345, 33);
            this.td_range.TabIndex = 4;
            this.td_range.TextChanged += new System.EventHandler(this.td_result_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity1.Properties.Resources.ideal_bmi_health_death;
            this.pictureBox1.InitialImage = global::Activity1.Properties.Resources.icon175x175;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 248);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(352, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Final Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(526, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "[EXIT]";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(658, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.td_range);
            this.Name = "RangeView";
            this.Text = "RangeView";
            this.Load += new System.EventHandler(this.RangeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox td_range;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}