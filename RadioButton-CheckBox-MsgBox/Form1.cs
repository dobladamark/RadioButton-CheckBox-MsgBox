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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

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
                    System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox) ctrl;

                    if (cb.Checked)
                    {
                        rtbHob.Text =  hobbies += cb.Text + ", ";

                    }
                }
            }

        }

        private void txtNameRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbBSIT_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void rbBSIS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCourseRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdOthers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtGenRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rtbHob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
