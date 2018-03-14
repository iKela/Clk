namespace Clinic
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SC_Doctors = new System.Windows.Forms.SplitContainer();
            this.PNL_Buttons = new System.Windows.Forms.Panel();
            this.BTN_RemoveDoctor = new System.Windows.Forms.Button();
            this.BTN_AddDoctor = new System.Windows.Forms.Button();
            this.PNL_Doctors = new System.Windows.Forms.Panel();
            this.LB_Doctors = new System.Windows.Forms.ListBox();
            this.SC_Reg = new System.Windows.Forms.SplitContainer();
            this.LB_Time = new System.Windows.Forms.ListBox();
            this.MC_Calendar = new System.Windows.Forms.MonthCalendar();
            this.DGV_Patients = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SC_Doctors)).BeginInit();
            this.SC_Doctors.Panel1.SuspendLayout();
            this.SC_Doctors.Panel2.SuspendLayout();
            this.SC_Doctors.SuspendLayout();
            this.PNL_Buttons.SuspendLayout();
            this.PNL_Doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_Reg)).BeginInit();
            this.SC_Reg.Panel1.SuspendLayout();
            this.SC_Reg.Panel2.SuspendLayout();
            this.SC_Reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patients)).BeginInit();
            this.SuspendLayout();
            // 
            // SC_Doctors
            // 
            this.SC_Doctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SC_Doctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_Doctors.Location = new System.Drawing.Point(0, 0);
            this.SC_Doctors.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SC_Doctors.Name = "SC_Doctors";
            // 
            // SC_Doctors.Panel1
            // 
            this.SC_Doctors.Panel1.Controls.Add(this.PNL_Buttons);
            this.SC_Doctors.Panel1.Controls.Add(this.PNL_Doctors);
            // 
            // SC_Doctors.Panel2
            // 
            this.SC_Doctors.Panel2.Controls.Add(this.SC_Reg);
            this.SC_Doctors.Size = new System.Drawing.Size(1211, 719);
            this.SC_Doctors.SplitterDistance = 384;
            this.SC_Doctors.SplitterWidth = 8;
            this.SC_Doctors.TabIndex = 0;
            // 
            // PNL_Buttons
            // 
            this.PNL_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Buttons.Controls.Add(this.BTN_RemoveDoctor);
            this.PNL_Buttons.Controls.Add(this.BTN_AddDoctor);
            this.PNL_Buttons.Location = new System.Drawing.Point(0, 677);
            this.PNL_Buttons.Name = "PNL_Buttons";
            this.PNL_Buttons.Size = new System.Drawing.Size(382, 34);
            this.PNL_Buttons.TabIndex = 1;
            // 
            // BTN_RemoveDoctor
            // 
            this.BTN_RemoveDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveDoctor.BackColor = System.Drawing.Color.White;
            this.BTN_RemoveDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_RemoveDoctor.BackgroundImage")));
            this.BTN_RemoveDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_RemoveDoctor.Location = new System.Drawing.Point(189, 0);
            this.BTN_RemoveDoctor.Name = "BTN_RemoveDoctor";
            this.BTN_RemoveDoctor.Size = new System.Drawing.Size(191, 34);
            this.BTN_RemoveDoctor.TabIndex = 1;
            this.BTN_RemoveDoctor.UseVisualStyleBackColor = false;
            this.BTN_RemoveDoctor.Click += new System.EventHandler(this.BTN_RemoveDoctor_Click);
            // 
            // BTN_AddDoctor
            // 
            this.BTN_AddDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_AddDoctor.BackColor = System.Drawing.Color.White;
            this.BTN_AddDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AddDoctor.BackgroundImage")));
            this.BTN_AddDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddDoctor.Location = new System.Drawing.Point(-2, 0);
            this.BTN_AddDoctor.Name = "BTN_AddDoctor";
            this.BTN_AddDoctor.Size = new System.Drawing.Size(191, 34);
            this.BTN_AddDoctor.TabIndex = 0;
            this.BTN_AddDoctor.UseVisualStyleBackColor = false;
            // 
            // PNL_Doctors
            // 
            this.PNL_Doctors.Controls.Add(this.LB_Doctors);
            this.PNL_Doctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Doctors.Location = new System.Drawing.Point(0, 0);
            this.PNL_Doctors.Name = "PNL_Doctors";
            this.PNL_Doctors.Size = new System.Drawing.Size(380, 715);
            this.PNL_Doctors.TabIndex = 2;
            // 
            // LB_Doctors
            // 
            this.LB_Doctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Doctors.FormattingEnabled = true;
            this.LB_Doctors.ItemHeight = 25;
            this.LB_Doctors.Items.AddRange(new object[] {
            "Ковальчук Назар Миколайович",
            "Волянюк Юрій Олегович",
            "Туровський Олександр Андрійович"});
            this.LB_Doctors.Location = new System.Drawing.Point(0, 0);
            this.LB_Doctors.Name = "LB_Doctors";
            this.LB_Doctors.Size = new System.Drawing.Size(380, 715);
            this.LB_Doctors.TabIndex = 0;
            // 
            // SC_Reg
            // 
            this.SC_Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SC_Reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_Reg.Location = new System.Drawing.Point(0, 0);
            this.SC_Reg.Name = "SC_Reg";
            // 
            // SC_Reg.Panel1
            // 
            this.SC_Reg.Panel1.Controls.Add(this.LB_Time);
            this.SC_Reg.Panel1.Controls.Add(this.MC_Calendar);
            this.SC_Reg.Panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SC_Reg.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // SC_Reg.Panel2
            // 
            this.SC_Reg.Panel2.Controls.Add(this.DGV_Patients);
            this.SC_Reg.Size = new System.Drawing.Size(819, 719);
            this.SC_Reg.SplitterDistance = 167;
            this.SC_Reg.TabIndex = 0;
            // 
            // LB_Time
            // 
            this.LB_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Time.FormatString = "t";
            this.LB_Time.FormattingEnabled = true;
            this.LB_Time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_Time.ItemHeight = 25;
            this.LB_Time.Items.AddRange(new object[] {
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "          8:15",
            "          8:25",
            "          8:40",
            "        "});
            this.LB_Time.Location = new System.Drawing.Point(0, 162);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Time.Size = new System.Drawing.Size(163, 553);
            this.LB_Time.TabIndex = 1;
            // 
            // MC_Calendar
            // 
            this.MC_Calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MC_Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MC_Calendar.Location = new System.Drawing.Point(0, 0);
            this.MC_Calendar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MC_Calendar.Name = "MC_Calendar";
            this.MC_Calendar.TabIndex = 0;
            // 
            // DGV_Patients
            // 
            this.DGV_Patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Patients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Birthday,
            this.Address});
            this.DGV_Patients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Patients.Location = new System.Drawing.Point(0, 0);
            this.DGV_Patients.Name = "DGV_Patients";
            this.DGV_Patients.Size = new System.Drawing.Size(644, 715);
            this.DGV_Patients.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "П.І.Б";
            this.UserName.Name = "UserName";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "День Народження";
            this.Birthday.Name = "Birthday";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адреса";
            this.Address.Name = "Address";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 719);
            this.Controls.Add(this.SC_Doctors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1227, 758);
            this.Name = "Main";
            this.Text = "Поліклініка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SC_Doctors.Panel1.ResumeLayout(false);
            this.SC_Doctors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_Doctors)).EndInit();
            this.SC_Doctors.ResumeLayout(false);
            this.PNL_Buttons.ResumeLayout(false);
            this.PNL_Doctors.ResumeLayout(false);
            this.SC_Reg.Panel1.ResumeLayout(false);
            this.SC_Reg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_Reg)).EndInit();
            this.SC_Reg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SC_Doctors;
        private System.Windows.Forms.SplitContainer SC_Reg;
        private System.Windows.Forms.MonthCalendar MC_Calendar;
        private System.Windows.Forms.ListBox LB_Time;
        private System.Windows.Forms.Panel PNL_Buttons;
        private System.Windows.Forms.Button BTN_RemoveDoctor;
        private System.Windows.Forms.Button BTN_AddDoctor;
        private System.Windows.Forms.Panel PNL_Doctors;
        private System.Windows.Forms.ListBox LB_Doctors;
        private System.Windows.Forms.DataGridView DGV_Patients;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

