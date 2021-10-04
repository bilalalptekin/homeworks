using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            button1.BackColor = Color.Black;
                            break;
                        case 1:
                            button1.BackColor = Color.Blue;
                            break;
                        case 2:
                            button1.BackColor = Color.Green;
                            break;
                        case 3:
                            button1.BackColor = Color.Yellow;
                            break;
                        default:
                            MessageBox.Show("Herhangi Bir Renk seçin");
                            break;
                    };
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            button2.BackColor = Color.Black;
                            break;
                        case 1:
                            button2.BackColor = Color.Blue;
                            break;
                        case 2:
                            button2.BackColor = Color.Green;
                            break;
                        case 3:
                            button2.BackColor = Color.Yellow;
                            break;
                        default:
                            MessageBox.Show("Herhangi Bir Renk seçin");
                            break;
                    };
                    break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            textBox1.BackColor = Color.Black;
                            break;
                        case 1:
                            textBox1.BackColor = Color.Blue;
                            break;
                        case 2:
                            textBox1.BackColor = Color.Green;
                            break;
                        case 3:
                            textBox1.BackColor = Color.Yellow;
                            break;
                        default:
                            MessageBox.Show("Herhangi Bir Renk seçin");
                            break;
                    };
                    break;
                case 3:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                           this.BackColor = Color.Black;
                            break;
                        case 1:
                            this.BackColor = Color.Blue;
                            break;
                        case 2:
                            this.BackColor = Color.Green;
                            break;
                        case 3:
                            this.BackColor = Color.Yellow;
                            break;
                        default:
                            MessageBox.Show("Herhangi Bir Renk seçin");
                            break;
                    };
                    break;


                default:
                    MessageBox.Show("Herhangi Bİr Nesne seçin");
                    break;
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
