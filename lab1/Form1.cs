using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace lab1
{
    public partial class Form1 : Form
    {
        int check = 1;
        public Form1()
        {
            InitializeComponent();


            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
            "Привет",
            "Hello"
            };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


            //timerPrgrsBar.Interval = 500;
            //timerPrgrsBar.Enabled = true;
            notifyIcon1.ShowBalloonTip(10, "Лабораторная работа 1", "ООП", ToolTipIcon.Info);
        }

        void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }



        private void btnPress_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    btnPress.BackColor = Color.Green;
                    btnHover.BackColor = Color.Red;
                    check++;
                    break;
                case 2:
                    btnPress.BackColor = Color.White;
                    btnHover.BackColor = Color.White;
                    check = 1;
                    break;
            }
;
        }

        private void btnHover_MouseHover(object sender, EventArgs e)
        {
            btnHover.BackColor = Color.Green;
            btnPress.BackColor = Color.Red;
        }

        private void btnHover_MouseLeave(object sender, EventArgs e)
        {
            btnHover.BackColor = Color.White;
            btnPress.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelTrackBar.Text = String.Format("Текущее значение: {0}", trackBar.Value);
        }

        private void rbFirstImg_CheckedChanged(object sender, EventArgs e)
        {
            FirstImg.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Claude_Monet%2C_Impression%2C_soleil_levant.jpg/350px-Claude_Monet%2C_Impression%2C_soleil_levant.jpg";
        }

        private void rbSecondImg_CheckedChanged(object sender, EventArgs e)
        {
            FirstImg.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTsE3jrUBN0t87bLoKF8zyUsMisEAqxUyMaZCOaau1s0F4j_7F3OWBxg96vuMkAeQ_6hkY&usqp=CAU";
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void btnClearLable_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btnAddNewBtn_Click(object sender, EventArgs e)
        {
            Button oldbtn = (Button)sender;
            Button newbtn = new Button();
            newbtn.Text = "New button";
            newbtn.Width = oldbtn.Width;
            newbtn.Height = oldbtn.Height;
            newbtn.Location = new Point(oldbtn.Location.X, oldbtn.Location.Y + 60);
            newbtn.Click += new EventHandler(btnAddNewBtn_Click);
            newbtn.MouseLeave += new EventHandler(buttondel_Click);
            this.Controls.Add(newbtn);
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void btnTimerMode_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
                textBox2.Text = " ";
            }
            else
            {
                timer.Start();
            }
        }

        private void timerPrgrsBar_Tick(object sender, EventArgs e)
        {
            //progressBar.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar.Value == progressBar.Maximum)
            {
                MessageBox.Show("Error\nProgressBar full!");
            }
            else
            {
                progressBar.Value += 10;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTree_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        private void btnHideTree_Click(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }

    }
}

