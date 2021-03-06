﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Group_Evaluation : Form
    {
        public Group_Evaluation()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        bool isEdit = false;
        int rowIndex;
        private void Group_Evaluation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectADataSet7.GroupEvaluation' table. You can move, or remove it, as needed.
            this.groupEvaluationTableAdapter.Fill(this.projectADataSet7.GroupEvaluation);
            // TODO: This line of code loads data into the 'projectADataSet6.GroupStudent' table. You can move, or remove it, as needed.
            this.groupStudentTableAdapter.Fill(this.projectADataSet6.GroupStudent);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            this.groupEvaluationTableAdapter.Fill(this.projectADataSet7.GroupEvaluation);
            string query = "select Id from Group1";
            var str = DatabaseConnection.getInstance().getAllData(query);
            str.Fill(table);
            comGroupId.DisplayMember = "Id";
            comGroupId.ValueMember = "Id";
            comGroupId.DataSource = table;

            DataTable tab = new DataTable();
            string query1 = "select Name from Evaluation";
            var str2 = DatabaseConnection.getInstance().getAllData(query1);
            str2.Fill(tab);
            comEvaluationId.DisplayMember = "Name";
            comEvaluationId.ValueMember = "Name";
            comEvaluationId.DataSource = tab;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "edit";
            button.HeaderText = "Edit";
            button.Text = "Edit";
            button.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(button);

            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            button1.Name = "delete";
            button1.HeaderText = "Delete";
            button1.Text = "Delete";
            button1.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(button1);
        }

        string conStr = "Data Source=MALIK\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        string grpId;
        private void button1_Click(object sender, EventArgs e)
        {
            int asdas = 0;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand checkExist = new SqlCommand("select count(*) from GroupEvaluation where GroupId=(select Id from Group1 where Id=@title) AND EvaluationId=(select Id from Evaluation where Name=@groupId)", con);
                checkExist.Parameters.AddWithValue("@title", comGroupId.Text);
                checkExist.CommandType = System.Data.CommandType.Text;
                checkExist.Parameters.AddWithValue("@groupId", comEvaluationId.Text);
                con.Open();
                asdas = (int)checkExist.ExecuteScalar();
            }
            catch
            {
                label4.Text = "Already Exists";
            }
            string date = DateTime.Now.ToShortDateString();
            string query1 = "select TotalMarks from Evaluation";
            var totalMarks = DatabaseConnection.getInstance().getRowsCount(query1);
            
            if (isEdit)
            {
                try
                {
                    string query = string.Format("update GroupEvaluation set GroupId='{0}', EvaluationId=(select Id from Evaluation where Name='{1}'), ObtainedMarks='{2}', EvaluationDate='{3}' where GroupId='{4}'", int.Parse(comGroupId.Text), comEvaluationId.Text, int.Parse(textBox3.Text), date, int.Parse(grpId));
                    DatabaseConnection.getInstance().executeQuery(query);
                    MessageBox.Show("Data updated Successfully!");
                    dataGridView1 = null;
                    this.groupEvaluationTableAdapter.Fill(this.projectADataSet7.GroupEvaluation);
                    isEdit = false;
                    comGroupId.Text = ""; comEvaluationId.Text = ""; textBox3.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            else if (comGroupId.Text == "" || comEvaluationId.Text == "" || textBox3.Text == "")
            {
                label4.Text = "Please Fill Required Field!";
            }

            else if (textBox3.Text.Any(char.IsLetter) == true)
            {
                textBox3.Focus();
                label4.Text = "Integer Value!";
            }
            else if (asdas > 0)
            {
                comGroupId.Focus();
                label4.Text = "Group Already Exists";
                con.Close();
            }

            else if (totalMarks < int.Parse(textBox3.Text))
            {
                textBox3.Focus();
                label4.Text = "Obtained Marks should be Less than Total Marks";
            }
            else
            {
                try
                {
                    string query = string.Format("insert into GroupEvaluation values('{0}',(select Id from Evaluation where Name='{1}'),'{2}','{3}')", int.Parse(comGroupId.Text), comEvaluationId.Text, int.Parse(textBox3.Text), date);
                    DatabaseConnection.getInstance().executeQuery(query);
                    MessageBox.Show("Data Inserted Successfully!");
                    dataGridView1 = null;
                    this.groupEvaluationTableAdapter.Fill(this.projectADataSet7.GroupEvaluation);
                    comGroupId.Text = ""; comEvaluationId.Text = ""; textBox3.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataTable tabl = new DataTable();
                try
                {
                    rowIndex = e.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    comGroupId.Text = row.Cells[0].Value.ToString();
                    grpId = row.Cells[0].Value.ToString();
                    string select = "select Name from Evaluation where Id='" + row.Cells[1].Value.ToString() + "'";
                    var str = DatabaseConnection.getInstance().getAllData(select);
                    str.Fill(tabl);
                    comEvaluationId.DisplayMember = "Name";
                    comEvaluationId.ValueMember = "Name";
                    comEvaluationId.DataSource = tabl;
                    //comEvaluationId.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    isEdit = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            if (e.ColumnIndex == 5 && DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    string sID = dataGridView1.CurrentRow.Cells["groupIdDataGridViewTextBoxColumn"].Value.ToString();
                    string query = "delete GroupEvaluation where GroupId='" + int.Parse(sID) + "'";
                    DatabaseConnection.getInstance().executeQuery(query);
                    dataGridView1 = null;
                    this.groupEvaluationTableAdapter.Fill(this.projectADataSet7.GroupEvaluation);
                    comGroupId.Text = ""; comEvaluationId.Text = ""; textBox3.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }
    }
}
