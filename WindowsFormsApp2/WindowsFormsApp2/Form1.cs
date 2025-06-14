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
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text != "" && textBox_password.Text != "")
            {
                int count = 0;
                string login = textBox_login.Text;
                string password = textBox_password.Text;
                for (int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    if (login == dataGridView1[2,i].Value.ToString() && password == dataGridView1[3, i].Value.ToString())
                    {
                        int trueID = Convert.ToInt32(dataGridView1[1, i].Value);    
                        count++;
                        if (dataGridView1[4, i].Value.ToString() == "1")
                        {
                            string name = "";
                            string Father = "";
                            for (int b=0; b<dataGridView2.Rows.Count; b++)
                            {
                                if (Convert.ToInt32(dataGridView2[0,b].Value) == trueID)
                                {
                                    name = dataGridView2[2, b].Value.ToString();
                                    Father = dataGridView2[3, b].Value.ToString();
                                }
                            }
                            Form2 admin = new Form2("Здравствуйте, " + name + " " + Father, trueID);
                            admin.Show();
                            this.Hide();
                        }
                        if (dataGridView1[4, i].Value.ToString() == "0")
                        {
                            string name = "";
                            string Father = "";
                            for (int b = 0; b < dataGridView2.Rows.Count; b++)
                            {
                                if (Convert.ToInt32(dataGridView2[0, b].Value) == trueID)
                                {
                                    name = dataGridView2[2, b].Value.ToString();
                                    Father = dataGridView2[3, b].Value.ToString();
                                }
                            }
                            Form3 rook = new Form3("Здравствуйте, " + name + " " + Father, trueID);
                            rook.Show();
                            this.Hide();
                        }
                    }
                }
                if (count == 0)
                {
                    label5.Visible = true;
                }
            }
            if (textBox_login.Text == "")
            {
                label2.ForeColor = Color.Red;
                label4.Visible = true;
            }
            if (textBox_password.Text == "")
            {
                label3.ForeColor = Color.Red;
                label4.Visible = true;
            }
        }
        
        private void CreateColums()
        {
            dataGridView2.Columns.Add("ДОГОВОР", "Договор");
            dataGridView2.Columns.Add("ФАМИЛИЯ", "Фамилия");
            dataGridView2.Columns.Add("ИМЯ", "Имя");
            dataGridView2.Columns.Add("ОТЧЕСТВО", "Отчество");
            dataGridView2.Columns.Add("ПОЛ", "Пол");
            dataGridView2.Columns.Add("ДОЛЖНОСТЬ", "Должность");
            dataGridView2.Columns.Add("ОТДЕЛ", "Отдел");
            dataGridView2.Columns.Add("МЕСТО", "Место");
            dataGridView2.Columns.Add("ЗП", "Заработная плата");
            dataGridView2.Columns.Add("TELEGRAM", "@Telegram (для связи)");

            dataGridView1.Columns.Add("id_user", "id");
            dataGridView1.Columns.Add("id_true", "id_true");
            dataGridView1.Columns.Add("login_user", "login");
            dataGridView1.Columns.Add("password_user", "password");
            dataGridView1.Columns.Add("user_rule", "rule");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetString(9));
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetInt32(4));
        }
        private void RefreshRegisterGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryString = $"select * from register";
            SqlCommand command = new SqlCommand(querryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryString = $"select * from DB_Senkevich";
            SqlCommand command = new SqlCommand(querryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '●';
            pictureBoxEye_Crossed.Visible = true;
            pictureBoxEye_NotCrossed.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            CreateColums();
            RefreshRegisterGrid(dataGridView1);
            RefreshDataGrid(dataGridView2);
        }


        private void pictureBoxEye_Crossed_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBoxEye_Crossed.Visible = false;
            pictureBoxEye_NotCrossed.Visible = true;
        }

        private void pictureBoxEye_NotCrossed_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBoxEye_Crossed.Visible = true;
            pictureBoxEye_NotCrossed.Visible = false;
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            if (textBox_login.Text != "")
            {
                label2.ForeColor = Color.Black;
            }
            if (textBox_login.Text == "")
            {
                label2.ForeColor = Color.Red;
                label4.Visible = true;
            }
            if (textBox_login.Text != "" && textBox_password.Text != "")
            {
                label4.Visible = false; 
            }
        }

        private void label3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text != "")
            {
                label3.ForeColor = Color.Black;
            }
            if (textBox_password.Text == "")
            {
                label3.ForeColor = Color.Red;
                label4.Visible = true;
            }
            if (textBox_login.Text != "" && textBox_password.Text != "")
            {
                label4.Visible = false;
            }
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
