using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CarRentalSystem
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SCUS1E8;Initial Catalog=CarRental;Integrated Security=True");
        public int Number;

        private void FillCarRegNo()
        {
            con.Open();
            string query = "Select RegNo from CarRegistration where Available = '"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNo", typeof(string));
            dt.Load(sdr);
            txtCarRegNo.ValueMember = "RegNo";
            txtCarRegNo.DataSource = dt;

            con.Close();
        }

        private void FillCustID()
        {
            con.Open();
            string query = "Select CustID from CustomerInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustID", typeof(string));
            dt.Load(sdr);
            txtCustID.ValueMember = "CustID";
            txtCustID.DataSource = dt;

            con.Close();
        }

        public void FetchCustName()
        {
            con.Open();
            string query = "Select * from CustomerInfo where CustID = "+ txtCustID.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtCustName.Text = dr["CustName"].ToString();
            }
            con.Close();
        }

        public void UpdateOnRent()
        {
            string query = "UPDATE CarRegistration SET Available = '" + "No" + "' WHERE RegNo = '" + txtCarRegNo.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            GetCarRentRecord();
        }

        private void GetCarRentRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Rental", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CarRentDataGridView.DataSource = dt;
            CarRentDataGridView.Columns[0].Visible = false;
            FillCarRegNo();
            FillCustID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Rental Values(@RegNo,@CustID, @CustName, @RentalFee, @RentalDate, @ReturnDate)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@RegNo", txtCarRegNo.Text);
                cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@RentalFee", txtRentalFee.Text);
                cmd.Parameters.AddWithValue("@RentalDate", Convert.ToDateTime(RentalDateTimePicker.Text));
                cmd.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(ReturnDateTimePicker.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Car rent is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCarRentRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (txtCarRegNo.Text == string.Empty)
            {
                MessageBox.Show("Car Registration No is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CarRentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Number = Convert.ToInt32(CarRentDataGridView.SelectedRows[0].Cells[0].Value);
            txtCarRegNo.Text = CarRentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtCustID.Text = CarRentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtCustName.Text = CarRentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtRentalFee.Text = CarRentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            RentalDateTimePicker.Text = CarRentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            ReturnDateTimePicker.Text = CarRentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Rental WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Car rental info is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCarRentRecord();
                ResetFormControls();
                
            }
            else
            {
                MessageBox.Show("Please select a car reg no to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            Number = 0;
            txtCustName.Clear();
            txtCustName.Clear();
            txtRentalFee.Clear();

            txtCarRegNo.Focus();
        }

        private void txtCarRegNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateOnRent();
        }

        private void txtCustID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCustName();
        }
    }
}
