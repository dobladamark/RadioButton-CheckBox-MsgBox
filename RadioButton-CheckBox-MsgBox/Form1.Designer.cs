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
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCourse.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.Cyan;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGen.Location = new System.Drawing.Point(334, 637);
            this.btnGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(197, 47);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "GENERATE";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(215, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "RadioButton_CheckBox_MSGBox";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(201, 82);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 26);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(327, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 33);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtCont
            // 
            this.txtCont.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCont.Location = new System.Drawing.Point(327, 133);
            this.txtCont.Margin = new System.Windows.Forms.Padding(4);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(265, 33);
            this.txtCont.TabIndex = 5;
            this.txtCont.TextChanged += new System.EventHandler(this.txtCont_TextChanged);
            this.txtCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCont_KeyPress);
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.rbBSIT);
            this.gbCourse.Controls.Add(this.rbBSIS);
            this.gbCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCourse.Location = new System.Drawing.Point(198, 181);
            this.gbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Padding = new System.Windows.Forms.Padding(4);
            this.gbCourse.Size = new System.Drawing.Size(475, 123);
            this.gbCourse.TabIndex = 6;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "COURSE";
            this.gbCourse.Enter += new System.EventHandler(this.gbCourse_Enter);
            // 
            // rbBSIT
            // 
            this.rbBSIT.AutoSize = true;
            this.rbBSIT.Location = new System.Drawing.Point(114, 57);
            this.rbBSIT.Margin = new System.Windows.Forms.Padding(4);
            this.rbBSIT.Name = "rbBSIT";
            this.rbBSIT.Size = new System.Drawing.Size(72, 30);
            this.rbBSIT.TabIndex = 9;
            this.rbBSIT.TabStop = true;
            this.rbBSIT.Text = "BSIT";
            this.rbBSIT.UseVisualStyleBackColor = true;
            this.rbBSIT.CheckedChanged += new System.EventHandler(this.rbBSIT_CheckedChanged);
            // 
            // rbBSIS
            // 
            this.rbBSIS.AutoSize = true;
            this.rbBSIS.Location = new System.Drawing.Point(280, 57);
            this.rbBSIS.Margin = new System.Windows.Forms.Padding(4);
            this.rbBSIS.Name = "rbBSIS";
            this.rbBSIS.Size = new System.Drawing.Size(71, 30);
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
            this.gbGender.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(198, 329);
            this.gbGender.Margin = new System.Windows.Forms.Padding(4);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(4);
            this.gbGender.Size = new System.Drawing.Size(554, 123);
            this.gbGender.TabIndex = 7;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "GENDER";
            // 
            // rdOthers
            // 
            this.rdOthers.AutoSize = true;
            this.rdOthers.Location = new System.Drawing.Point(394, 64);
            this.rdOthers.Margin = new System.Windows.Forms.Padding(4);
            this.rdOthers.Name = "rdOthers";
            this.rdOthers.Size = new System.Drawing.Size(107, 30);
            this.rdOthers.TabIndex = 11;
            this.rdOthers.TabStop = true;
            this.rdOthers.Text = "OTHERS";
            this.rdOthers.UseVisualStyleBackColor = true;
            this.rdOthers.CheckedChanged += new System.EventHandler(this.rdOthers_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(191, 65);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(105, 30);
            this.rdFemale.TabIndex = 13;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "FEMALE";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // tdMale
            // 
            this.tdMale.AutoSize = true;
            this.tdMale.Location = new System.Drawing.Point(12, 63);
            this.tdMale.Margin = new System.Windows.Forms.Padding(4);
            this.tdMale.Name = "tdMale";
            this.tdMale.Size = new System.Drawing.Size(81, 32);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(190, 480);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(562, 151);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HOBBIES";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbBask
            // 
            this.cbBask.AutoSize = true;
            this.cbBask.Location = new System.Drawing.Point(357, 62);
            this.cbBask.Margin = new System.Windows.Forms.Padding(4);
            this.cbBask.Name = "cbBask";
            this.cbBask.Size = new System.Drawing.Size(152, 30);
            this.cbBask.TabIndex = 11;
            this.cbBask.Text = "BASKETBALL";
            this.cbBask.UseVisualStyleBackColor = true;
            this.cbBask.CheckedChanged += new System.EventHandler(this.cbBask_CheckedChanged);
            // 
            // cbRunning
            // 
            this.cbRunning.AutoSize = true;
            this.cbRunning.Location = new System.Drawing.Point(8, 62);
            this.cbRunning.Margin = new System.Windows.Forms.Padding(4);
            this.cbRunning.Name = "cbRunning";
            this.cbRunning.Size = new System.Drawing.Size(126, 30);
            this.cbRunning.TabIndex = 9;
            this.cbRunning.Text = "RUNNING";
            this.cbRunning.UseVisualStyleBackColor = true;
            this.cbRunning.CheckedChanged += new System.EventHandler(this.cbRunning_CheckedChanged);
            // 
            // cbSwimming
            // 
            this.cbSwimming.AutoSize = true;
            this.cbSwimming.Location = new System.Drawing.Point(175, 62);
            this.cbSwimming.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwimming.Name = "cbSwimming";
            this.cbSwimming.Size = new System.Drawing.Size(142, 30);
            this.cbSwimming.TabIndex = 10;
            this.cbSwimming.Text = "SWIMMING";
            this.cbSwimming.UseVisualStyleBackColor = true;
            this.cbSwimming.CheckedChanged += new System.EventHandler(this.cbSwimming_CheckedChanged);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.Location = new System.Drawing.Point(201, 136);
            this.lblCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(90, 26);
            this.lblCont.TabIndex = 10;
            this.lblCont.Text = "Contact:";
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
            this.gbRep.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRep.Location = new System.Drawing.Point(849, 86);
            this.gbRep.Margin = new System.Windows.Forms.Padding(4);
            this.gbRep.Name = "gbRep";
            this.gbRep.Padding = new System.Windows.Forms.Padding(4);
            this.gbRep.Size = new System.Drawing.Size(544, 441);
            this.gbRep.TabIndex = 11;
            this.gbRep.TabStop = false;
            this.gbRep.Text = "REPORT";
            this.gbRep.Enter += new System.EventHandler(this.gbRep_Enter);
            // 
            // txtGenRep
            // 
            this.txtGenRep.Location = new System.Drawing.Point(167, 216);
            this.txtGenRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenRep.Name = "txtGenRep";
            this.txtGenRep.Size = new System.Drawing.Size(265, 33);
            this.txtGenRep.TabIndex = 17;
            this.txtGenRep.TextChanged += new System.EventHandler(this.txtGenRep_TextChanged);
            // 
            // txtCourseRep
            // 
            this.txtCourseRep.Location = new System.Drawing.Point(167, 173);
            this.txtCourseRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseRep.Name = "txtCourseRep";
            this.txtCourseRep.Size = new System.Drawing.Size(265, 33);
            this.txtCourseRep.TabIndex = 16;
            this.txtCourseRep.TextChanged += new System.EventHandler(this.txtCourseRep_TextChanged);
            // 
            // rtbHob
            // 
            this.rtbHob.Location = new System.Drawing.Point(167, 267);
            this.rtbHob.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHob.Name = "rtbHob";
            this.rtbHob.Size = new System.Drawing.Size(265, 138);
            this.rtbHob.TabIndex = 15;
            this.rtbHob.Text = "";
            this.rtbHob.TextChanged += new System.EventHandler(this.rtbHob_TextChanged);
            // 
            // lblHobRep
            // 
            this.lblHobRep.AutoSize = true;
            this.lblHobRep.Location = new System.Drawing.Point(35, 267);
            this.lblHobRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHobRep.Name = "lblHobRep";
            this.lblHobRep.Size = new System.Drawing.Size(94, 26);
            this.lblHobRep.TabIndex = 14;
            this.lblHobRep.Text = "Hobbies:";
            // 
            // lblGenderRep
            // 
            this.lblGenderRep.AutoSize = true;
            this.lblGenderRep.Location = new System.Drawing.Point(35, 223);
            this.lblGenderRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderRep.Name = "lblGenderRep";
            this.lblGenderRep.Size = new System.Drawing.Size(85, 26);
            this.lblGenderRep.TabIndex = 13;
            this.lblGenderRep.Text = "Gender:";
            // 
            // txtContRep
            // 
            this.txtContRep.Location = new System.Drawing.Point(167, 132);
            this.txtContRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtContRep.Name = "txtContRep";
            this.txtContRep.Size = new System.Drawing.Size(265, 33);
            this.txtContRep.TabIndex = 12;
            // 
            // lblCourseRep
            // 
            this.lblCourseRep.AutoSize = true;
            this.lblCourseRep.Location = new System.Drawing.Point(35, 180);
            this.lblCourseRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseRep.Name = "lblCourseRep";
            this.lblCourseRep.Size = new System.Drawing.Size(81, 26);
            this.lblCourseRep.TabIndex = 12;
            this.lblCourseRep.Text = "Course:";
            // 
            // lblContRep
            // 
            this.lblContRep.AutoSize = true;
            this.lblContRep.Location = new System.Drawing.Point(35, 139);
            this.lblContRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContRep.Name = "lblContRep";
            this.lblContRep.Size = new System.Drawing.Size(90, 26);
            this.lblContRep.TabIndex = 12;
            this.lblContRep.Text = "Contact:";
            // 
            // lblNameRep
            // 
            this.lblNameRep.AutoSize = true;
            this.lblNameRep.Location = new System.Drawing.Point(35, 95);
            this.lblNameRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameRep.Name = "lblNameRep";
            this.lblNameRep.Size = new System.Drawing.Size(73, 26);
            this.lblNameRep.TabIndex = 12;
            this.lblNameRep.Text = "Name:";
            // 
            // txtNameRep
            // 
            this.txtNameRep.Location = new System.Drawing.Point(167, 89);
            this.txtNameRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameRep.Name = "txtNameRep";
            this.txtNameRep.Size = new System.Drawing.Size(265, 33);
            this.txtNameRep.TabIndex = 12;
            this.txtNameRep.TextChanged += new System.EventHandler(this.txtNameRep_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnClear.Location = new System.Drawing.Point(334, 688);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 47);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenRep
            // 
            this.btnGenRep.BackColor = System.Drawing.Color.Aqua;
            this.btnGenRep.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenRep.Location = new System.Drawing.Point(1011, 533);
            this.btnGenRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(234, 47);
            this.btnGenRep.TabIndex = 13;
            this.btnGenRep.Text = "GENERATE REPORT";
            this.btnGenRep.UseVisualStyleBackColor = false;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // btnClearRep
            // 
            this.btnClearRep.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClearRep.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearRep.Location = new System.Drawing.Point(1031, 586);
            this.btnClearRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearRep.Name = "btnClearRep";
            this.btnClearRep.Size = new System.Drawing.Size(197, 45);
            this.btnClearRep.TabIndex = 14;
            this.btnClearRep.Text = "CLEAR";
            this.btnClearRep.UseVisualStyleBackColor = false;
            this.btnClearRep.Click += new System.EventHandler(this.btnClearRep_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(1272, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1453, 771);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearRep);
            this.Controls.Add(this.btnGenRep);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbRep);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbCourse);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnExit;
    }
}

