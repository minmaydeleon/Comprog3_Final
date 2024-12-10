using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

public partial class MemberForm : Form
{
    private string connectionString = "Server=localhost;Database=membership_system;Uid=root;Pwd=password1234haha;";

    public MemberForm()
    {
        InitializeComponent();
    }

    private void MemberForm_Load(object sender, EventArgs e)
    {
        LoadData();
        LoadMembershipTypes();
    }

    private void LoadData()
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM members", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["name"].HeaderText = "Name";
                dataGridView1.Columns["start_date"].HeaderText = "Start Date";
                dataGridView1.Columns["end_date"].HeaderText = "End Date";
                dataGridView1.Columns["membership_type"].HeaderText = "Membership Type";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void LoadMembershipTypes()
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM membership_types", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMembershipType.Items.Clear();
                cmbMembershipType.Items.Add("Monthly");
                cmbMembershipType.Items.Add("Yearly");

                foreach (DataRow row in dt.Rows)
                {
                    cmbMembershipType.Items.Add(row["type_name"].ToString());
                }

                cmbMembershipType.SelectedIndex = 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string selectedMembershipType = cmbMembershipType.SelectedItem.ToString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO members (name, membership_type, start_date, end_date) VALUES (@name, @membership_type, @start_date, @end_date)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@membership_type", selectedMembershipType);
                cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToString("yyyy-MM-dd"));
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record inserted successfully.");
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to insert record.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnDeleteMembershipType_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a membership type to delete.");
                return;
            }

            string selectedMembershipType = cmbMembershipType.SelectedItem.ToString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM membership_types WHERE type_name=@type_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@type_name", selectedMembershipType);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Membership type deleted successfully.");
                    LoadMembershipTypes(); 
                }
                else
                {
                    MessageBox.Show("Failed to delete membership type.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || cmbMembershipType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                string selectedMembershipType = cmbMembershipType.SelectedItem.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE members SET name=@name, membership_type=@membership_type, start_date=@start_date, end_date=@end_date WHERE id=@id", connection);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@membership_type", selectedMembershipType);
                    cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }

                LoadData();
                ClearFields();
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a member to update.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM members WHERE id=@id", connection);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void ClearFields()
    {
        txtName.Clear();
        cmbMembershipType.SelectedIndex = 0;
        dtpStartDate.Value = DateTime.Now;
        dtpEndDate.Value = DateTime.Now;
    }

    private void btnGeneratePdf_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            GeneratePdf(filePath);
        }
    }

    private void GeneratePdf(string filePath)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM members", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                float[] columnWidths = new float[] { 1f, 3f, 3f, 2f, 2f };
                PdfPTable table = new PdfPTable(columnWidths);

                table.AddCell("ID");
                table.AddCell("Name");
                table.AddCell("Membership Type");
                table.AddCell("Start Date");
                table.AddCell("End Date");

                while (reader.Read())
                {
                    table.AddCell(reader["id"].ToString());
                    table.AddCell(reader["name"].ToString());
                    table.AddCell(reader["membership_type"].ToString());
                    table.AddCell(Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd"));
                    table.AddCell(Convert.ToDateTime(reader["end_date"]).ToString("yyyy-MM-dd"));
                }

                doc.Add(table);
                doc.Close();
                reader.Close();
            }
            MessageBox.Show("PDF Generated Successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnAddNewMembershipType_Click(object sender, EventArgs e)
    {
        try
        {
            string newMembershipType = txtNewMembershipType.Text;

            if (string.IsNullOrEmpty(newMembershipType))
            {
                MessageBox.Show("Please enter a valid membership type.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO membership_types (type_name) VALUES (@type_name)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@type_name", newMembershipType);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New membership type added successfully.");
                    LoadMembershipTypes(); 
                }
                else
                {
                    MessageBox.Show("Failed to add new membership type.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
