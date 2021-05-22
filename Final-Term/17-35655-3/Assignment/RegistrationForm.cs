using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUS-K401U;Initial Catalog=FinalAssignment;Integrated Security=True");
        string G;
        string M;
        string S;
        public int Number;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                {
                    if(txtMale.Checked == true)
                    {
                        G = "Male";
                    }
                    else if(txtFemale.Checked == true)
                    {
                        G = "Female";
                    }
                    else
                    {
                        G = "Other";
                    }
                }
                {
                    if(txtSingle.Checked == true)
                    {
                        M = "Single";
                    }
                    else if(txtMarried.Checked == true)
                    {
                        M = "Married";
                    }
                    else
                    {
                        M = "Divorced";
                    }
                }
                {
                    if(txtC.Checked == true)
                    {
                        S = "C";
                    }
                    else if(txtJava.Checked == true)
                    {
                        S = "Java";
                    }
                    else if(txtPython.Checked == true)
                    {
                        S = "Python";
                    }
                    else
                    {
                        S = "C Sharp";
                    }
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO INFO1 Values(@FullName, @DOB, @Gender, @MaritalStatus, @Address, @City, @Skills, @Designation, @Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtDOB.Text));
                cmd.Parameters.AddWithValue("@Gender", this.G);
                cmd.Parameters.AddWithValue("@MaritalStatus", this.M);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Skills", this.S);
                cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Info is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }

        private bool IsValid()
        {
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return false;
            }
            return true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
