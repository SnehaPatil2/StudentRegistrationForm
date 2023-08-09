using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentForm
{
    public partial class Form2 : Form
    {

        string conectionString = "Server=SURAJ-PATIL-928;Initial Catalog=student;Integrated Security=True";

        private DataRow dataRow;
        private SqlConnection connection;
        private Dictionary<int, bool> checkboxStates = new Dictionary<int, bool>();
        public Form2(DataRow row, SqlConnection sqlConnection)
        {
            InitializeComponent();
            connection = sqlConnection;
            dataRow = row;

            // Populate input controls with data from the DataRow
            nameBox1.Text = dataRow["Name"].ToString();
            emailBox1.Text = dataRow["Email"].ToString();
            phonBox1.Text = dataRow["Phone"].ToString();
            zipBox1.Text = dataRow["Zip"].ToString();
            // Populate checkbox based on data
            //bool isActive = Convert.ToBoolean(dataRow["Hobbies"]); // Assuming "IsActive" is the column name
            bool isActive = dataRow["Hobbies"].ToString().Equals("Active", StringComparison.OrdinalIgnoreCase);


            moviecheckBox1.Checked = isActive;
            footballcheckBox1.Checked = isActive;
            swimmingcheckBox1.Checked = isActive;
            musiccheckBox1.Checked = isActive;

            //hobbiesBox = dataRow["Hobbies"].ToString();
        }

        public SqlConnection sqlConnection { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void phonBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {





            string updatedName = nameBox1.Text;
            string updatedEmail = phonBox1.Text;
            string updatedPhone = emailBox1.Text;

            string updatedZip = zipBox1.Text;
            // Get checkbox state
            bool updatedIsMovie = moviecheckBox1.Checked;
            bool updatedIsFootball = footballcheckBox1.Checked;
            bool updatedIsSwimming = swimmingcheckBox1.Checked;
            bool updatedIsMusic = musiccheckBox1.Checked;

            // string updatedHobbies = updatedHobbies;

            //        if (string.IsNullOrWhiteSpace(nameBox1.Text) || string.IsNullOrWhiteSpace(phonBox1.Text))
            //        {
            //            MessageBox.Show("Name and Phone are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        try
            //        {
            //            using (SqlConnection connection = new SqlConnection(conectionString))
            //            {

            //                connection.Open();
            //                string sql1 = "UPDATE StudentDetails SET Name = @updatedName,Email=@updatedEmail, Phone = @updatedPhone,Zip=@updatedZip ";

            //                using (SqlCommand command = new SqlCommand(sql1, connection))
            //                {
            //                    command.Parameters.AddWithValue("@updatedName", updatedName);
            //                    command.Parameters.AddWithValue("@updatedEmail", updatedEmail);
            //                    command.Parameters.AddWithValue("@updatedPhone", updatedPhone);
            //                    command.Parameters.AddWithValue("@updatedZip", updatedZip);
            //                    command.Parameters.AddWithValue("@updatedIsMovie", updatedIsMovie);
            //                    command.Parameters.AddWithValue("@updatedIsFootball", updatedIsFootball);
            //                    command.Parameters.AddWithValue("@updatedIsSwimming", updatedIsSwimming);
            //                    command.Parameters.AddWithValue("@updatedIsMusic", updatedIsMusic);



            //                    int rowsAffected = command.ExecuteNonQuery();
            //                    connection.Close();

            //                    if (rowsAffected > 0)
            //                    {
            //                        MessageBox.Show("Data updated successfully!");
            //                        DialogResult = DialogResult.OK;
            //                        Close();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("No records were updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            



        }
    }


}        
