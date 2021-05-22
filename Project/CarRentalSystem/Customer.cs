using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CarRentalSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SCUS1E8;Initial Catalog=CarRental;Integrated Security=True");
        public int Number;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetCustomersRecord();
        }

        private void GetCustomersRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from CustomerInfo", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CustomerRecordDataGridView.DataSource = dt;
            CustomerRecordDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerInfo Values(@CustID, @CustName, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Customer is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCustomersRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (txtCustID.Text == string.Empty)
            {
                MessageBox.Show("Customer ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCustID.Clear();
            txtCustName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();

            txtCustID.Focus();
        }

        private void CustomerRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Number = Convert.ToInt32(CustomerRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtCustID.Text = CustomerRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtCustName.Text = CustomerRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = CustomerRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtMobile.Text = CustomerRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE CustomerInfo SET CustID = @CustID, CustName = @CustName, Address = @Address, Mobile = @Mobile WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Information is successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCustomersRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a customer to update his/her information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerInfo WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCustomersRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a customer to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
