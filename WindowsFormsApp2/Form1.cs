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

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "album|*.album" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(AddingAlbums));
            var file = File.OpenRead(ofd.FileName);
            var site = (AddingAlbums)xs.Deserialize(file);
            file.Close();

            listBox1.Items.Clear();
            foreach (var s in site.Albumlist)
            {
                listBox2.Items.Add(s);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "album|*.album" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var site = new AddingAlbums();
            {
                site.Albumlist = listBox2.Items.OfType<Album>().ToList();
            };

            var xs = new XmlSerializer(typeof(AddingAlbums));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, site);
            file.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "album|*.album" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var alb = new AddingAlbums();
            {
                alb.Albumlist = listBox2.Items.OfType<Album>().ToList();
            };

            var xs = new XmlSerializer(typeof(AddingAlbums));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, alb);
            file.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "album|*.album" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(AddingAlbums));
            var file = File.OpenRead(ofd.FileName);
            var alb = (AddingAlbums)xs.Deserialize(file);
            file.Close();

            listBox2.Items.Clear();
            foreach (var s in alb.Albumlist)
            {
                listBox2.Items.Add(s);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "artist|*.artist" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var art = new AddingArtist();
            {
                art.Artistlist = listBox1.Items.OfType<Artist>().ToList();
            };

            var xs = new XmlSerializer(typeof(AddingArtist));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, art);
            file.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "artist|*.artist" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(AddingArtist));
            var file = File.OpenRead(ofd.FileName);
            var alb = (AddingArtist)xs.Deserialize(file);
            file.Close();

            listBox1.Items.Clear();
            foreach (var s in alb.Artistlist)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
