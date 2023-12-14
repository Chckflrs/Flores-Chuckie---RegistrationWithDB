namespace RegistrationWithDB
{
    partial class FrmClubRegistration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBStudentID = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBMiddleName = new System.Windows.Forms.TextBox();
            this.TBAge = new System.Windows.Forms.TextBox();
            this.CBProgram = new System.Windows.Forms.ComboBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.DataClubMembersView = new System.Windows.Forms.DataGridView();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataClubMembersView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "First name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "List Of Club Members:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender";
            // 
            // TBStudentID
            // 
            this.TBStudentID.Location = new System.Drawing.Point(12, 40);
            this.TBStudentID.Name = "TBStudentID";
            this.TBStudentID.Size = new System.Drawing.Size(215, 34);
            this.TBStudentID.TabIndex = 8;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(12, 135);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(215, 34);
            this.TBLastName.TabIndex = 9;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(321, 135);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(215, 34);
            this.TBFirstName.TabIndex = 10;
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Location = new System.Drawing.Point(595, 135);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.Size = new System.Drawing.Size(180, 34);
            this.TBMiddleName.TabIndex = 11;
            // 
            // TBAge
            // 
            this.TBAge.Location = new System.Drawing.Point(12, 219);
            this.TBAge.Name = "TBAge";
            this.TBAge.Size = new System.Drawing.Size(114, 34);
            this.TBAge.TabIndex = 12;
            // 
            // CBProgram
            // 
            this.CBProgram.FormattingEnabled = true;
            this.CBProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Hospitality Management"});
            this.CBProgram.Location = new System.Drawing.Point(321, 40);
            this.CBProgram.Name = "CBProgram";
            this.CBProgram.Size = new System.Drawing.Size(270, 36);
            this.CBProgram.TabIndex = 13;
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CBGender.Location = new System.Drawing.Point(321, 219);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(172, 36);
            this.CBGender.TabIndex = 14;
            // 
            // DataClubMembersView
            // 
            this.DataClubMembersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClubMembersView.Location = new System.Drawing.Point(12, 317);
            this.DataClubMembersView.Name = "DataClubMembersView";
            this.DataClubMembersView.RowHeadersWidth = 62;
            this.DataClubMembersView.RowTemplate.Height = 28;
            this.DataClubMembersView.Size = new System.Drawing.Size(770, 182);
            this.DataClubMembersView.TabIndex = 15;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(788, 66);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(135, 37);
            this.BtnRegister.TabIndex = 16;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(788, 132);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(135, 37);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(788, 307);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 37);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(932, 511);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.DataClubMembersView);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.CBProgram);
            this.Controls.Add(this.TBAge);
            this.Controls.Add(this.TBMiddleName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBStudentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmCubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataClubMembersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBStudentID;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBMiddleName;
        private System.Windows.Forms.TextBox TBAge;
        private System.Windows.Forms.ComboBox CBProgram;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.DataGridView DataClubMembersView;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnRefresh;
    }
}

