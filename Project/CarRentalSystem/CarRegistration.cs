using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CarRentalSystem
{
    public partial class CarRegistration : Form
    {
        public CarRegistration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SCUS1E8;Initial Catalog=CarRental;Integrated Security=True");
        public int Number;

        private void CarRegistration_Load(object sender, EventArgs e)
        {
            GetCarsRecord();
        }

        private void GetCarsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from CarRegistration",con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CarRecordDataGridView.DataSource = dt;
            CarRecordDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CarRegistration Values(@RegNo,@Make, @Model, @Available)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@RegNo", txtCarRegNo.Text);
                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Available", txtAvailable.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New car is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCarsRecord();
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

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            Number = 0;
            txtCarRegNo.Clear();
            txtMake.Clear();
            txtModel.Clear();

            txtCarRegNo.Focus();
        }

        private void CarRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Number = Convert.ToInt32(CarRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtCarRegNo.Text = CarRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtMake.Text = CarRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtModel.Text = CarRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAvailable.Text = CarRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Number>0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE CarRegistration SET RegNo = @RegNo, Make = @Make, Model = @Model, Available = @Available WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@RegNo", txtCarRegNo.Text);
                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Available", txtAvailable.Text);
                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Car information is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCarsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a car to update it's information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Number>0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM CarRegistration WHERE Number = @Number", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Number", this.Number);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Car is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCarsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a car to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
