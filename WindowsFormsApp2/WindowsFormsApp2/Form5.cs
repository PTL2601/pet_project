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
    public partial class Form5 : Form
    {
        DataBase dataBase = new DataBase();
        public Form5(int id)
        {
            InitializeComponent();
            textBox_ID.Text = id.ToString();
        }
        public void CreateColums()
        {
            dataGridView1.Columns.Add("id_user", "id");
            dataGridView1.Columns.Add("id_true", "id_true");
            dataGridView1.Columns.Add("login_user", "login");
            dataGridView1.Columns.Add("password_user", "password");
            dataGridView1.Columns.Add("user_rule", "rule");
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetInt32(4));
        }
        private void RefreshRegisterGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryString = $"select id, id_true, login_user, password_user, rule_user from register where id_true = '{Convert.ToInt32(textBox_ID.Text)}'";
            SqlCommand command = new SqlCommand(querryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshRegisterGrid(dataGridView1);
            pictureBox_offpc.Visible = true;
            pictureBox_onpc.Visible = false;
            button_OKold.Enabled = false;
            textBoxNewPassword_1.Enabled = false;
            textBoxNewPassword_2.Enabled = false;
            textBox1.PasswordChar = '●';
            textBoxNewPassword_1.PasswordChar = '●';
            textBoxNewPassword_2.PasswordChar = '●';
            button_OKold.Visible = true;
            button_OKnew.Visible = false;
            label4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button_OKold.Enabled = true;
            label1.ForeColor = Color.Black;
        }

        private void button_OKold_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button_OKold.Enabled = false;
                label1.ForeColor = Color.Red;
            }
            if (textBox1.Text != "")
            {
                if (textBox1.Text == dataGridView1[3, 0].Value.ToString())
                {
                    textBoxNewPassword_1.Enabled = true;
                    textBoxNewPassword_2.Enabled = true;
                    label1.ForeColor = Color.Green;
                    textBox1.Enabled = false;
                    button_OKnew.Visible = true;
                    button_OKold.Visible = false;
                }
            }
        }

        private void pictureBox_offpc_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            textBoxNewPassword_1.UseSystemPasswordChar = true;
            textBoxNewPassword_2.UseSystemPasswordChar = true;
            pictureBox_offpc.Visible = false;
            pictureBox_onpc.Visible = true;
        }

        private void pictureBox_onpc_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            textBoxNewPassword_1.UseSystemPasswordChar = false;
            textBoxNewPassword_2.UseSystemPasswordChar = false;
            pictureBox_offpc.Visible = true;
            pictureBox_onpc.Visible = false;
        }

        private void button_OKnew_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword_1.Text == "" || textBoxNewPassword_2.Text == "")
            {
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
            else
            {
                if (textBoxNewPassword_1.Text == textBoxNewPassword_2.Text)
                {
                    var changeQuery = $"update register set password_user = '{textBoxNewPassword_1.Text}' where id_true = '{Convert.ToInt32(textBox_ID.Text)}'";
                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пароль успешно изменён!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    label4.Visible = true;
                    label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                }
            }
        }

        private void textBoxNewPassword_1_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label4.Visible = false;
        }

        private void textBoxNewPassword_2_TextChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            label4.Visible = false;
        }
    }
}
