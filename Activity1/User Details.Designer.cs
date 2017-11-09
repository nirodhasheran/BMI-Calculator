namespace Activity1
{
    partial class User_Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "WEIGHT (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(249, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "HEIGHT (m)";
            // 
            // tb_weight
            // 
            this.tb_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_weight.ForeColor = System.Drawing.Color.Indigo;
            this.tb_weight.Location = new System.Drawing.Point(420, 75);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(161, 31);
            this.tb_weight.TabIndex = 3;
            this.tb_weight.UseWaitCursor = true;
            this.tb_weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // tb_height
            // 
            this.tb_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_height.ForeColor = System.Drawing.Color.Indigo;
            this.tb_height.Location = new System.Drawing.Point(420, 140);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(161, 31);
            this.tb_height.TabIndex = 4;
            this.tb_height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity1.Properties.Resources.icon175x175;
            this.pictureBox1.Location = new System.Drawing.Point(33, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(669, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User_Details";
            this.Text = "User_Details";
            this.Load += new System.EventHandler(this.User_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Button button1;
    }
}