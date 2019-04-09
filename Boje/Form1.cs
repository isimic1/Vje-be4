using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Color> Boje = new List<Color>();
        int trenutna = -1;
        private void DodajBojuGumb_Click(object sender, EventArgs e)
        {
            if (UnosBoje.Text.Length>0)
            {
                Color boja = new Color();
                boja = Color.FromName(UnosBoje.Text);
                Boje.Add(boja);
                listaBoja.DataSource = null;
                listaBoja.DataSource = Boje;
                UnosBoje.Clear();
            }
        }

        private void PromijeniBojuGumb_Click(object sender, EventArgs e)
        {
            if (Boje.Count!=0)
            {
                BackColor = Boje.ElementAt(++trenutna % Boje.Count);
            }
        }
    }
}
