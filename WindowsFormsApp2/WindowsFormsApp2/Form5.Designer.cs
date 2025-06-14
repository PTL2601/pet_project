
namespace WindowsFormsApp2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword_1 = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_OKold = new System.Windows.Forms.Button();
            this.pictureBox_onpc = new System.Windows.Forms.PictureBox();
            this.pictureBox_offpc = new System.Windows.Forms.PictureBox();
            this.button_OKnew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_onpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_offpc)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNewPassword_1
            // 
            this.textBoxNewPassword_1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword_1.Location = new System.Drawing.Point(16, 98);
            this.textBoxNewPassword_1.Multiline = true;
            this.textBoxNewPassword_1.Name = "textBoxNewPassword_1";
            this.textBoxNewPassword_1.Size = new System.Drawing.Size(206, 36);
            this.textBoxNewPassword_1.TabIndex = 1;
            this.textBoxNewPassword_1.TextChanged += new System.EventHandler(this.textBoxNewPassword_1_TextChanged);
            // 
            // textBoxNewPassword_2
            // 
            this.textBoxNewPassword_2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword_2.Location = new System.Drawing.Point(16, 165);
            this.textBoxNewPassword_2.Multiline = true;
            this.textBoxNewPassword_2.Name = "textBoxNewPassword_2";
            this.textBoxNewPassword_2.Size = new System.Drawing.Size(206, 36);
            this.textBoxNewPassword_2.TabIndex = 2;
            this.textBoxNewPassword_2.TextChanged += new System.EventHandler(this.textBoxNewPassword_2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите старый пароль:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите новый пароль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите новый пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(324, 6);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(40, 20);
            this.textBox_ID.TabIndex = 6;
            this.textBox_ID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 134);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_OKold
            // 
            this.button_OKold.Location = new System.Drawing.Point(228, 32);
            this.button_OKold.Name = "button_OKold";
            this.button_OKold.Size = new System.Drawing.Size(40, 36);
            this.button_OKold.TabIndex = 8;
            this.button_OKold.Text = "ОК";
            this.button_OKold.UseVisualStyleBackColor = true;
            this.button_OKold.Click += new System.EventHandler(this.button_OKold_Click);
            // 
            // pictureBox_onpc
            // 
            this.pictureBox_onpc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_onpc.Image")));
            this.pictureBox_onpc.Location = new System.Drawing.Point(205, 9);
            this.pictureBox_onpc.Name = "pictureBox_onpc";
            this.pictureBox_onpc.Size = new System.Drawing.Size(24, 20);
            this.pictureBox_onpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_onpc.TabIndex = 9;
            this.pictureBox_onpc.TabStop = false;
            this.pictureBox_onpc.Click += new System.EventHandler(this.pictureBox_onpc_Click);
            // 
            // pictureBox_offpc
            // 
            this.pictureBox_offpc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_offpc.Image")));
            this.pictureBox_offpc.Location = new System.Drawing.Point(205, 9);
            this.pictureBox_offpc.Name = "pictureBox_offpc";
            this.pictureBox_offpc.Size = new System.Drawing.Size(24, 20);
            this.pictureBox_offpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_offpc.TabIndex = 10;
            this.pictureBox_offpc.TabStop = false;
            this.pictureBox_offpc.Click += new System.EventHandler(this.pictureBox_offpc_Click);
            // 
            // button_OKnew
            // 
            this.button_OKnew.Location = new System.Drawing.Point(228, 165);
            this.button_OKnew.Name = "button_OKnew";
            this.button_OKnew.Size = new System.Drawing.Size(40, 36);
            this.button_OKnew.TabIndex = 11;
            this.button_OKnew.Text = "ОК";
            this.button_OKnew.UseVisualStyleBackColor = true;
            this.button_OKnew.Click += new System.EventHandler(this.button_OKnew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "*Пароли должны быть одинаковыми";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_OKnew);
            this.Controls.Add(this.pictureBox_offpc);
            this.Controls.Add(this.pictureBox_onpc);
            this.Controls.Add(this.button_OKold);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPassword_2);
            this.Controls.Add(this.textBoxNewPassword_1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_onpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_offpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNewPassword_1;
        private System.Windows.Forms.TextBox textBoxNewPassword_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_OKold;
        private System.Windows.Forms.PictureBox pictureBox_onpc;
        private System.Windows.Forms.PictureBox pictureBox_offpc;
        private System.Windows.Forms.Button button_OKnew;
        private System.Windows.Forms.Label label4;
    }
}