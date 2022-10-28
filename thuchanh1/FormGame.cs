using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace thuchanh1
{
    public partial class FormGame : Form
    {
        public DataTable dataAnimal = new DataTable();
        public DataTable dataSports = new DataTable();
        public DataTable dataVehicles = new DataTable();
        public DataTable dataHousehold = new DataTable();

        static int id = 0;
        public FormGame()
        {

            InitializeComponent();
            label_ID.Text = id.ToString();
            panel_ID.Visible = true;

            dataAnimal.Columns.Add("ID", typeof(int));
            dataAnimal.Columns.Add("Score", typeof(int));
            dataAnimal.Columns.Add("Time", typeof(int));

            dataSports.Columns.Add("ID", typeof(int));
            dataSports.Columns.Add("Score", typeof(int));
            dataSports.Columns.Add("Time", typeof(int));

            dataVehicles.Columns.Add("ID", typeof(int));
            dataVehicles.Columns.Add("Score", typeof(int));
            dataVehicles.Columns.Add("Time", typeof(int));

            dataHousehold.Columns.Add("ID", typeof(int));
            dataHousehold.Columns.Add("Score", typeof(int));
            dataHousehold.Columns.Add("Time", typeof(int));

        }


        //==============================ANIMALS===========================================//
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;
        int flag5 = 0;
        int flag6 = 0;
        int flag7 = 0;
        int flag8 = 0;
        int flag9 = 0;
        int flag10 = 0;
        int totalscore = 0;
        int count = 0;
        int dice;
        int check1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (giay1 == 0)
                timer1.Stop();
            else
                timer1.Start();
            if (count > 0)
            {

                switch (dice)
                {
                    case 1:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "cat" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 2:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "dog" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 3:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "dolphin" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 4:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "duck" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 5:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "elephant" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 6:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "fox" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 7:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "horse" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 8:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "monkey" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 9:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "parrot" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                    case 10:
                        if (textBox_INPUT_ANIMAL.Text.ToLower().Replace(" ", "") == "rihno" && giay1 > 0)
                            totalscore += 2;
                        textBox_INPUT_ANIMAL.Text = "";
                        break;
                }
            }

            if (count > 4)
            {

                label_POINT_ANIMAL.Text = totalscore.ToString();
                label_TIME_ANIMAL.Text = (60 - giay1).ToString();
                label_S_ANIMAL.Visible = false;
                label_60_ANIMAL.Visible = false;
                groupBox_ANIMAL.Visible = true;
                button_START_ANIMAL.Visible = false;
                pictureBox_ANIMAL.Visible = false;
                label_ANIMAL.Visible = false;
                textBox_INPUT_ANIMAL.Visible = false;
                check1 = 1;
                dataAnimal.Rows.Add(id, totalscore, 60 - giay1);

                return;
            }
            Random rand = new Random();
            List<int> list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            do
            {
                dice = rand.Next(list.Count + 1);
            }
            while ((dice == 1 && flag1 == 1)
               || (dice == 2 && flag2 == 1)
               || (dice == 3 && flag3 == 1)
               || (dice == 4 && flag4 == 1)
               || (dice == 5 && flag5 == 1)
               || (dice == 6 && flag6 == 1)
               || (dice == 7 && flag7 == 1)
               || (dice == 8 && flag8 == 1)
               || (dice == 9 && flag9 == 1)
               || (dice == 10 && flag10 == 1)
               );

            switch (dice)
            {
                case 1:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.cat;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag1 = 1;
                    break;
                case 2:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.dog;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag2 = 1;
                    break;
                case 3:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.dolphin;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag3 = 1;
                    break;
                case 4:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.duck;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag4 = 1;
                    break;
                case 5:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.elephants;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag5 = 1;
                    break;
                case 6:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.fox;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag6 = 1;
                    break;
                case 7:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.horse;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag7 = 1;
                    break;
                case 8:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.monkey;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag8 = 1;
                    break;
                case 9:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.parrot;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag9 = 1;
                    break;
                case 10:
                    pictureBox_ANIMAL.Visible = true;
                    pictureBox_ANIMAL.BackgroundImage = Properties.Resources.rhino;
                    button_START_ANIMAL.Text = "NEXT";
                    textBox_INPUT_ANIMAL.Visible = true;
                    button_BACK_ANIMAL.Visible = false;
                    label_S_ANIMAL.Visible = true;
                    label_60_ANIMAL.Visible = true;
                    count++;
                    flag10 = 1;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_ANIMAL.Visible = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 & e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32));
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_INPUT_ANIMAL.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_ANIMAL.Visible = false;
        }

        int giay1 = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay1--;
            label_60_ANIMAL.Text = giay1.ToString();
            if (giay1 == 0)
                timer1.Stop();
        }

        //=====================================VEHICLES=======================================//



        int flag11 = 0;
        int flag12 = 0;
        int flag13 = 0;
        int flag14 = 0;
        int flag15 = 0;
        int flag16 = 0;
        int flag17 = 0;
        int flag18 = 0;
        int flag19 = 0;
        int flag20 = 0;
        int totalscore2 = 0;
        int count2 = 0;
        int dice2;
        int check2 = 0;

        private void button_START_VEHICLE_Click(object sender, EventArgs e)
        {
            if (giay2 == 0)
                timer2.Stop();
            else
                timer2.Start();
            if (count2 > 0)
            {
                switch (dice2)
                {
                    case 1:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "airplane" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 2:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "ambulance" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 3:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "bicycle" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 4:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "bus" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 5:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "helicopter" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 6:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "ship" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 7:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "tank" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 8:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "taxi" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 9:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "train" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                    case 10:
                        if (textBox_INPUT_VEHICLE.Text.ToLower().Replace(" ", "") == "truck" && giay2 > 0)
                            totalscore2 += 2;
                        textBox_INPUT_VEHICLE.Text = "";
                        break;
                }
            }


            if (count2 > 4)
            {
                label_POINT_VEHICLE.Text = totalscore2.ToString();
                label_TIME_VEHICLE.Text = (60 - giay2).ToString();
                timer2.Stop();
                label_60_VEHICLE.Visible = false;
                label_S_VEHICLE.Visible = false;
                groupBox_VEHICLE.Visible = true;
                button_START_VEHICLE.Visible = false;
                pictureBox_VEHICLE.Visible = false;
                textBox_INPUT_VEHICLE.Visible = false;
                label_VEHICLE.Visible = false;
                check2 = 1;
                dataVehicles.Rows.Add(id, totalscore2, 60 - giay2);

                return;
            }
            Random rand = new Random();
            List<int> list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            do
            {
                dice2 = rand.Next(list.Count + 1);
            }
            while ((dice2 == 1 && flag11 == 1)
               || (dice2 == 2 && flag12 == 1)
               || (dice2 == 3 && flag13 == 1)
               || (dice2 == 4 && flag14 == 1)
               || (dice2 == 5 && flag15 == 1)
               || (dice2 == 6 && flag16 == 1)
               || (dice2 == 7 && flag17 == 1)
               || (dice2 == 8 && flag18 == 1)
               || (dice2 == 9 && flag19 == 1)
               || (dice2 == 10 && flag20 == 1)
               );

            switch (dice2)
            {
                case 1:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.airplane;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag11 = 1;
                    break;
                case 2:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.ambulance;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag12 = 1;
                    break;
                case 3:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.bicycle;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag13 = 1;
                    break;
                case 4:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.bus;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag14 = 1;
                    break;
                case 5:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.helicopter;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag15 = 1;
                    break;
                case 6:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.ship;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag16 = 1;
                    break;
                case 7:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.tank;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag17 = 1;
                    break;
                case 8:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.taxi;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag18 = 1;
                    break;
                case 9:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.train;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag19 = 1;
                    break;
                case 10:
                    pictureBox_VEHICLE.Visible = true;
                    pictureBox_VEHICLE.BackgroundImage = Properties.Resources.truck;
                    button_START_VEHICLE.Text = "NEXT";
                    button_BACK_VEHICLE.Visible = false;
                    textBox_INPUT_VEHICLE.Visible = true;
                    label_60_VEHICLE.Visible = true;
                    label_S_VEHICLE.Visible = true;
                    count2++;
                    flag20 = 1;
                    break;
            }
        }


        private void textBox_INPUT_VEHICLE_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_INPUT_VEHICLE.Text = "";
        }
        private void textBox_INPUT_VEHICLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 & e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32));

        }

        private void button_BACK_VEHICLE_Click(object sender, EventArgs e)
        {
            panel_vehicles.Visible = false;
        }

        private void button_OK_VEHICLE_Click(object sender, EventArgs e)
        {
            panel_vehicles.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel_vehicles.Visible = true;
            //topic = "vehicles";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_ANIMAL.Visible = false;
        }

        int giay2 = 60;
        private void timer2_Tick(object sender, EventArgs e)
        {
            giay2--;
            label_60_VEHICLE.Text = giay2.ToString();
            if (giay2 == 0)
                timer2.Stop();
        }


        //========================================SPORTS=========================================//

        int flag31 = 0;
        int flag32 = 0;
        int flag33 = 0;
        int flag34 = 0;
        int flag35 = 0;
        int flag36 = 0;
        int flag37 = 0;
        int flag38 = 0;
        int flag39 = 0;
        int flag40 = 0;
        int totalscore3 = 0;
        int count3 = 0;
        int dice3;
        int check3 = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            panel_sport.Visible = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (giay3 == 0)
                timer3.Stop();
            else
                timer3.Start();
            if (count3 > 0)
            {
                switch (dice3)
                {
                    case 1:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "athletics" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 2:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "badminton" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 3:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "basketball" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 4:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "chess" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 5:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "football" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 6:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "golf" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 7:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "pingpong" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 8:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "swimming" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 9:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "tennis" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                    case 10:
                        if (textBox_INPUT_SPORT.Text.ToLower().Replace(" ", "") == "volleyball" && giay3 > 0)
                            totalscore3 += 2;
                        textBox_INPUT_SPORT.Text = "";
                        break;
                }
            }


            if (count3 > 4)
            {
                label_POINT_SCORE.Text = totalscore3.ToString();
                label_TIME_SPORT.Text = (60 - giay3).ToString();
                timer3.Stop();
                label_60_SPORT.Visible = false;
                label_S_SPORT.Visible = false;
                groupBox_SPORT.Visible = true;
                button_START_SPORT.Visible = false;
                pictureBox_SPORT.Visible = false;
                textBox_INPUT_SPORT.Visible = false;
                label_SPORT.Visible = false;
                check3 = 1;
                dataSports.Rows.Add(id, totalscore3, 60 - giay3);

                return;
            }
            Random rand = new Random();
            List<int> list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            do
            {
                dice3 = rand.Next(list.Count + 1);
            }
            while ((dice3 == 1 && flag31 == 1)
               || (dice3 == 2 && flag32 == 1)
               || (dice3 == 3 && flag33 == 1)
               || (dice3 == 4 && flag34 == 1)
               || (dice3 == 5 && flag35 == 1)
               || (dice3 == 6 && flag36 == 1)
               || (dice3 == 7 && flag37 == 1)
               || (dice3 == 8 && flag38 == 1)
               || (dice3 == 9 && flag39 == 1)
               || (dice3 == 10 && flag40 == 1)
               );

            switch (dice3)
            {
                case 1:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.athletics;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag31 = 1;
                    break;
                case 2:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.badminton;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag32 = 1;
                    break;
                case 3:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.basketball;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag33 = 1;
                    break;
                case 4:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.chess;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag34 = 1;
                    break;
                case 5:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.football;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag35 = 1;
                    break;
                case 6:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.golf;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag36 = 1;
                    break;
                case 7:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.pingpong;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag37 = 1;
                    break;
                case 8:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.swimmers;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag38 = 1;
                    break;
                case 9:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.tennis;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag39 = 1;
                    break;
                case 10:
                    pictureBox_SPORT.Visible = true;
                    pictureBox_SPORT.BackgroundImage = Properties.Resources.volleyball;
                    button_START_SPORT.Text = "NEXT";
                    button_BACK_SPORT.Visible = false;
                    textBox_INPUT_SPORT.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count3++;
                    flag40 = 1;
                    break;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 & e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32));

        }
        private void button12_Click(object sender, EventArgs e)
        {
            panel_sport.Visible = false;
        }
        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_INPUT_SPORT.Text = "";
        }

        int giay3 = 60;
        private void timer3_Tick(object sender, EventArgs e)
        {
            giay3--;
            label_60_SPORT.Text = giay3.ToString();
            if (giay3 == 0)
                timer3.Stop();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            panel_sport.Visible = false;
        }

        //=====================================HOUSEHOLD GOODS====================================//
        int flag41 = 0;
        int flag42 = 0;
        int flag43 = 0;
        int flag44 = 0;
        int flag45 = 0;
        int flag46 = 0;
        int flag47 = 0;
        int flag48 = 0;
        int flag49 = 0;
        int flag50 = 0;
        int totalscore4 = 0;
        int count4 = 0;
        int dice4;
        int check4 = 0;
        private void button_START_HOUSEHOLD_Click(object sender, EventArgs e)
        {
            if (giay4 == 0)
                timer4.Stop();
            else
                timer4.Start();
            if (count4 > 0)
            {
                switch (dice4)
                {
                    case 1:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "airconditioner" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 2:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "fan" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 3:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "fridge" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 4:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "iron" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 5:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "knife" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 6:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "lamp" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 7:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "microwave" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 8:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "scale" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 9:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "television" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                    case 10:
                        if (textBox_INPUT_HOUSEHOLD.Text.ToLower().Replace(" ", "") == "washingmachine" && giay4 > 0)
                            totalscore4 += 2;
                        textBox_INPUT_HOUSEHOLD.Text = "";
                        break;
                }
            }


            if (count4 > 4)
            {
                label_POINT_HOUSEHOLD.Text = totalscore4.ToString();
                label_TIME_HOUSEHOLD.Text = (60 - giay4).ToString();
                timer4.Stop();
                label_60_HOUSEHOLD.Visible = false;
                label_S_HOUSEHOLD.Visible = false;
                groupBox_household.Visible = true;
                button_START_HOUSEHOLD.Visible = false;
                pictureBox_HOUSEHOLD.Visible = false;
                textBox_INPUT_HOUSEHOLD.Visible = false;
                label_HOUSEHOLD.Visible = false;
                check4 = 1;
                dataHousehold.Rows.Add(id, totalscore4, 60 - giay4);

                return;
            }
            Random rand = new Random();
            List<int> list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            do
            {
                dice4 = rand.Next(list.Count + 1);
            }
            while ((dice4 == 1 && flag41 == 1)
               || (dice4 == 2 && flag42 == 1)
               || (dice4 == 3 && flag43 == 1)
               || (dice4 == 4 && flag44 == 1)
               || (dice4 == 5 && flag45 == 1)
               || (dice4 == 6 && flag46 == 1)
               || (dice4 == 7 && flag47 == 1)
               || (dice4 == 8 && flag48 == 1)
               || (dice4 == 9 && flag49 == 1)
               || (dice4 == 10 && flag50 == 1)
               );

            switch (dice4)
            {
                case 1:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.airconditioner;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag41 = 1;
                    break;
                case 2:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.fan;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag42 = 1;
                    break;
                case 3:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.fridge;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag43 = 1;
                    break;
                case 4:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.iron;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag44 = 1;
                    break;
                case 5:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.knife;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag45 = 1;
                    break;
                case 6:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.lamp;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag46 = 1;
                    break;
                case 7:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.microwave;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag47 = 1;
                    break;
                case 8:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.scale;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag48 = 1;
                    break;
                case 9:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.tv;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag49 = 1;
                    break;
                case 10:
                    pictureBox_HOUSEHOLD.Visible = true;
                    pictureBox_HOUSEHOLD.BackgroundImage = Properties.Resources.washingmachine;
                    button_START_HOUSEHOLD.Text = "NEXT";
                    button_BACK_HOUSEHOLD.Visible = false;
                    textBox_INPUT_HOUSEHOLD.Visible = true;
                    label_60_SPORT.Visible = true;
                    label_S_SPORT.Visible = true;
                    count4++;
                    flag50 = 1;
                    break;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            panel_household.Visible = true;
        }


        int giay4 = 60;
        private void timer4_Tick(object sender, EventArgs e)
        {
            giay4--;
            label_60_SPORT.Text = giay4.ToString();
            if (giay4 == 0)
                timer4.Stop();
        }

        private void button_BACK_HOUSEHOLD_Click(object sender, EventArgs e)
        {
            panel_household.Visible = false;
        }

        private void button_OK_HOUSEHOLD_Click(object sender, EventArgs e)
        {
            panel_household.Visible = false;
        }

        private void textBox_INPUT_HOUSEHOLD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 & e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32));
        }

        private void textBox_INPUT_HOUSEHOLD_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_INPUT_HOUSEHOLD.Text = "";
        }

        private void button_ANIMAL_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_MARIO_ANIMAL.Visible = true;
        }

        private void button_ANIMAL_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_MARIO_ANIMAL.Visible = false;
        }

        private void button_VEHICLE_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_MARIO_VEHICLES.Visible = true;
        }

        private void button_VEHICLE_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_MARIO_VEHICLES.Visible = false;
        }

        private void button_SPORT_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_MARIO_SPORTS.Visible = true;
        }

        private void button_SPORT_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_MARIO_SPORTS.Visible = false;
        }

        private void button_HOUSEHOLD_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_MARIO_HOUSEHOLD.Visible = true;
        }

        private void button_HOUSEHOLD_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_MARIO_HOUSEHOLD.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn quay lại màn hình chính ?", "ALO ALO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (check1 == 1)
                {
                    flag1 = 0;
                    flag2 = 0;
                    flag3 = 0;
                    flag4 = 0;
                    flag5 = 0;
                    flag6 = 0;
                    flag7 = 0;
                    flag8 = 0;
                    flag9 = 0;
                    flag10 = 0;
                    totalscore = 0;
                    count = 0;
                    check1 = 0;

                    groupBox_ANIMAL.Visible = false;
                    button_START_ANIMAL.Text = "START";
                    button_START_ANIMAL.Visible = true;

                    button_BACK_ANIMAL.Visible = true;
                    label_ANIMAL.Visible = true;
                    timer1.Stop();
                    giay1 = 60;
                    label_60_ANIMAL.Text = "60";
                }
                if (check2 == 1)
                {
                    flag11 = 0;
                    flag12 = 0;
                    flag13 = 0;
                    flag14 = 0;
                    flag15 = 0;
                    flag16 = 0;
                    flag17 = 0;
                    flag18 = 0;
                    flag19 = 0;
                    flag20 = 0;
                    totalscore2 = 0;
                    count2 = 0;
                    check2 = 0;

                    groupBox_VEHICLE.Visible = false;
                    button_START_VEHICLE.Text = "START";
                    button_START_VEHICLE.Visible = true;

                    button_BACK_VEHICLE.Visible = true;
                    label_VEHICLE.Visible = true;
                    timer2.Stop();
                    giay2 = 60;
                    label_60_VEHICLE.Text = "60";
                }

                if (check3 == 1)
                {
                    flag31 = 0;
                    flag32 = 0;
                    flag33 = 0;
                    flag34 = 0;
                    flag35 = 0;
                    flag36 = 0;
                    flag37 = 0;
                    flag38 = 0;
                    flag39 = 0;
                    flag40 = 0;
                    totalscore3 = 0;
                    count3 = 0;
                    check3 = 0;

                    groupBox_SPORT.Visible = false;
                    button_START_SPORT.Text = "START";
                    button_START_SPORT.Visible = true;

                    button_BACK_SPORT.Visible = true;
                    label_SPORT.Visible = true;
                    timer3.Stop();
                    giay3 = 60;
                    label_60_SPORT.Text = "60";
                }

                if (check4 == 1)
                {
                    flag41 = 0;
                    flag42 = 0;
                    flag43 = 0;
                    flag44 = 0;
                    flag45 = 0;
                    flag46 = 0;
                    flag47 = 0;
                    flag48 = 0;
                    flag49 = 0;
                    flag50 = 0;
                    totalscore4 = 0;
                    count4 = 0;
                    check4 = 0;

                    groupBox_household.Visible = false;
                    button_START_HOUSEHOLD.Text = "START";
                    button_START_HOUSEHOLD.Visible = true;

                    button_BACK_HOUSEHOLD.Visible = true;
                    label_HOUSEHOLD.Visible = true;
                    timer4.Stop();
                    giay4 = 60;
                    label_60_HOUSEHOLD.Text = "60";
                }
                this.Hide();
                id++;
                label_ID.Text = id.ToString();
                panel_ID.Visible = true;

            }

        }

        private void button_OK_ID_Click(object sender, EventArgs e)
        {
            panel_ID.Visible = false;
        }
    }
}

