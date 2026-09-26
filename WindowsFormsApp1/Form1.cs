using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image[] images =
        {
            Properties.Resources.Kokichi,
            Properties.Resources.Korekiyo,
            Properties.Resources.Gonta,
            Properties.Resources.Kaede,
            Properties.Resources.Shuichi,
            Properties.Resources.Miu,
            Properties.Resources.Rantaro,
            Properties.Resources.Himiko,
            Properties.Resources.Tenko,
            Properties.Resources.Kaito,
            Properties.Resources.Maki,
            Properties.Resources.Keebo,
            Properties.Resources.Tsumugi,
            Properties.Resources.Ryoma,
            Properties.Resources.Kirumi,
            Properties.Resources.Angie
        };

        string[] names =
        {
            "Kokichi",
            "Korekiyo",
            "Gonta",
            "Kaede",
            "Shuichi",
            "Miu",
            "Rantaro",
            "Himiko",
            "Tenko",
            "Kaito",
            "Maki",
            "Keebo",
            "Tsumugi",
            "Ryoma",
            "Kirumi",
            "Angie"
        };

        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = random.Next(names.Length);

            label2.Text = names[index];
            pictureBox1.Image = images[index];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Neocities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
