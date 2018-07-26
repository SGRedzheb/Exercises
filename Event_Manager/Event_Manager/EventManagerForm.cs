using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Manager
{
    public partial class EventManagerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog=EventManager;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int Id = 0;

        public EventManagerForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                cmd = new SqlCommand(@"INSERT INTO EventRecords(Name, Location, StartDate, EndDate, StartTime, EndTime)
                                        VALUES(@name, @location, @startDate, @endDate, @startTime, @endTime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@location", locationTextBox.Text);
                cmd.Parameters.AddWithValue("@startDate", startDatePicker.Value);
                cmd.Parameters.AddWithValue("@endDate", endDatePicker.Value);
                cmd.Parameters.AddWithValue("@startTime", startTimePicker.Value);
                cmd.Parameters.AddWithValue("@endTime", endTimePicker.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"Event created successfully - {nameTextBox.Text}, {locationTextBox.Text}" +
                    $"{Environment.NewLine} ({startDatePicker.Text} - {endDatePicker.Text})" +
                    $"{Environment.NewLine} ({startTimePicker.Text}-{endTimePicker.Text})");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please fill all the information about the event...");
            }
        }
        
        private void UpdateEventButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                cmd = new SqlCommand(@"UPDATE EventRecords SET Name=@name, Location=@location, StartDate=@startDate,
                                        EndDate=@endDate, StartTime=@startTime, EndTime=@endTime WHERE Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@location", locationTextBox.Text);
                cmd.Parameters.AddWithValue("@startDate", startDatePicker.Value);
                cmd.Parameters.AddWithValue("@endDate", endDatePicker.Value);
                cmd.Parameters.AddWithValue("@startTime", startTimePicker.Value);
                cmd.Parameters.AddWithValue("@endTime", endTimePicker.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event updated successfully!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select column or row to update...");
            }
        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("DELETE FROM EventRecords WHERE Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Event deleted successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select event to delete...");
            }
        }

        private void EventDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(EventDataGridView.Rows[e.RowIndex].Cells[0].Value);
            nameTextBox.Text = EventDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            locationTextBox.Text = EventDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            startDatePicker.Value = (DateTime)EventDataGridView.Rows[e.RowIndex].Cells[3].Value;
            endDatePicker.Value = (DateTime)EventDataGridView.Rows[e.RowIndex].Cells[4].Value;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM EventRecords", con);
            adapt.Fill(dt);
            EventDataGridView.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            nameTextBox.Text = "";
            locationTextBox.Text = "";
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today;
            startTimePicker.Value = DateTime.Now;
            endTimePicker.Value = DateTime.Now;
            Id = 0;
        }

        #region validation
        private bool ValidateForm()
        {
            bool output = true;

            if (nameTextBox.Text == "" || nameTextBox.Text.Length < 5 || nameTextBox.Text.Length > 20)
            {
                output = false;
                MessageBox.Show("Name must be between 5 - 20 chars long");
            }

            if (locationTextBox.Text == "" || locationTextBox.Text.Length < 5 || locationTextBox.Text.Length > 20)
            {
                output = false;
                MessageBox.Show("Location name must be between 5 - 20 chars long");
            }

            if (startDatePicker.Value < DateTime.Today )
            {
                output = false;
                MessageBox.Show("Can't create events with past date");
            }

            if (endDatePicker.Value == startDatePicker.Value)
            {
                output = true;
            }

            if (endDatePicker.Value >= startDatePicker.Value && endTimePicker.Value > startTimePicker.Value)
            {
                output = true;
            }

            if (endTimePicker.Value == startTimePicker.Value)
            {
                output = false;
                MessageBox.Show("Event end time must be greater than event start time!");
            }

            return output;
        }
        #endregion
    }
}
