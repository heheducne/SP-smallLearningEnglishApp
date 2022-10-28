using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh1
{

    public partial class FormMain : Form
    {
        FormGame game = new FormGame();
        DataTable dataMain1 = new DataTable();
        DataTable dataMain2 = new DataTable();
        DataTable dataMain3 = new DataTable();
        DataTable dataMain4 = new DataTable();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        

        public FormMain()
        {
            InitializeComponent();
            player.SoundLocation = "Parallel WorldWAV.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool keoTha = false;
        private Point mouseStart = new Point(0, 0);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.keoTha)
            {
                Point p = new Point(e.X + this.Location.X, e.Y + this.Location.Y);
                Point location = new Point(p.X - this.mouseStart.X, p.Y - this.mouseStart.Y);
                this.Location = location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Kiểm tra xem người dùng nhấn nút nào. 
            {
                this.keoTha = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Kiểm tra xem người dùng nhấn nút nào. 
            {
                this.keoTha = true;
                this.mouseStart = e.Location;
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            label2.ForeColor = Color.Yellow;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.ForeColor = Color.Red;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
            label3.ForeColor = Color.Yellow;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label3.ForeColor = Color.Red;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
            label4.ForeColor = Color.Yellow;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label4.ForeColor = Color.Red;
        }
        //=============================================================================================//
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát game hả?", "ALO ALO", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            dataGridView1.DataSource = dataMain1;
            dataGridView2.DataSource = dataMain2;
            dataGridView3.DataSource = dataMain3;
            dataGridView4.DataSource = dataMain4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label5.Visible = true;
            panel4.Visible = false;
            if (panel4.BackgroundImage != Properties.Resources.words)
            {
                panel4.BackgroundImage = Properties.Resources.words;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.Text == "animal")
            {
                panel4.BackgroundImage = Properties.Resources.animal_wordss;
                label5.Visible = false;
            }
            if (comboBox1.Text == "vehicles")
            {
                panel4.BackgroundImage = Properties.Resources.VEHICLES_WORDS;
                label5.Visible = false;
            }         
            if (comboBox1.Text == "sports")
            {
                panel4.BackgroundImage = Properties.Resources.SPORT_WORDS;
                label5.Visible = false;
            }               
            if (comboBox1.Text == "household goods")
            {
                panel4.BackgroundImage = Properties.Resources.HOUSEHOLD_WORDS;
                label5.Visible = false;
            }
        }

        int checksound = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if(checksound == 0)
            {
                player.Play();
                button5.BackgroundImage = Properties.Resources.sound_unmute;
                checksound = 1;
            }
            else
            {
                player.Stop();
                button5.BackgroundImage = Properties.Resources.sound_mute;
                checksound = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "nhap ten di !")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "nhap ten di !";
            }
            else
            {
                textBox1.Text = "";
                panel3.Visible = false;
                this.Hide();
                
                game.ShowDialog();
                dataMain1 = game.dataAnimal;
                dataMain2 = game.dataVehicles;
                dataMain3 = game.dataSports;
                dataMain4 = game.dataHousehold;
                this.Show();
            }
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bùi Hữu Đức - 20520449", "Info sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "animal")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView3.Visible = false;

            }
            if (comboBox1.Text == "vehicles")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView3.Visible = false;
            }
            if (comboBox1.Text == "sports")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView3.Visible = false;
            }
            if (comboBox1.Text == "household goods")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView3.Visible = true;
            }
        }
    }
}
