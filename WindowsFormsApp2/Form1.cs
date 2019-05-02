using Music_Albums_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {

            var ar = new Form2() { Artist = new Artist() };
            if (ar.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ar.Artist);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Artist)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ll = new Form3() { Album = new Album() };
            if (ll.ShowDialog(this) == DialogResult.OK)
            {
                listBox2.Items.Add(ll.Album);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Album)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
    }
}
