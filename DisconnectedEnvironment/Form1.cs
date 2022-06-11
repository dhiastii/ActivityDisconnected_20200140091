using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisconnectedEnvironment
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                DataTable dt;
                DataRow dr;
                string Code;

                Code = txtCode.Text;

            }

            private void Form1_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
                this.empdetailsTableAdapter.Fill(this.hRDataSet.empdetails);
                DataTable dt;
                DataRow dr;
                string Code;

                // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
                //This line of code loads data into the hRDataSet.Empdetails table. this would appear in form 1 load event
                txtCode.Enabled = false;
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                txtState.Enabled = false;
                txtCountry.Enabled = false;
                cbDesignation.Enabled = false;
                cbDepartment.Enabled = false;
                cbDesignation.Items.Add("MANAGER");
                cbDesignation.Items.Add("AUTHOR");
                cbDesignation.Items.Add("DESIGNER");
                cbDepartment.Items.Add("MARKETING");
                cbDepartment.Items.Add("FINANCE");
                cbDepartment.Items.Add("IDD");
                cmdSave.Enabled = false;
            }

            //private void cmdAdd_Click(object sender, EventArgs e)
            //{
            //    DataTable dt;
            //    DataRow dr;
            //    string Code;

            //    cmdSave.Enabled = true;
            //    txtName.Enabled = true;
            //    txtAddress.Enabled = true;
            //    txtState.Enabled = true;
            //    txtCountry.Enabled = true;
            //    cbDesignation.Enabled = true;
            //    cbDepartment.Enabled = true;
            //    txtName.Text = "";
            //    txtAddress.Text = "";
            //    txtState.Text = "";
            //    txtCountry.Text = "";
            //    cbDesignation.Text = "";
            //    cbDepartment.Text = "";
            //    int ctr, len;
            //    string codeval;
            //    len = dt.Rows.Count;
            //    dr = dt.Rows[len];
            //    Code = dr["ccode"].ToString();
            //    codeval = Code.Substring(1, 3);
            //    ctr = Convert.ToInt32(codeval);
            //    if ((ctr >= 0) && (ctr < 9))
            //    {
            //        ctr = ctr + 1;
            //        txtCode.Text = "C00" + ctr;
            //    }
            //    else if ((ctr >= 9) && (ctr < 99))
            //    {
            //        ctr = ctr + 1;
            //        txtCode.Text = "C0" + ctr;
            //    }
            //    else if (ctr >= 99)
            //    {
            //        ctr = ctr + 1;
            //        txtCode.Text = "C" + ctr;
            //    }
            //    cmdAdd.Enabled = false;
            //}

            //private void cmdSave_Click(object sender, EventArgs e)
            //{
            //    DataTable dt;
            //    DataRow dr;
            //    string Code;
            //    dr = dt.NewRow();
            //    dr[0] = txtCode.Text;
            //    dr[1] = txtName.Text;
            //    dr[2] = txtAddress.Text;
            //    dr[3] = txtState.Text;
            //    dr[4] = txtCountry.Text;
            //    dr[5] = cbDesignation.SelectedItem;
            //    dr[6] = cbDepartment.SelectedItem;
            //    dt.Rows.Add(dr);
            //    txtCode.Text = System.Convert.ToString(dr[0]);
            //    txtCode.Enabled = false;
            //    txtName.Enabled = false;
            //    txtAddress.Enabled = false;
            //    txtState.Enabled = false;
            //    txtCountry.Enabled = false;
            //    cbDesignation.Enabled = false;
            //    cbDepartment.Enabled = false;
            //    cmdAdd.Enabled = true;
            //    cmdSave.Enabled = false;
            //}

    }
}