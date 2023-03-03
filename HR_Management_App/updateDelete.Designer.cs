namespace HR_Management_App
{
    partial class updateDelete
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDtp = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TelephoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PositionCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.start_workDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.reset_tbn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.updateDeleteDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hR_DBDataSet = new HR_Management_App.HR_DBDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new HR_Management_App.HR_DBDataSetTableAdapters.employeeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datauroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.updateDeleteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(344, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update or Delete Employee";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTb.Location = new System.Drawing.Point(168, 63);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(190, 35);
            this.nameTb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // SurnameTb
            // 
            this.SurnameTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTb.Location = new System.Drawing.Point(168, 116);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(190, 35);
            this.SurnameTb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // BirthDtp
            // 
            this.BirthDtp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BirthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDtp.Location = new System.Drawing.Point(168, 178);
            this.BirthDtp.Name = "BirthDtp";
            this.BirthDtp.Size = new System.Drawing.Size(190, 35);
            this.BirthDtp.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(11, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 30);
            this.label10.TabIndex = 26;
            this.label10.Text = "Birthdate";
            // 
            // TelephoneTb
            // 
            this.TelephoneTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TelephoneTb.Location = new System.Drawing.Point(168, 244);
            this.TelephoneTb.Name = "TelephoneTb";
            this.TelephoneTb.Size = new System.Drawing.Size(190, 35);
            this.TelephoneTb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tel. Number";
            // 
            // PlaceTb
            // 
            this.PlaceTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlaceTb.Location = new System.Drawing.Point(168, 298);
            this.PlaceTb.Name = "PlaceTb";
            this.PlaceTb.Size = new System.Drawing.Size(190, 35);
            this.PlaceTb.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(16, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Place";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(9, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 30);
            this.label11.TabIndex = 33;
            this.label11.Text = "Address";
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressTb.Location = new System.Drawing.Point(168, 362);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(190, 35);
            this.AddressTb.TabIndex = 32;
            // 
            // PositionCb
            // 
            this.PositionCb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PositionCb.FormattingEnabled = true;
            this.PositionCb.Items.AddRange(new object[] {
            "machine operator ",
            "office worker",
            "storeman",
            "executive",
            "programmer"});
            this.PositionCb.Location = new System.Drawing.Point(168, 425);
            this.PositionCb.Name = "PositionCb";
            this.PositionCb.Size = new System.Drawing.Size(190, 38);
            this.PositionCb.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(11, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 30);
            this.label8.TabIndex = 34;
            this.label8.Text = "Position";
            // 
            // start_workDtp
            // 
            this.start_workDtp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_workDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_workDtp.Location = new System.Drawing.Point(168, 495);
            this.start_workDtp.Name = "start_workDtp";
            this.start_workDtp.Size = new System.Drawing.Size(190, 35);
            this.start_workDtp.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(11, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Start of Work";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Crimson;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(11, 559);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(131, 45);
            this.update_btn.TabIndex = 38;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // reset_tbn
            // 
            this.reset_tbn.BackColor = System.Drawing.Color.Crimson;
            this.reset_tbn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_tbn.ForeColor = System.Drawing.Color.White;
            this.reset_tbn.Location = new System.Drawing.Point(148, 559);
            this.reset_tbn.Name = "reset_tbn";
            this.reset_tbn.Size = new System.Drawing.Size(128, 45);
            this.reset_tbn.TabIndex = 39;
            this.reset_tbn.Text = "Reset";
            this.reset_tbn.UseVisualStyleBackColor = false;
            this.reset_tbn.Click += new System.EventHandler(this.reset_tbn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(282, 559);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(123, 45);
            this.delete_btn.TabIndex = 40;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(106, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 47);
            this.button4.TabIndex = 41;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // updateDeleteDGV
            // 
            this.updateDeleteDGV.AutoGenerateColumns = false;
            this.updateDeleteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateDeleteDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.updateDeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateDeleteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.datauroDataGridViewTextBoxColumn,
            this.telnumberDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.startworkDataGridViewTextBoxColumn});
            this.updateDeleteDGV.DataSource = this.employeeBindingSource;
            this.updateDeleteDGV.Location = new System.Drawing.Point(423, 68);
            this.updateDeleteDGV.Name = "updateDeleteDGV";
            this.updateDeleteDGV.RowHeadersWidth = 30;
            this.updateDeleteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updateDeleteDGV.Size = new System.Drawing.Size(632, 538);
            this.updateDeleteDGV.TabIndex = 42;
            this.updateDeleteDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateDeleteDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HR_Management_App.Properties.Resources.button;
            this.pictureBox1.Location = new System.Drawing.Point(1049, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hR_DBDataSet
            // 
            this.hR_DBDataSet.DataSetName = "HR_DBDataSet";
            this.hR_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.hR_DBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // datauroDataGridViewTextBoxColumn
            // 
            this.datauroDataGridViewTextBoxColumn.DataPropertyName = "data_uro";
            this.datauroDataGridViewTextBoxColumn.HeaderText = "data_uro";
            this.datauroDataGridViewTextBoxColumn.Name = "datauroDataGridViewTextBoxColumn";
            // 
            // telnumberDataGridViewTextBoxColumn
            // 
            this.telnumberDataGridViewTextBoxColumn.DataPropertyName = "tel_number";
            this.telnumberDataGridViewTextBoxColumn.HeaderText = "tel_number";
            this.telnumberDataGridViewTextBoxColumn.Name = "telnumberDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // startworkDataGridViewTextBoxColumn
            // 
            this.startworkDataGridViewTextBoxColumn.DataPropertyName = "start_work";
            this.startworkDataGridViewTextBoxColumn.HeaderText = "start_work";
            this.startworkDataGridViewTextBoxColumn.Name = "startworkDataGridViewTextBoxColumn";
            // 
            // updateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1079, 670);
            this.Controls.Add(this.updateDeleteDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reset_tbn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.start_workDtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PositionCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.PlaceTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelephoneTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthDtp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateDelete";
            this.Load += new System.EventHandler(this.updateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateDeleteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirthDtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TelephoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlaceTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.ComboBox PositionCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker start_workDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button reset_tbn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView updateDeleteDGV;
        private HR_DBDataSet hR_DBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HR_DBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datauroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startworkDataGridViewTextBoxColumn;
    }
}