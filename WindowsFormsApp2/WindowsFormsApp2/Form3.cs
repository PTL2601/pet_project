using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        DataBase dataBase = new DataBase();
        public Form3(string name, int i)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = i.ToString();
        }
        private void CreateColums()
        {
            dataGridView1.Columns.Add("ФАМИЛИЯ", "Фамилия");
            dataGridView1.Columns.Add("ИМЯ", "Имя");
            dataGridView1.Columns.Add("ОТЧЕСТВО", "Отчество");
            dataGridView1.Columns.Add("ПОЛ", "Пол");
            dataGridView1.Columns.Add("ДОЛЖНОСТЬ", "Должность");
            dataGridView1.Columns.Add("ОТДЕЛ", "Отдел");
            dataGridView1.Columns.Add("МЕСТО", "Место");
            dataGridView1.Columns.Add("TELEGRAM", "@Telegram (для связи)");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryString = $"select ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, TELEGRAM from DB_Senkevich";
            SqlCommand command = new SqlCommand(querryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
            textBoxSearch.Text = "Введите текст...";
            textBoxSearch.ForeColor = Color.Gray;
        }
        private void Search(DataGridView dgw)
        {
            if (textBoxSearch.Text != "Введите текст...")
            {
                dgw.Rows.Clear();
                string searchString = $"select ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, TELEGRAM from DB_Senkevich where concat (ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, TELEGRAM) like '%" + textBoxSearch.Text + "%'";
                SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
                dataBase.openConnection();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadSingleRow(dgw, read);
                }
                read.Close();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.ForeColor = Color.Black;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Введите текст...";
            textBoxSearch.ForeColor = Color.Gray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 leave = new Form1();
            leave.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 settings = new Form4(Convert.ToInt32(label2.Text));
            settings.Show();
        }
    }
}
