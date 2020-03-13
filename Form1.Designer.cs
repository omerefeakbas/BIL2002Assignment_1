namespace BIL2002Assignment_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.educationStateLabel = new System.Windows.Forms.Label();
            this.postGraduateUniversityLabel = new System.Windows.Forms.Label();
            this.postGraduateUniversityTextBox = new System.Windows.Forms.TextBox();
            this.bachelorUniversityLabel = new System.Windows.Forms.Label();
            this.bachelorUniversityTextBox = new System.Windows.Forms.TextBox();
            this.bachelorDepartmentLabel = new System.Windows.Forms.Label();
            this.bachelorDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.postGraduateDepartmentLabel = new System.Windows.Forms.Label();
            this.postGraduateDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.pointLabel = new System.Windows.Forms.Label();
            this.addLectureGroupBox = new System.Windows.Forms.GroupBox();
            this.addLectureButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.ectsCreditTextBox = new System.Windows.Forms.TextBox();
            this.ectsCreditLabel = new System.Windows.Forms.Label();
            this.lectureNametextBox = new System.Windows.Forms.TextBox();
            this.lectureNameLabel = new System.Windows.Forms.Label();
            this.lectureCodetextBox = new System.Windows.Forms.TextBox();
            this.lectureCodeLabel = new System.Windows.Forms.Label();
            this.addLectureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addStudentButton.Location = new System.Drawing.Point(51, 580);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(225, 94);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(51, 164);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(677, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 564);
            this.listBox1.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name*";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(51, 192);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(110, 17);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "School Number*";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(51, 215);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(225, 22);
            this.numberTextBox.TabIndex = 4;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(51, 246);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(87, 17);
            this.departmentLabel.TabIndex = 7;
            this.departmentLabel.Text = "Department*";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(51, 269);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(225, 22);
            this.departmentTextBox.TabIndex = 6;
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(677, 61);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(316, 24);
            this.studentsComboBox.TabIndex = 8;
            this.studentsComboBox.Text = "Please Select Student";
            this.studentsComboBox.SelectedIndexChanged += new System.EventHandler(this.studentsComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bachelor",
            "Postgraduate",
            "PhD"});
            this.comboBox1.Location = new System.Drawing.Point(51, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Bachelor";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // educationStateLabel
            // 
            this.educationStateLabel.AutoSize = true;
            this.educationStateLabel.Location = new System.Drawing.Point(51, 87);
            this.educationStateLabel.Name = "educationStateLabel";
            this.educationStateLabel.Size = new System.Drawing.Size(127, 17);
            this.educationStateLabel.TabIndex = 10;
            this.educationStateLabel.Text = "State Of Education";
            // 
            // postGraduateUniversityLabel
            // 
            this.postGraduateUniversityLabel.AutoSize = true;
            this.postGraduateUniversityLabel.Location = new System.Drawing.Point(51, 455);
            this.postGraduateUniversityLabel.Name = "postGraduateUniversityLabel";
            this.postGraduateUniversityLabel.Size = new System.Drawing.Size(164, 17);
            this.postGraduateUniversityLabel.TabIndex = 14;
            this.postGraduateUniversityLabel.Text = "Postgraduate University*";
            this.postGraduateUniversityLabel.Visible = false;
            // 
            // postGraduateUniversityTextBox
            // 
            this.postGraduateUniversityTextBox.Location = new System.Drawing.Point(51, 478);
            this.postGraduateUniversityTextBox.Name = "postGraduateUniversityTextBox";
            this.postGraduateUniversityTextBox.Size = new System.Drawing.Size(225, 22);
            this.postGraduateUniversityTextBox.TabIndex = 13;
            this.postGraduateUniversityTextBox.Visible = false;
            // 
            // bachelorUniversityLabel
            // 
            this.bachelorUniversityLabel.AutoSize = true;
            this.bachelorUniversityLabel.Location = new System.Drawing.Point(51, 323);
            this.bachelorUniversityLabel.Name = "bachelorUniversityLabel";
            this.bachelorUniversityLabel.Size = new System.Drawing.Size(135, 17);
            this.bachelorUniversityLabel.TabIndex = 12;
            this.bachelorUniversityLabel.Text = "Bachelor University*";
            this.bachelorUniversityLabel.Visible = false;
            // 
            // bachelorUniversityTextBox
            // 
            this.bachelorUniversityTextBox.Location = new System.Drawing.Point(51, 346);
            this.bachelorUniversityTextBox.Name = "bachelorUniversityTextBox";
            this.bachelorUniversityTextBox.Size = new System.Drawing.Size(225, 22);
            this.bachelorUniversityTextBox.TabIndex = 11;
            this.bachelorUniversityTextBox.Visible = false;
            // 
            // bachelorDepartmentLabel
            // 
            this.bachelorDepartmentLabel.AutoSize = true;
            this.bachelorDepartmentLabel.Location = new System.Drawing.Point(51, 376);
            this.bachelorDepartmentLabel.Name = "bachelorDepartmentLabel";
            this.bachelorDepartmentLabel.Size = new System.Drawing.Size(147, 17);
            this.bachelorDepartmentLabel.TabIndex = 16;
            this.bachelorDepartmentLabel.Text = "Bachelor Department*";
            this.bachelorDepartmentLabel.Visible = false;
            // 
            // bachelorDepartmentTextBox
            // 
            this.bachelorDepartmentTextBox.Location = new System.Drawing.Point(51, 399);
            this.bachelorDepartmentTextBox.Name = "bachelorDepartmentTextBox";
            this.bachelorDepartmentTextBox.Size = new System.Drawing.Size(225, 22);
            this.bachelorDepartmentTextBox.TabIndex = 15;
            this.bachelorDepartmentTextBox.Visible = false;
            // 
            // postGraduateDepartmentLabel
            // 
            this.postGraduateDepartmentLabel.AutoSize = true;
            this.postGraduateDepartmentLabel.Location = new System.Drawing.Point(51, 508);
            this.postGraduateDepartmentLabel.Name = "postGraduateDepartmentLabel";
            this.postGraduateDepartmentLabel.Size = new System.Drawing.Size(176, 17);
            this.postGraduateDepartmentLabel.TabIndex = 18;
            this.postGraduateDepartmentLabel.Text = "Postgraduate Department*";
            this.postGraduateDepartmentLabel.Visible = false;
            // 
            // postGraduateDepartmentTextBox
            // 
            this.postGraduateDepartmentTextBox.Location = new System.Drawing.Point(51, 531);
            this.postGraduateDepartmentTextBox.Name = "postGraduateDepartmentTextBox";
            this.postGraduateDepartmentTextBox.Size = new System.Drawing.Size(225, 22);
            this.postGraduateDepartmentTextBox.TabIndex = 17;
            this.postGraduateDepartmentTextBox.Visible = false;
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(339, 67);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(0, 17);
            this.pointLabel.TabIndex = 19;
            // 
            // addLectureGroupBox
            // 
            this.addLectureGroupBox.Controls.Add(this.addLectureButton);
            this.addLectureGroupBox.Controls.Add(this.gradeTextBox);
            this.addLectureGroupBox.Controls.Add(this.gradeLabel);
            this.addLectureGroupBox.Controls.Add(this.ectsCreditTextBox);
            this.addLectureGroupBox.Controls.Add(this.ectsCreditLabel);
            this.addLectureGroupBox.Controls.Add(this.lectureNametextBox);
            this.addLectureGroupBox.Controls.Add(this.lectureNameLabel);
            this.addLectureGroupBox.Controls.Add(this.lectureCodetextBox);
            this.addLectureGroupBox.Controls.Add(this.lectureCodeLabel);
            this.addLectureGroupBox.Location = new System.Drawing.Point(326, 87);
            this.addLectureGroupBox.Name = "addLectureGroupBox";
            this.addLectureGroupBox.Size = new System.Drawing.Size(307, 620);
            this.addLectureGroupBox.TabIndex = 20;
            this.addLectureGroupBox.TabStop = false;
            this.addLectureGroupBox.Text = "--";
            this.addLectureGroupBox.Visible = false;
            // 
            // addLectureButton
            // 
            this.addLectureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLectureButton.Location = new System.Drawing.Point(38, 493);
            this.addLectureButton.Name = "addLectureButton";
            this.addLectureButton.Size = new System.Drawing.Size(225, 94);
            this.addLectureButton.TabIndex = 21;
            this.addLectureButton.Text = "Add Lecture";
            this.addLectureButton.UseVisualStyleBackColor = true;
            this.addLectureButton.Click += new System.EventHandler(this.addLectureButton_Click);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(0, 227);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(57, 22);
            this.gradeTextBox.TabIndex = 7;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(-1, 207);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(99, 17);
            this.gradeLabel.TabIndex = 6;
            this.gradeLabel.Text = "Grade (0-100)";
            // 
            // ectsCreditTextBox
            // 
            this.ectsCreditTextBox.Location = new System.Drawing.Point(0, 182);
            this.ectsCreditTextBox.Name = "ectsCreditTextBox";
            this.ectsCreditTextBox.Size = new System.Drawing.Size(30, 22);
            this.ectsCreditTextBox.TabIndex = 5;
            // 
            // ectsCreditLabel
            // 
            this.ectsCreditLabel.AutoSize = true;
            this.ectsCreditLabel.Location = new System.Drawing.Point(-1, 159);
            this.ectsCreditLabel.Name = "ectsCreditLabel";
            this.ectsCreditLabel.Size = new System.Drawing.Size(160, 17);
            this.ectsCreditLabel.TabIndex = 4;
            this.ectsCreditLabel.Text = "ECTS Credit (Default: 5)";
            // 
            // lectureNametextBox
            // 
            this.lectureNametextBox.Location = new System.Drawing.Point(0, 128);
            this.lectureNametextBox.Name = "lectureNametextBox";
            this.lectureNametextBox.Size = new System.Drawing.Size(254, 22);
            this.lectureNametextBox.TabIndex = 3;
            // 
            // lectureNameLabel
            // 
            this.lectureNameLabel.AutoSize = true;
            this.lectureNameLabel.Location = new System.Drawing.Point(-1, 105);
            this.lectureNameLabel.Name = "lectureNameLabel";
            this.lectureNameLabel.Size = new System.Drawing.Size(97, 17);
            this.lectureNameLabel.TabIndex = 2;
            this.lectureNameLabel.Text = "Lecture Name";
            // 
            // lectureCodetextBox
            // 
            this.lectureCodetextBox.Location = new System.Drawing.Point(0, 77);
            this.lectureCodetextBox.Name = "lectureCodetextBox";
            this.lectureCodetextBox.Size = new System.Drawing.Size(106, 22);
            this.lectureCodetextBox.TabIndex = 1;
            // 
            // lectureCodeLabel
            // 
            this.lectureCodeLabel.AutoSize = true;
            this.lectureCodeLabel.Location = new System.Drawing.Point(-3, 54);
            this.lectureCodeLabel.Name = "lectureCodeLabel";
            this.lectureCodeLabel.Size = new System.Drawing.Size(93, 17);
            this.lectureCodeLabel.TabIndex = 0;
            this.lectureCodeLabel.Text = "Lecture Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1053, 719);
            this.Controls.Add(this.addLectureGroupBox);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.postGraduateDepartmentLabel);
            this.Controls.Add(this.postGraduateDepartmentTextBox);
            this.Controls.Add(this.bachelorDepartmentLabel);
            this.Controls.Add(this.bachelorDepartmentTextBox);
            this.Controls.Add(this.postGraduateUniversityLabel);
            this.Controls.Add(this.postGraduateUniversityTextBox);
            this.Controls.Add(this.bachelorUniversityLabel);
            this.Controls.Add(this.bachelorUniversityTextBox);
            this.Controls.Add(this.educationStateLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addStudentButton);
            this.Name = "Form1";
            this.Text = "Student Information System";
            this.addLectureGroupBox.ResumeLayout(false);
            this.addLectureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label educationStateLabel;
        private System.Windows.Forms.Label postGraduateUniversityLabel;
        private System.Windows.Forms.TextBox postGraduateUniversityTextBox;
        private System.Windows.Forms.Label bachelorUniversityLabel;
        private System.Windows.Forms.TextBox bachelorUniversityTextBox;
        private System.Windows.Forms.Label bachelorDepartmentLabel;
        private System.Windows.Forms.TextBox bachelorDepartmentTextBox;
        private System.Windows.Forms.Label postGraduateDepartmentLabel;
        private System.Windows.Forms.TextBox postGraduateDepartmentTextBox;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.GroupBox addLectureGroupBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox ectsCreditTextBox;
        private System.Windows.Forms.Label ectsCreditLabel;
        private System.Windows.Forms.TextBox lectureNametextBox;
        private System.Windows.Forms.Label lectureNameLabel;
        private System.Windows.Forms.TextBox lectureCodetextBox;
        private System.Windows.Forms.Label lectureCodeLabel;
        private System.Windows.Forms.Button addLectureButton;
    }
}

