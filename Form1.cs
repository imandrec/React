using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        string Username;
        string Password;
        public Form1()
        {
            InitializeComponent();
            this.Text = "My Stock Simulator Log In";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            Password = textBox2.Text;

            InitializeComponent();

            if (Username.Equals("test") && Password.Equals("Test123"))
            {
                MyStockSimulatorForm secondForm = new MyStockSimulatorForm();
                secondForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username/password combination");
                if (DialogResult == DialogResult.OK)
                    Application.Exit();
            }

        }
    }
}
