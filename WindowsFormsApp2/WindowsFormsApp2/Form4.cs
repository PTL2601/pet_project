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
    public partial class Form4 : Form
    {
        DataBase dataBase = new DataBase();
        public Form4(int i)
        {
            InitializeComponent();
            label8.Text = i.ToString();
        }

        private void label_Place_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CreateColums()
        {
            dataGridView1.Columns.Add("ДОГОВОР", "Договор");
            dataGridView1.Columns.Add("ФАМИЛИЯ", "Фамилия");
            dataGridView1.Columns.Add("ИМЯ", "Имя");
            dataGridView1.Columns.Add("ОТЧЕСТВО", "Отчество");
            dataGridView1.Columns.Add("ПОЛ", "Пол");
            dataGridView1.Columns.Add("ДОЛЖНОСТЬ", "Должность");
            dataGridView1.Columns.Add("ОТДЕЛ", "Отдел");
            dataGridView1.Columns.Add("МЕСТО", "Место");
            dataGridView1.Columns.Add("ЗП", "Заработная плата");
            dataGridView1.Columns.Add("TELEGRAM", "@Telegram (для связи)");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetString(9));
        }

        private void Search(DataGridView dgw)
        {
            CreateColums();
            dgw.Rows.Clear();
            string searchString = $"select ID_колонки, ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, ЗП, TELEGRAM from DB_Senkevich where ID_колонки = '{Convert.ToInt32(label8.Text)}'";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Search(dataGridView1);
            label1.Text = "Здравствуйте, " + dataGridView1[1, 0].Value.ToString() + " " + dataGridView1[2, 0].Value.ToString() + " " + dataGridView1[3, 0].Value.ToString();
            label9.Text = dataGridView1[5, 0].Value.ToString();
            label10.Text = "№ " + dataGridView1[7, 0].Value.ToString();
            label11.Text = "№ " + dataGridView1[6, 0].Value.ToString();
            label12.Text = dataGridView1[8, 0].Value.ToString() + " руб.";
            label13.Text = dataGridView1[9, 0].Value.ToString();


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Visible = true;
            for (int i=1; i<label13.Text.Length; i++)
            {
                textBox1.Text += label13.Text[i];
            }
        }
        int rly = 0;
        string zapomnit;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            string telegramix = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (textBox1.Text != "")
            {
                if (textBox1.Text != "")
                {
                    string a = textBox1.Text;
                    int check = 0;
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        for (int b = 0; b < telegramix.Length; b++)
                        {
                            if (a[i] == telegramix[b])
                            {
                                check++;
                            }
                        }
                    }
                    if (check != textBox1.Text.Length)
                    {
                        label7.ForeColor = Color.Red;
                    }
                    if (check == textBox1.Text.Length)
                    {
                        rly++;
                        textBox1.Visible = false;
                        zapomnit = label13.Text;
                        label13.Text = "@" + textBox1.Text;
                        label7.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rly > 0)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    label13.Text = zapomnit;
                    this.Close();
                }
                if (result == DialogResult.Yes)
                {
                    var changeQuery = $"update DB_Senkevich set TELEGRAM = '{label13.Text}' where ДОГОВОР = '{Convert.ToInt32(label8.Text)}'";
                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    this.Hide();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 rework = new Form5(Convert.ToInt32(label8.Text));
            rework.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
