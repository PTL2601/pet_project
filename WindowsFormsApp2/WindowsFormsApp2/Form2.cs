using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;



namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();
        public Form2(string name,int id)
        {
            InitializeComponent();
            labelhello.Text = name;
            textBox_ID.Text = id.ToString();
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

            dataGridView2.Columns.Add("id_user", "id");
            dataGridView2.Columns.Add("id_true", "id_true");
            dataGridView2.Columns.Add("login_user", "login");
            dataGridView2.Columns.Add("password_user", "password");
            dataGridView2.Columns.Add("user_rule", "rule");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5),record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetString(9));
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetInt32(4));
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

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
            RefreshRegisterGrid(dataGridView2);
            textBoxSearch.Text = "Введите текст...";
            textBoxSearch.ForeColor = Color.Gray;
            textBoxSearch.Enabled = true;
            //AddFront
            checkBoxDostup.Visible = false;
            button_ConfirmAdd.Visible = false;
            labelHelp_foradding.Visible = false;
            pictureBoxForError1.Visible = false;
            pictureBoxForError2.Visible = false;
            pictureBox4_foradding.Visible = false;
            pictureBox5_foradding.Visible = false;
            pictureBoxInformationForAdding.Visible = false;
            pictureBox4_foradding.BackColor = Color.FromArgb(0, 128, 128, 128);
            pictureBox5_foradding.BackColor = Color.FromArgb(0, 128, 128, 128);
            pictureBoxForError1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBoxForError2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1_foradding.Visible = false;
            pictureBox2_foradding.Visible = false;
            pictureBoxForAdding_Kartochka.Visible = false;
            pictureBox3.Visible = false;

            comboBox_Sex.Visible = false;
            textBox_lastName.Visible = false;
            textBox_Name.Visible = false;
            textBox_FathersName.Visible = false;
            textBox_Priority.Visible = false;
            textBox_otdel.Visible = false;
            textBox_place.Visible = false;
            textBox_ZP.Visible = false;
            textBox_Telegram.Visible = false;

            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            //<AddFront>

            //<EditFront>
            groupBoxEdit.Visible = false;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //buttonAdd
        {
            if (pictureBox1_foradding.Visible == false)
            {
                textBox_lastName.Text = "";
                textBox_Name.Text = "";
                textBox_FathersName.Text = "";
                comboBox_Sex.Text = "";
                textBox_Priority.Text = "";
                textBox_otdel.Text = "";
                textBox_place.Text = "";
                textBox_ZP.Text = "";
                textBox_Telegram.Text = "";

                checkBoxDostup.Visible = true;
                textBoxSearch.Enabled = false;
                dataGridView1.Visible = false;
                controling = 0;
                groupBoxEdit.Visible = false;

                button_ConfirmAdd.Visible = true;
                pictureBox1_foradding.Visible = true;
                pictureBox2_foradding.Visible = true;
                pictureBox4_foradding.Visible = true;
                pictureBox5_foradding.Visible = true;
                pictureBoxForAdding_Kartochka.Visible = true;
                pictureBox3.Visible = true;
                pictureBoxForError1.Visible = true;
                pictureBoxForError2.Visible = true;
                pictureBoxInformationForAdding.Visible = true;

                comboBox_Sex.Visible = true;
                textBox_lastName.Visible = true;
                textBox_Name.Visible = true;
                textBox_FathersName.Visible = true;
                textBox_Priority.Visible = true;
                textBox_otdel.Visible = true;
                textBox_place.Visible = true;
                textBox_ZP.Visible = true;
                textBox_Telegram.Visible = true;

                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                //
                label20.Visible = true; //lastname
                label21.Visible = true; //name
                label22.Visible = true; //fathersname
                label23.Visible = true; //sex
                label24.Visible = true; //priority
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                pictureBox4_foradding.Visible = false;
                pictureBox5_foradding.Visible = false;
                checkBoxDostup.Visible = false;
                dataGridView1.Visible = true;
                textBoxSearch.Enabled = true;
                button_ConfirmAdd.Visible = false;
                pictureBox4_foradding.BackColor = Color.FromArgb(0, 128, 128, 128);
                pictureBox5_foradding.BackColor = Color.FromArgb(0, 128, 128, 128);
                pictureBox1_foradding.Visible = false;
                pictureBox2_foradding.Visible = false;
                pictureBoxForAdding_Kartochka.Visible = false;
                pictureBox3.Visible = false;
                pictureBoxForError1.Visible = false;
                pictureBoxForError2.Visible = false;
                pictureBoxInformationForAdding.Visible = false;

                comboBox_Sex.Visible = false;
                textBox_lastName.Visible = false;
                textBox_Name.Visible = false;
                textBox_FathersName.Visible = false;
                textBox_Priority.Visible = false;
                textBox_otdel.Visible = false;
                textBox_place.Visible = false;
                textBox_ZP.Visible = false;
                textBox_Telegram.Visible = false;

                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
            }
            
        }

        float step = 0;
        Color currentColor = Color.FromArgb(255, 153, 180, 209);
        Color targetColor = Color.FromArgb(255, 128, 128, 128);
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step >= 1f)
            {
                step = 0;
            }
            int mixR = (int)(currentColor.R * (1f - step) + targetColor.R * step);
            int mixG = (int)(currentColor.G * (1f - step) + targetColor.G * step);
            int mixB = (int)(currentColor.B * (1f - step) + targetColor.B * step);
            pictureBox4_foradding.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            pictureBox5_foradding.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            step +=0.03f;
            if (pictureBox4_foradding.BackColor == Color.FromArgb(255, 128, 128, 128))
            {
                timer1.Enabled = false;
            }
        }

        private void comboBox_Sex_Leave(object sender, EventArgs e)
        {
            if (comboBox_Sex.Text != "")
            {
                label14.ForeColor = Color.Black;
                label23.Text = comboBox_Sex.Text;
                comboBox_Sex.Visible = false;
            }
        }
        string d = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
        private void textBox_lastName_Leave(object sender, EventArgs e)
        {
            if (textBox_lastName.Text != "" || textBox_lastName.Text != " ")
            {
                string a = textBox_lastName.Text;
                int check = 0;
                for (int i = 0; i < textBox_lastName.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_lastName.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label11.ForeColor = Color.Red;

                }
                if (check == textBox_lastName.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_lastName.Visible = false;
                    label20.Text = textBox_lastName.Text;
                    label11.ForeColor = Color.Black;
                }
            }
        }

        float stepGREEN = 0;
        Color currentColorGREEN = Color.FromArgb(255, 229, 30, 0);
        Color targetColorGREEN = Color.FromArgb(255, 85, 204, 0);

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (stepGREEN >= 1f)
            {
                stepGREEN = 0;
            }
            int mixR = (int)(currentColorGREEN.R * (1f - stepGREEN) + targetColorGREEN.R * stepGREEN);
            int mixG = (int)(currentColorGREEN.G * (1f - stepGREEN) + targetColorGREEN.G * stepGREEN);
            int mixB = (int)(currentColorGREEN.B * (1f - stepGREEN) + targetColorGREEN.B * stepGREEN);
            pictureBoxForError1.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            pictureBoxForError2.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            stepGREEN += 0.05f;
            if (pictureBoxForError1.BackColor.R >= 70 && pictureBoxForError1.BackColor.G >= 190)
            {
                timer3.Enabled = false;
            }
        }

        float stepRED = 0;
        Color currentColorRED = Color.FromArgb(255, 85, 204, 0); 
        Color targetColorRED = Color.FromArgb(255, 229, 30, 0);
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (stepRED >= 1f)
            {
                stepRED = 0;
            }
            int mixR = (int)(currentColorRED.R * (1f - stepRED) + targetColorRED.R * stepRED);
            int mixG = (int)(currentColorRED.G * (1f - stepRED) + targetColorRED.G * stepRED);
            int mixB = (int)(currentColorRED.B * (1f - stepRED) + targetColorRED.B * stepRED);
            pictureBoxForError1.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            pictureBoxForError2.BackColor = Color.FromArgb(255, mixR, mixG, mixB);
            stepRED += 0.05f;
            if (pictureBoxForError1.BackColor.R >= 220 && pictureBoxForError1.BackColor.G >= 25)
            {
                timer2.Enabled = false;
            }
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "")
            {
                string a = textBox_Name.Text;
                int check = 0;
                for (int i = 0; i < textBox_Name.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_Name.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label12.ForeColor = Color.Red;
                }
                if (check == textBox_Name.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_Name.Visible = false;
                    label21.Text = textBox_Name.Text;
                    label12.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_FathersName_Leave(object sender, EventArgs e)
        {
            if (textBox_FathersName.Text != "")
            {
                string a = textBox_FathersName.Text;
                int check = 0;
                for (int i = 0; i < textBox_FathersName.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_FathersName.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label13.ForeColor = Color.Red;
                }
                if (check == textBox_FathersName.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_FathersName.Visible = false;
                    label22.Text = textBox_FathersName.Text;
                    label13.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_Priority_Leave(object sender, EventArgs e)
        {
            if (textBox_Priority.Text != "")
            {
                string a = textBox_Priority.Text;
                int check = 0;
                for (int i = 0; i < textBox_Priority.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_Priority.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label15.ForeColor = Color.Red;
                }
                if (check == textBox_Priority.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_Priority.Visible = false;
                    label24.Text = textBox_Priority.Text;
                    label15.ForeColor = Color.Black;
                }
            }
        }

        string y = "0123456789";
        private void textBox_otdel_Leave(object sender, EventArgs e) //цифры
        {
            if (textBox_otdel.Text != "")
            {
                string a = textBox_otdel.Text;
                int check = 0;
                for (int i = 0; i < textBox_otdel.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_otdel.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label16.ForeColor = Color.Red;
                }
                if (check == textBox_otdel.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_otdel.Visible = false;
                    label25.Text = textBox_otdel.Text;
                    label16.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_place_Leave(object sender, EventArgs e) //цифры
        {
            if (textBox_place.Text != "")
            {
                string a = textBox_place.Text;
                int check = 0;
                for (int i = 0; i < textBox_place.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_place.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label18.ForeColor = Color.Red;
                }
                if (check == textBox_place.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_place.Visible = false;
                    label26.Text = textBox_place.Text;
                    label18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_ZP_Leave(object sender, EventArgs e)
        {
            if (textBox_ZP.Text != "")
            {
                string a = textBox_ZP.Text;
                int check = 0;
                for (int i = 0; i < textBox_ZP.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBox_ZP.Text.Length)
                {
                    pictureBoxInformationForAdding.Visible = true;
                    timer2.Enabled = true;
                    label17.ForeColor = Color.Red;
                }
                if (check == textBox_ZP.Text.Length)
                {
                    timer3.Enabled = true;
                    textBox_ZP.Visible = false;
                    int diffbetween = 9 - textBox_ZP.Text.Length;
                    string result = "";
                    for (int k = 0; k < diffbetween; k++)
                    {
                        result += "x";
                    }
                    result += textBox_ZP.Text.ToString();
                    string result2 = "";
                    for (int res = 0; res < result.Length; res++)
                    {
                        if (result[res].ToString() != "x")
                        {
                            if (res == 2 || res == 5)
                            {
                                result2 = result2 + result[res] + ".";
                            }
                            else
                            {
                                result2 = result2 + result[res];
                            }
                        }

                    }
                    label27.Text = result2 + " руб.";
                    label17.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_Telegram_Leave(object sender, EventArgs e) //что угодно
        {
            string telegramix = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (textBox_Telegram.Text != "")
            {
                if (textBox_Telegram.Text != "")
                {
                    string a = textBox_Telegram.Text;
                    int check = 0;
                    for (int i = 0; i < textBox_Telegram.Text.Length; i++)
                    {
                        for (int b = 0; b < telegramix.Length; b++)
                        {
                            if (a[i] == telegramix[b])
                            {
                                check++;
                            }
                        }
                    }
                    if (check != textBox_Telegram.Text.Length)
                    {
                        pictureBoxInformationForAdding.Visible = true;
                        timer2.Enabled = true;
                        label19.ForeColor = Color.Red;
                    }
                    if (check == textBox_Telegram.Text.Length)
                    {
                        timer3.Enabled = true;
                        textBox_Telegram.Visible = false;
                        label28.Text = "@"+textBox_Telegram.Text;
                        label19.ForeColor = Color.Black;
                    }
                }
            }

        }

        private void pictureBox2_foradding_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_foradding.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_foradding.Visible = false; 
        }

        private void label20_Click(object sender, EventArgs e)
        {
            textBox_lastName.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            textBox_Name.Visible = true;
        }

        private void pictureBoxForAdding_Kartochka_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            textBox_FathersName.Visible = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            comboBox_Sex.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            textBox_Priority.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            textBox_otdel.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            textBox_place.Visible = true;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            textBox_ZP.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            textBox_Telegram.Visible = true;
        }

        private void button_ConfirmAdd_Click(object sender, EventArgs e)
        {
            if 
            (
            textBox_lastName.Text != "" &&
            textBox_Name.Text != "" &&
            textBox_FathersName.Text != "" &&
            comboBox_Sex.Text != "" &&
            textBox_Priority.Text != "" &&
            textBox_otdel.Text != "" &&
            textBox_place.Text != "" &&
            textBox_ZP.Text != "" &&
            textBox_Telegram.Text != ""
            )
            {
                //20-28 label
                string LastName = label20.Text;
                string Name = label21.Text;
                string FathersName = label22.Text;
                string Sex = label23.Text;
                string Priority = label24.Text;
                int Otdel = Convert.ToInt32(label25.Text);
                int Place = Convert.ToInt32(label26.Text);
                int ZP = Convert.ToInt32(textBox_ZP.Text);
                string Telegram = label28.Text;
                
                Random rnd = new Random();
                string login = rnd.Next(1,5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString();
                string password = rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (login == dataGridView2[1, i].Value.ToString() || password == dataGridView2[2, i].Value.ToString())
                    {
                        login = rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString();
                        password = rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString() + rnd.Next(1, 5).ToString();
                        i = 0;
                    }
                }
                int max_true = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    max_true = Convert.ToInt32(dataGridView1[0, i].Value);
                }
                max_true += 1;
                if (checkBoxDostup.Checked)
                {
                    int check = 1;
                    var addQuerry2 = $"insert into register (id_true, login_user, password_user, rule_user) values ('{max_true}','{login}','{password}','{check}')";
                    var command2 = new SqlCommand(addQuerry2, dataBase.GetConnection());
                    command2.ExecuteNonQuery();
                }
                if (!checkBoxDostup.Checked)
                {
                    int check = 0;
                    var addQuerry2 = $"insert into register (id_true, login_user, password_user, rule_user) values ('{max_true}','{login}','{password}','{check}')";
                    var command2 = new SqlCommand(addQuerry2, dataBase.GetConnection());
                    command2.ExecuteNonQuery();
                }
                
                var addQuerry = $"insert into DB_Senkevich (ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, ЗП, TELEGRAM) values ('{LastName}','{Name}','{FathersName}','{Sex}','{Priority}','{Otdel}','{Place}','{ZP}','{Telegram}')";
                var command = new SqlCommand(addQuerry, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Пользователь имеет следующие входные данные: " + "\n" + "   Логин: " + login + "\n" + "   Пароль: " + password, "Информация для входа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            if (textBox_lastName.Text == "")
            {
                label11.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_Name.Text == "")
            {
                label12.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_FathersName.Text == "")
            {
                label13.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (comboBox_Sex.Text == "")
            {
                label14.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_Priority.Text == "")
            {
                label15.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_otdel.Text == "")
            {
                label16.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_place.Text == "")
            {
                label18.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_ZP.Text == "")
            {
                label17.ForeColor = Color.Red;
                timer2.Enabled = true;
            }
            if (textBox_Telegram.Text == "")
            {
                label19.ForeColor = Color.Red;
                timer2.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        int controling = 0;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxEdit.Visible = true;
            dataGridView1.Enabled = false;
            controling += 1;
            if (controling == 1)
            {
                groupBoxEdit.Visible = true;
                textBoxLastName_Edit.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBoxName_Edit.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                textBoxFathersName_Edit.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                comboBoxSex_Edit.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                textBoxPriority_Edit.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                textBoxOtdel_Edit.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                textBoxPlace_Edit.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                string telegramresult = "";
                string b = textBoxTelegram_Edit.Text;
                for (int i=1; i<textBoxTelegram_Edit.Text.Length; i++)
                {
                    telegramresult += b[i];
                }
                textBoxTelegram_Edit.Text = telegramresult;
            }
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            groupBoxEdit.Visible = false;
            controling = 0;
            textBoxLastName_Edit.Text = "";
            textBoxName_Edit.Text = "";
            textBoxFathersName_Edit.Text = "";
            comboBoxSex_Edit.Text = "";
            textBoxPriority_Edit.Text = "";
            textBoxOtdel_Edit.Text = "";
            textBoxPlace_Edit.Text = "";
            textBoxZP_Edit.Text = "";
            textBoxTelegram_Edit.Text = "";
        }

        private void buttonEdit_Confirm_Click(object sender, EventArgs e)
        {
            int checkout = 0;
            string d = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
            if (textBoxLastName_Edit.Text != "")
            {
                string a = textBoxLastName_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxLastName_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxLastName_Edit.Text.Length)
                {
                    label2.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxLastName_Edit.Text.Length)
                {
                    label2.ForeColor = Color.Green;
                }
            }
            if (textBoxName_Edit.Text != "")
            {
                string a = textBoxName_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxName_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxName_Edit.Text.Length)
                {
                    label3.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxName_Edit.Text.Length)
                {
                    label3.ForeColor = Color.Green;
                }
            }
            if (textBoxFathersName_Edit.Text != "")
            {
                string a = textBoxFathersName_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxFathersName_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxFathersName_Edit.Text.Length)
                {
                    label4.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxFathersName_Edit.Text.Length)
                {
                    label4.ForeColor = Color.Green;
                }
            }
            if (comboBoxSex_Edit.Text == "")
            {
                checkout++;
                label5.ForeColor = Color.Red;
            }
            if (comboBoxSex_Edit.Text != "")
            {
                label5.ForeColor = Color.Green;
            }
            if (textBoxPriority_Edit.Text != "")
            {
                string a = textBoxPriority_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxPriority_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < d.Length; b++)
                    {
                        if (a[i] == d[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxPriority_Edit.Text.Length)
                {
                    label6.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxPriority_Edit.Text.Length)
                {
                    label6.ForeColor = Color.Green;
                }
            }
            string y = "0123456789";
            if (textBoxOtdel_Edit.Text != "")
            {
                string a = textBoxOtdel_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxOtdel_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxOtdel_Edit.Text.Length)
                {
                    label7.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxOtdel_Edit.Text.Length)
                {
                    label7.ForeColor = Color.Green;
                }
            }
            if (textBoxPlace_Edit.Text != "")
            {
                string a = textBoxPlace_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxPlace_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxPlace_Edit.Text.Length)
                {
                    label8.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxPlace_Edit.Text.Length)
                {
                    label8.ForeColor = Color.Green;
                }
            }
            if (textBoxZP_Edit.Text != "")
            {
                string a = textBoxZP_Edit.Text;
                int check = 0;
                for (int i = 0; i < textBoxZP_Edit.Text.Length; i++)
                {
                    for (int b = 0; b < y.Length; b++)
                    {
                        if (a[i] == y[b])
                        {
                            check++;
                        }
                    }
                }
                if (check != textBoxZP_Edit.Text.Length)
                {
                    label9.ForeColor = Color.Red;
                    checkout++;
                }
                if (check == textBoxZP_Edit.Text.Length)
                {
                    label9.ForeColor = Color.Green;
                }
            }
            string telegramix = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (textBoxTelegram_Edit.Text != "")
            {
                if (textBoxTelegram_Edit.Text != "")
                {
                    string a = textBoxTelegram_Edit.Text;
                    int check = 0;
                    for (int i = 0; i < textBoxTelegram_Edit.Text.Length; i++)
                    {
                        for (int b = 0; b < telegramix.Length; b++)
                        {
                            if (a[i] == telegramix[b])
                            {
                                check++;
                            }
                        }
                    }
                    if (check != textBoxTelegram_Edit.Text.Length)
                    {
                        label10.ForeColor = Color.Red;
                        checkout++;
                    }
                    if (check == textBoxTelegram_Edit.Text.Length)
                    {
                        label10.ForeColor = Color.Green;
                    }
                }
            }
            if (checkout == 0)
            {
                int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);
                string LastName = textBoxLastName_Edit.Text;
                string Name = textBoxName_Edit.Text;
                string FathersName = textBoxFathersName_Edit.Text;
                string Sex = comboBoxSex_Edit.Text;
                string Priority = textBoxPriority_Edit.Text;
                int Otdel = Convert.ToInt32(textBoxOtdel_Edit.Text);
                int Place = Convert.ToInt32(textBoxPlace_Edit.Text);
                int ZP = Convert.ToInt32(textBoxZP_Edit.Text);
                string Telegram = "@" + textBoxTelegram_Edit.Text;

                var changeQuery = $"update DB_Senkevich set ФАМИЛИЯ = '{LastName}', ИМЯ = '{Name}', ОТЧЕСТВО = '{FathersName}', ПОЛ = '{Sex}', ДОЛЖНОСТЬ = '{Priority}', ОТДЕЛ = '{Otdel}', МЕСТО = '{Place}', ЗП = '{ZP}', TELEGRAM = '{Telegram}' where ID_колонки = '{id}'";
                var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно отредактирована", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search(DataGridView dgw)
        {
            if (textBoxSearch.Text !="Введите текст...")
            {
                dgw.Rows.Clear();
                string searchString = $"select * from DB_Senkevich where concat (ID_колонки, ФАМИЛИЯ, ИМЯ, ОТЧЕСТВО, ПОЛ, ДОЛЖНОСТЬ, ОТДЕЛ, МЕСТО, ЗП, TELEGRAM) like '%" + textBoxSearch.Text + "%'";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);
            var DeleteQuery = $"delete from DB_Senkevich where ID_колонки = {id}";
            var DeleteQuery2 = $"delete from register where id_true = {id}";
            var command2 = new SqlCommand(DeleteQuery, dataBase.GetConnection());
            var command3 = new SqlCommand(DeleteQuery2, dataBase.GetConnection());
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            RefreshDataGrid(dataGridView1);
            MessageBox.Show("Запись успешно удалена", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 leave = new Form1();
            this.Close();
            leave.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        public void CreateColums2()
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 lol2 = new Form6();
            //lol2.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Form4 lol = new Form4(Convert.ToInt32(textBox_ID.Text));
            lol.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
