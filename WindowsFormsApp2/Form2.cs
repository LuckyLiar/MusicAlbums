using Music_Albums_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Artist Artist { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artist.NickName = textBox1.Text;
            Artist.About = textBox2.Text;
            Artist.DOB = dateTimePicker1.Value;

            foreach (string i in Artist.MusicGenres)
            {
                if (comboBox1.Text == i)
                {
                    Artist.MusicGenre = i;
                    break;
                }
                else
                {
                    Artist.MusicGenre = "Другое";
                }
            }

        }
    }
}
