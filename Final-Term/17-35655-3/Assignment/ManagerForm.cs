using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUS-K401U;Initial Catalog=FinalAssignment;Integrated Security=True");
        public int Number;

        private void FillName()
        {
            con.Open();
            string query = "Select FullName from INFO1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Load(sdr);
            txtFullName.ValueMember = "FullName";
            txtFullName.DataSource = dt;

            con.Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void GetRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from INFO2", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ManagerRecordDataGridView.DataSource = dt;
            ManagerRecordDataGridView.Columns[0].Visible = false;
            FillName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO INFO2 Values(@FullName, @Mobile, @Department, @DeptID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@DeptID", txtDeptID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New INFO is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRecords();
                ResetFormControls();

            }
        }

        private bool IsValid()
        {
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            Number = 0;
            txtMobile.Clear();
            txtDepartment.Clear();
            txtDeptID.Clear();

            txtFullName.Focus();
        }

        private void ManagerRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Number = Convert.ToInt32(ManagerRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtFullName.Text = ManagerRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtMobile.Text = ManagerRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtDepartment.Text = ManagerRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtDeptID.Text = ManagerRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE INFO2 SET FullName = @FullName, Mobile = @Mobile, Department = @Department, DeptID = @DeptID WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@DeptID", txtDeptID.Text);
                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("INFO is successfully updated in the database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRecords();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a name to update his/her information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Number > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE from INFO2 WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("INFO is successfully deleted from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRecords();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a name to delete his/her information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
