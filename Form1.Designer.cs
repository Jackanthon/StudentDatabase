
namespace Day1Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.cboxGenderS = new System.Windows.Forms.ComboBox();
            this.cboxYearS = new System.Windows.Forms.ComboBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.labelGenderS = new System.Windows.Forms.Label();
            this.lblYearS = new System.Windows.Forms.Label();
            this.lblLastN = new System.Windows.Forms.Label();
            this.lblFirstN = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.groupStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okemos High School";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnView.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(46, 105);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(326, 78);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Students";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(460, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(326, 78);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemove.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(880, 105);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(326, 78);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Student";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridStudents
            // 
            this.gridStudents.BackgroundColor = System.Drawing.Color.White;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Location = new System.Drawing.Point(46, 200);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersWidth = 51;
            this.gridStudents.RowTemplate.Height = 29;
            this.gridStudents.Size = new System.Drawing.Size(740, 253);
            this.gridStudents.TabIndex = 4;
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.cboxGenderS);
            this.groupStudent.Controls.Add(this.cboxYearS);
            this.groupStudent.Controls.Add(this.txtLastN);
            this.groupStudent.Controls.Add(this.txtFirstN);
            this.groupStudent.Controls.Add(this.txtSID);
            this.groupStudent.Controls.Add(this.labelGenderS);
            this.groupStudent.Controls.Add(this.lblYearS);
            this.groupStudent.Controls.Add(this.lblLastN);
            this.groupStudent.Controls.Add(this.lblFirstN);
            this.groupStudent.Controls.Add(this.lblSID);
            this.groupStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupStudent.Location = new System.Drawing.Point(46, 481);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Size = new System.Drawing.Size(591, 269);
            this.groupStudent.TabIndex = 5;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Student Record:";
            // 
            // cboxGenderS
            // 
            this.cboxGenderS.FormattingEnabled = true;
            this.cboxGenderS.Location = new System.Drawing.Point(299, 220);
            this.cboxGenderS.Name = "cboxGenderS";
            this.cboxGenderS.Size = new System.Drawing.Size(255, 28);
            this.cboxGenderS.TabIndex = 9;
            // 
            // cboxYearS
            // 
            this.cboxYearS.FormattingEnabled = true;
            this.cboxYearS.Location = new System.Drawing.Point(300, 177);
            this.cboxYearS.Name = "cboxYearS";
            this.cboxYearS.Size = new System.Drawing.Size(255, 28);
            this.cboxYearS.TabIndex = 8;
            // 
            // txtLastN
            // 
            this.txtLastN.Location = new System.Drawing.Point(299, 132);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(256, 27);
            this.txtLastN.TabIndex = 7;
            // 
            // txtFirstN
            // 
            this.txtFirstN.Location = new System.Drawing.Point(299, 87);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(256, 27);
            this.txtFirstN.TabIndex = 6;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(299, 38);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(256, 27);
            this.txtSID.TabIndex = 5;
            // 
            // labelGenderS
            // 
            this.labelGenderS.AutoSize = true;
            this.labelGenderS.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenderS.Location = new System.Drawing.Point(28, 217);
            this.labelGenderS.Name = "labelGenderS";
            this.labelGenderS.Size = new System.Drawing.Size(178, 27);
            this.labelGenderS.TabIndex = 4;
            this.labelGenderS.Text = "Student Gender:";
            // 
            // lblYearS
            // 
            this.lblYearS.AutoSize = true;
            this.lblYearS.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearS.Location = new System.Drawing.Point(28, 174);
            this.lblYearS.Name = "lblYearS";
            this.lblYearS.Size = new System.Drawing.Size(148, 27);
            this.lblYearS.TabIndex = 3;
            this.lblYearS.Text = "Student Year:";
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastN.Location = new System.Drawing.Point(28, 129);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(125, 27);
            this.lblLastN.TabIndex = 2;
            this.lblLastN.Text = "Last Name:";
            // 
            // lblFirstN
            // 
            this.lblFirstN.AutoSize = true;
            this.lblFirstN.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstN.Location = new System.Drawing.Point(28, 84);
            this.lblFirstN.Name = "lblFirstN";
            this.lblFirstN.Size = new System.Drawing.Size(127, 27);
            this.lblFirstN.TabIndex = 1;
            this.lblFirstN.Text = "First Name:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSID.Location = new System.Drawing.Point(28, 38);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(125, 27);
            this.lblSID.TabIndex = 0;
            this.lblSID.Text = "Student ID:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(880, 647);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(326, 78);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.Image = ((System.Drawing.Image)(resources.GetObject("picSchoolLogo.Image")));
            this.picSchoolLogo.Location = new System.Drawing.Point(880, 200);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(325, 252);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSchoolLogo.TabIndex = 7;
            this.picSchoolLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 791);
            this.Controls.Add(this.picSchoolLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.GroupBox groupStudent;
        private System.Windows.Forms.Label labelGenderS;
        private System.Windows.Forms.Label lblYearS;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.Label lblFirstN;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.ComboBox cboxGenderS;
        private System.Windows.Forms.ComboBox cboxYearS;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picSchoolLogo;
    }
}

