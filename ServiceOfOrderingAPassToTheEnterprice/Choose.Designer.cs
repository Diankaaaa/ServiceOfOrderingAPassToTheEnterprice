namespace ServiceOfOrderingAPassToTheEnterprice
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.but2 = new ServiceOfOrderingAPassToTheEnterprice.But();
            this.but1 = new ServiceOfOrderingAPassToTheEnterprice.But();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название компании";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(752, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 59);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but2.FlatAppearance.BorderSize = 0;
            this.but2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.but2.Image = global::ServiceOfOrderingAPassToTheEnterprice.Properties.Resources.User7;
            this.but2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but2.Location = new System.Drawing.Point(456, 186);
            this.but2.Name = "but2";
            this.but2.Padding = new System.Windows.Forms.Padding(25, 50, 25, 15);
            this.but2.Size = new System.Drawing.Size(343, 310);
            this.but2.TabIndex = 2;
            this.but2.Text = "Групповое посещение";
            this.but2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but2.UseVisualStyleBackColor = false;
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but1.FlatAppearance.BorderSize = 0;
            this.but1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.but1.Image = global::ServiceOfOrderingAPassToTheEnterprice.Properties.Resources.User7;
            this.but1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but1.Location = new System.Drawing.Point(66, 186);
            this.but1.Name = "but1";
            this.but1.Padding = new System.Windows.Forms.Padding(25, 50, 25, 15);
            this.but1.Size = new System.Drawing.Size(343, 310);
            this.but1.TabIndex = 1;
            this.but1.Text = "Личное посещение";
            this.but1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(33, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 52);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private But but1;
        private But but2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}