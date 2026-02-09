using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RadioButton_CheckBox_MsgBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            btnGen.Enabled = true;
            gbRep.Visible = true;
            btnGenRep.Visible = true;
            btnClearRep.Visible = true;
        }

       

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            txtNameRep.Text = txtName.Text;
            txtContRep.Text = txtCont.Text;

            if (rbBSIT.Checked)
            {
                txtCourseRep.Text = rbBSIT.Text;
            }

            if (rbBSIS.Checked)
            {
                txtCourseRep.Text = rbBSIS.Text;
            }

            if (rdOthers.Checked)
            {
                txtGenRep.Text = rdOthers.Text;
            }

            if (tdMale.Checked)
            {
                txtGenRep.Text = tdMale.Text;
            }

            if (rdFemale.Checked)
            {
                txtGenRep.Text = rdFemale.Text;
            }

            string hobbies = "";
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)ctrl;

                    if (cb.Checked)
                    {
                        rtbHob.Text = hobbies += cb.Text + "\n";

                    }
                }
            }

        }

        private void txtNameRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbBSIT_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void rbBSIS_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtCourseRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdOthers_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtGenRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdMale_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rtbHob_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCont.Clear();
            rbBSIT.Checked = false;
            rbBSIS.Checked = false;
            tdMale.Checked = false;
            rdFemale.Checked = false;
            rdOthers.Checked = false;
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)ctrl;

                    if (cb.Checked)
                    {
                        cb.Checked = false;
                    }
                }
            }

            txtNameRep.Clear();
            txtContRep.Clear();
            txtCourseRep.Clear();
            txtGenRep.Clear();
            rtbHob.Clear();
            gbRep.Visible = false;
            btnGenRep.Visible = false;
            btnClearRep.Visible = false;
            txtName.Focus();



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();



        }

        private void gbCourse_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGen.Enabled = false;
            gbRep.Visible = false;
            btnGenRep.Visible = false;
            btnClearRep.Visible = false;
        }

        private void txtCont_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool textValid =
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtCont.Text);

            bool checkBoxValid = cbRunning.Checked || cbBask.Checked || cbSwimming.Checked;

            bool radioValid = rbBSIS.Checked || rbBSIT.Checked || tdMale.Checked || rdFemale.Checked || rdOthers.Checked;

            btnGen.Enabled = textValid &&  radioValid && checkBoxValid;
        }

        private void cbRunning_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void cbSwimming_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void cbBask_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btnClearRep_Click(object sender, EventArgs e)
        {
            txtNameRep.Clear();
            txtContRep.Clear();
            txtCourseRep.Clear();
            txtGenRep.Clear();
            rtbHob.Clear();
            

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = e.KeyChar != (char)Keys.Space && !char .IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Only letters, spaces, and periods are allowed in the Name field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gbRep_Enter(object sender, EventArgs e)
        {

        }

        private void txtCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = e.KeyChar != (char)Keys.Space && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Only numbers, spaces, and periods are allowed in the Contact field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) {
                                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
