namespace HR_Management_App
{
    partial class mainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.view_all_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.update_delete_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_all_btn
            // 
            this.view_all_btn.BackColor = System.Drawing.Color.Crimson;
            this.view_all_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_all_btn.ForeColor = System.Drawing.Color.White;
            this.view_all_btn.Location = new System.Drawing.Point(213, 268);
            this.view_all_btn.Name = "view_all_btn";
            this.view_all_btn.Size = new System.Drawing.Size(253, 49);
            this.view_all_btn.TabIndex = 12;
            this.view_all_btn.Text = "View All";
            this.view_all_btn.UseVisualStyleBackColor = false;
            this.view_all_btn.Click += new System.EventHandler(this.view_all_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(213, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 49);
            this.button3.TabIndex = 13;
            this.button3.Text = "Log out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // update_delete_btn
            // 
            this.update_delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.update_delete_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_delete_btn.ForeColor = System.Drawing.Color.White;
            this.update_delete_btn.Location = new System.Drawing.Point(213, 158);
            this.update_delete_btn.Name = "update_delete_btn";
            this.update_delete_btn.Size = new System.Drawing.Size(253, 49);
            this.update_delete_btn.TabIndex = 14;
            this.update_delete_btn.Text = "Update / Delete";
            this.update_delete_btn.UseVisualStyleBackColor = false;
            this.update_delete_btn.Click += new System.EventHandler(this.update_delete_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HR_Management_App.Properties.Resources.button;
            this.pictureBox1.Location = new System.Drawing.Point(655, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(687, 512);
            this.Controls.Add(this.update_delete_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.view_all_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button view_all_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button update_delete_btn;
    }
}