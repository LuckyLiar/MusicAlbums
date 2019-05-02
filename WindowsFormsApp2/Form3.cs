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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Album Album { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Album.AlbumName = textBox56.Text;
            

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Album.AlbumName = textBox56.Text;
            Album.Duration = textBox1.Text;
            Album.Year = dateTimePicker1.Value;

            foreach (string i in Album.MusicGenres)
            {
                if (comboBox1.Text == i)
                {
                    Album.MusicGenre = i;
                    break;
                }
                else
                {
                    Album.MusicGenre = "Другое";
                }
            }

        }
    }
}
