using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        string conectionString = "Server=SURAJ-PATIL-928;Initial Catalog=student;Integrated Security=True";
        private object hobbiesBox;
        string txt1 = "";
        string txt2 = "";
        string txt3 = "";
        string txt4 = "";
        //using(SqlConnection connection = new SqlConnection(conectionString)){

        //}
        private List<string> selectedData = new List<string>();
        //private int selectedRowIndex;
        public Form1()
        {
            InitializeComponent();
            //selectedRowIndex = selectedIndex;
            //db=new DbConnection();
        }
        
        private void NAME_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (musiccheckBox.Checked == true)
            {
                txt4 = musiccheckBox.Text;
            }
            else
            {
                txt4 = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                connection.Open();
                string sql1 = "select * from StudentDetails";
                using (SqlCommand command = new SqlCommand(sql1, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                dataGrid.DataSource = dt;
            }
            // db.fillDataGridView("select * from student", dataGrid);
        }

        private void moviecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moviecheckBox.Checked == true)
            {
                txt1 = moviecheckBox.Text;
            }
            else {
                txt1 = "";
            }
        }

        public void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void Addbtn_Click(object sender, EventArgs e)

        {
            string mobileNumber = phonBox.Text;
            string emails = emailBox.Text.Trim();
            string zipcodePattern = @"^\d{5}(?:-\d{4})?$"; // Zipcode pattern: 12345 or 12345-6789
            
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("enter the name");
            }
            else if (string.IsNullOrWhiteSpace(emailBox.Text)) { MessageBox.Show("enter the email"); }
            else if (string.IsNullOrWhiteSpace(phonBox.Text)) { MessageBox.Show("enter the phon number"); }
            else if (string.IsNullOrWhiteSpace(zipBox.Text)) { MessageBox.Show("enter the zip number"); }
            // else if (string.IsNullOrWhiteSpace((string)hobbiesBox)) { MessageBox.Show("enter the zip number"); }
           
            else if (!IsEmailValid(emails))
            {
                // Email is valid, perform further actions
                MessageBox.Show("Email is not valid!");
            }
            else if(!IsValidMobileNumber(mobileNumber))
            {
                MessageBox.Show("Invalid mobile number format. Please enter a valid mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phonBox.Focus();
            }
            else if (!Regex.IsMatch(zipBox.Text, zipcodePattern))
            {
                MessageBox.Show("Invalid zipcode entered. Please enter a valid zipcode.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if (!AtLeastOneCheckboxSelected())
            {
                MessageBox.Show("Please select atleast one checkbox");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    // Get the selected hobbies and concatenate them into a single string
                    List<string> selectedHobbies = new List<string>();
                    if (moviecheckBox.Checked)
                        selectedHobbies.Add("movie");
                    if (footballcheckBox.Checked)
                        selectedHobbies.Add("football");
                    if (swimmingcheckBox.Checked)
                        selectedHobbies.Add("swimming");
                    if (musiccheckBox.Checked)
                        selectedHobbies.Add("music");

                    string hobbies = string.Join(", ", selectedHobbies);

                  

                    

                   
                    //if (moviecheckBox.Checked || footballcheckBox.Checked || swimmingcheckBox.Checked || musiccheckBox.Checked)
                    //{
                    string sql = "insert into StudentDetails(Name,Email,Phone,Zip,Hobbies) VaLUES(@nameBox,@emailBox,@phonBox,@zipBox,@Hobbies)";
                    //SqlCommand command = new SqlCommand("insert into StudentDetails values('" + nameBox.Text + "','" + emailBox.Text + "','" + phonBox.Text + "','" + zipBox.Text + "',@Hobbies)", connection);

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nameBox", nameBox.Text);
                        cmd.Parameters.AddWithValue("@emailBox", emailBox.Text);
                        cmd.Parameters.AddWithValue("@phonBox", phonBox.Text);

                        cmd.Parameters.AddWithValue("@zipBox", zipBox.Text);

                        cmd.Parameters.AddWithValue("@Hobbies", hobbies);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("data inserted successfully");
                        connection.Close();
                    //Clear the checkboxes and name field after insertion
                    nameBox.Clear();
                    emailBox.Clear();
                    phonBox.Clear();
                    zipBox.Clear();
                    moviecheckBox.Checked = false;
                    footballcheckBox.Checked = false;
                    swimmingcheckBox.Checked = false;
                    musiccheckBox.Checked = false;


                }
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(conectionString))
                {

                    connection.Open();
                    string sql1 = "select * from StudentDetails";
                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    dataGrid.DataSource = dt;
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete selected rows?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=SURAJ-PATIL-928;Initial Catalog=student;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dataGrid.SelectedRows)
                        {
                            string studentName = row.Cells["Name"].Value.ToString();

                            string query = "DELETE FROM StudentDetails WHERE Name = @nameBox";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@nameBox", studentName);
                                command.ExecuteNonQuery();
                            }
                        }

                       
                        }
                    DataTable dt = new DataTable();
                    using (SqlConnection connection = new SqlConnection(conectionString))
                    {

                        connection.Open();
                        string sql1 = "select * from StudentDetails";
                        using (SqlCommand command = new SqlCommand(sql1, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(dt);
                        }
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }
        
       







        private void footballcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(footballcheckBox.Checked==true) {
                txt2=footballcheckBox.Text;
            }
            else
            {
                txt2 = "";
            }
        }

        private void swimmingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (swimmingcheckBox.Checked == true)
            {
                txt3 = swimmingcheckBox.Text;
            }
            else
            {
                txt3 = "";
            }
        }

        private void phonBox_TextChanged(object sender, EventArgs e)
        {
          
        }
        private bool IsValidMobileNumber(string input)
        {
            // Define a regular expression pattern for a common mobile number format (adjust as needed)
            string pattern = @"^\d{10}$"; // Assumes 10-digit numeric mobile number

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }
        private bool IsValidEmail(string email)
        {
            // Use a regular expression to validate email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsEmailValid(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool AtLeastOneCheckboxSelected()
        {
            // Check if at least one checkbox is selected
            if (moviecheckBox.Checked || footballcheckBox.Checked || swimmingcheckBox.Checked ||musiccheckBox.Checked)
            {
                return true;
            }
            return false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;

                    Form2 editForm = new Form2(row,null);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the DataGridView if needed
                    }
                }
            }







            //if (dataGrid.SelectedRows.Count > 0)
            //{
            //    int selectedIndex = dataGrid.SelectedRows[0].Index;

            //    // Pass the selected row index to the edit form
            //    Form2 editForm = new Form2(selectedIndex);
            //    editForm.Show();

            //}
            else
            {

                        MessageBox.Show("Please select a row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
