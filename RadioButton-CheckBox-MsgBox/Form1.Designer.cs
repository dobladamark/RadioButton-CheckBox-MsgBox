namespace RadioButton_CheckBox_MsgBox
{
    partial class Form1
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
            this.btnGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.rbBSIT = new System.Windows.Forms.RadioButton();
            this.rbBSIS = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdOthers = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.tdMale = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBask = new System.Windows.Forms.CheckBox();
            this.cbRunning = new System.Windows.Forms.CheckBox();
            this.cbSwimming = new System.Windows.Forms.CheckBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbRep = new System.Windows.Forms.GroupBox();
            this.txtGenRep = new System.Windows.Forms.TextBox();
            this.txtCourseRep = new System.Windows.Forms.TextBox();
            this.rtbHob = new System.Windows.Forms.RichTextBox();
            this.lblHobRep = new System.Windows.Forms.Label();
            this.lblGenderRep = new System.Windows.Forms.Label();
            this.txtContRep = new System.Windows.Forms.TextBox();
            this.lblCourseRep = new System.Windows.Forms.Label();
            this.lblContRep = new System.Windows.Forms.Label();
            this.lblNameRep = new System.Windows.Forms.Label();
            this.txtNameRep = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnClearRep = new System.Windows.Forms.Button();
            this.gbCourse.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(279, 511);
            this.btnGen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(125, 23);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "GENERATE";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RadioButton_CheckBox_MSGBox";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(183, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(230, 92);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(200, 20);
            this.txtCont.TabIndex = 5;
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.rbBSIT);
            this.gbCourse.Controls.Add(this.rbBSIS);
            this.gbCourse.Location = new System.Drawing.Point(186, 147);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(309, 100);
            this.gbCourse.TabIndex = 6;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "COURSE";
            // 
            // rbBSIT
            // 
            this.rbBSIT.AutoSize = true;
            this.rbBSIT.Location = new System.Drawing.Point(44, 46);
            this.rbBSIT.Name = "rbBSIT";
            this.rbBSIT.Size = new System.Drawing.Size(49, 17);
            this.rbBSIT.TabIndex = 9;
            this.rbBSIT.TabStop = true;
            this.rbBSIT.Text = "BSIT";
            this.rbBSIT.UseVisualStyleBackColor = true;
            this.rbBSIT.CheckedChanged += new System.EventHandler(this.rbBSIT_CheckedChanged);
            // 
            // rbBSIS
            // 
            this.rbBSIS.AutoSize = true;
            this.rbBSIS.Location = new System.Drawing.Point(169, 46);
            this.rbBSIS.Name = "rbBSIS";
            this.rbBSIS.Size = new System.Drawing.Size(49, 17);
            this.rbBSIS.TabIndex = 10;
            this.rbBSIS.TabStop = true;
            this.rbBSIS.Text = "BSIS";
            this.rbBSIS.UseVisualStyleBackColor = true;
            this.rbBSIS.CheckedChanged += new System.EventHandler(this.rbBSIS_CheckedChanged);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdOthers);
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.tdMale);
            this.gbGender.Location = new System.Drawing.Point(186, 267);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(338, 100);
            this.gbGender.TabIndex = 7;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "GENDER";
            // 
            // rdOthers
            // 
            this.rdOthers.AutoSize = true;
            this.rdOthers.Location = new System.Drawing.Point(247, 50);
            this.rdOthers.Name = "rdOthers";
            this.rdOthers.Size = new System.Drawing.Size(70, 17);
            this.rdOthers.TabIndex = 11;
            this.rdOthers.TabStop = true;
            this.rdOthers.Text = "OTHERS";
            this.rdOthers.UseVisualStyleBackColor = true;
            this.rdOthers.CheckedChanged += new System.EventHandler(this.rdOthers_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(125, 50);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(67, 17);
            this.rdFemale.TabIndex = 13;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "FEMALE";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // tdMale
            // 
            this.tdMale.AutoSize = true;
            this.tdMale.Location = new System.Drawing.Point(6, 50);
            this.tdMale.Name = "tdMale";
            this.tdMale.Size = new System.Drawing.Size(53, 18);
            this.tdMale.TabIndex = 12;
            this.tdMale.TabStop = true;
            this.tdMale.Text = "MALE";
            this.tdMale.UseCompatibleTextRendering = true;
            this.tdMale.UseVisualStyleBackColor = true;
            this.tdMale.CheckedChanged += new System.EventHandler(this.tdMale_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBask);
            this.groupBox3.Controls.Add(this.cbRunning);
            this.groupBox3.Controls.Add(this.cbSwimming);
            this.groupBox3.Location = new System.Drawing.Point(186, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 105);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HOBBIES";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbBask
            // 
            this.cbBask.AutoSize = true;
            this.cbBask.Location = new System.Drawing.Point(209, 50);
            this.cbBask.Name = "cbBask";
            this.cbBask.Size = new System.Drawing.Size(94, 17);
            this.cbBask.TabIndex = 11;
            this.cbBask.Text = "BASKETBALL";
            this.cbBask.UseVisualStyleBackColor = true;
            // 
            // cbRunning
            // 
            this.cbRunning.AutoSize = true;
            this.cbRunning.Location = new System.Drawing.Point(6, 50);
            this.cbRunning.Name = "cbRunning";
            this.cbRunning.Size = new System.Drawing.Size(77, 17);
            this.cbRunning.TabIndex = 9;
            this.cbRunning.Text = "RUNNING";
            this.cbRunning.UseVisualStyleBackColor = true;
            // 
            // cbSwimming
            // 
            this.cbSwimming.AutoSize = true;
            this.cbSwimming.Location = new System.Drawing.Point(108, 50);
            this.cbSwimming.Name = "cbSwimming";
            this.cbSwimming.Size = new System.Drawing.Size(84, 17);
            this.cbSwimming.TabIndex = 10;
            this.cbSwimming.Text = "SWIMMING";
            this.cbSwimming.UseVisualStyleBackColor = true;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(183, 99);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(44, 13);
            this.lblCont.TabIndex = 10;
            this.lblCont.Text = "Contact";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbRep
            // 
            this.gbRep.Controls.Add(this.txtGenRep);
            this.gbRep.Controls.Add(this.txtCourseRep);
            this.gbRep.Controls.Add(this.rtbHob);
            this.gbRep.Controls.Add(this.lblHobRep);
            this.gbRep.Controls.Add(this.lblGenderRep);
            this.gbRep.Controls.Add(this.txtContRep);
            this.gbRep.Controls.Add(this.lblCourseRep);
            this.gbRep.Controls.Add(this.lblContRep);
            this.gbRep.Controls.Add(this.lblNameRep);
            this.gbRep.Controls.Add(this.txtNameRep);
            this.gbRep.Location = new System.Drawing.Point(930, 69);
            this.gbRep.Name = "gbRep";
            this.gbRep.Size = new System.Drawing.Size(408, 358);
            this.gbRep.TabIndex = 11;
            this.gbRep.TabStop = false;
            this.gbRep.Text = "REPORT";
            // 
            // txtGenRep
            // 
            this.txtGenRep.Location = new System.Drawing.Point(125, 158);
            this.txtGenRep.Name = "txtGenRep";
            this.txtGenRep.Size = new System.Drawing.Size(200, 20);
            this.txtGenRep.TabIndex = 17;
            this.txtGenRep.TextChanged += new System.EventHandler(this.txtGenRep_TextChanged);
            // 
            // txtCourseRep
            // 
            this.txtCourseRep.Location = new System.Drawing.Point(125, 127);
            this.txtCourseRep.Name = "txtCourseRep";
            this.txtCourseRep.Size = new System.Drawing.Size(200, 20);
            this.txtCourseRep.TabIndex = 16;
            this.txtCourseRep.TextChanged += new System.EventHandler(this.txtCourseRep_TextChanged);
            // 
            // rtbHob
            // 
            this.rtbHob.Location = new System.Drawing.Point(125, 217);
            this.rtbHob.Name = "rtbHob";
            this.rtbHob.Size = new System.Drawing.Size(166, 113);
            this.rtbHob.TabIndex = 15;
            this.rtbHob.Text = "";
            this.rtbHob.TextChanged += new System.EventHandler(this.rtbHob_TextChanged);
            // 
            // lblHobRep
            // 
            this.lblHobRep.AutoSize = true;
            this.lblHobRep.Location = new System.Drawing.Point(40, 217);
            this.lblHobRep.Name = "lblHobRep";
            this.lblHobRep.Size = new System.Drawing.Size(46, 13);
            this.lblHobRep.TabIndex = 14;
            this.lblHobRep.Text = "Hobbies";
            // 
            // lblGenderRep
            // 
            this.lblGenderRep.AutoSize = true;
            this.lblGenderRep.Location = new System.Drawing.Point(40, 165);
            this.lblGenderRep.Name = "lblGenderRep";
            this.lblGenderRep.Size = new System.Drawing.Size(42, 13);
            this.lblGenderRep.TabIndex = 13;
            this.lblGenderRep.Text = "Gender";
            // 
            // txtContRep
            // 
            this.txtContRep.Location = new System.Drawing.Point(125, 98);
            this.txtContRep.Name = "txtContRep";
            this.txtContRep.Size = new System.Drawing.Size(200, 20);
            this.txtContRep.TabIndex = 12;
            // 
            // lblCourseRep
            // 
            this.lblCourseRep.AutoSize = true;
            this.lblCourseRep.Location = new System.Drawing.Point(40, 134);
            this.lblCourseRep.Name = "lblCourseRep";
            this.lblCourseRep.Size = new System.Drawing.Size(40, 13);
            this.lblCourseRep.TabIndex = 12;
            this.lblCourseRep.Text = "Course";
            // 
            // lblContRep
            // 
            this.lblContRep.AutoSize = true;
            this.lblContRep.Location = new System.Drawing.Point(40, 105);
            this.lblContRep.Name = "lblContRep";
            this.lblContRep.Size = new System.Drawing.Size(44, 13);
            this.lblContRep.TabIndex = 12;
            this.lblContRep.Text = "Contact";
            // 
            // lblNameRep
            // 
            this.lblNameRep.AutoSize = true;
            this.lblNameRep.Location = new System.Drawing.Point(40, 72);
            this.lblNameRep.Name = "lblNameRep";
            this.lblNameRep.Size = new System.Drawing.Size(38, 13);
            this.lblNameRep.TabIndex = 12;
            this.lblNameRep.Text = "Name:";
            // 
            // txtNameRep
            // 
            this.txtNameRep.Location = new System.Drawing.Point(125, 65);
            this.txtNameRep.Name = "txtNameRep";
            this.txtNameRep.Size = new System.Drawing.Size(200, 20);
            this.txtNameRep.TabIndex = 12;
            this.txtNameRep.TextChanged += new System.EventHandler(this.txtNameRep_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 541);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(1085, 441);
            this.btnGenRep.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(125, 23);
            this.btnGenRep.TabIndex = 13;
            this.btnGenRep.Text = "GENERATE REPORT";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // btnClearRep
            // 
            this.btnClearRep.Location = new System.Drawing.Point(1085, 487);
            this.btnClearRep.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearRep.Name = "btnClearRep";
            this.btnClearRep.Size = new System.Drawing.Size(125, 23);
            this.btnClearRep.TabIndex = 14;
            this.btnClearRep.Text = "CLEAR";
            this.btnClearRep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 575);
            this.Controls.Add(this.btnClearRep);
            this.Controls.Add(this.btnGenRep);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbRep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbCourse);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbRep.ResumeLayout(false);
            this.gbRep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.GroupBox gbCourse;
        private System.Windows.Forms.RadioButton rbBSIT;
        private System.Windows.Forms.RadioButton rbBSIS;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdOthers;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton tdMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbBask;
        private System.Windows.Forms.CheckBox cbRunning;
        private System.Windows.Forms.CheckBox cbSwimming;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbRep;
        private System.Windows.Forms.RichTextBox rtbHob;
        private System.Windows.Forms.Label lblHobRep;
        private System.Windows.Forms.Label lblGenderRep;
        private System.Windows.Forms.TextBox txtContRep;
        private System.Windows.Forms.Label lblCourseRep;
        private System.Windows.Forms.Label lblContRep;
        private System.Windows.Forms.Label lblNameRep;
        private System.Windows.Forms.TextBox txtNameRep;
        private System.Windows.Forms.TextBox txtGenRep;
        private System.Windows.Forms.TextBox txtCourseRep;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnClearRep;
    }
}

