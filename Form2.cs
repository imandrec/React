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
    public partial class MyStockSimulatorForm : Form
    {
        NewSimulationForm child_form_1;
        ViewReportForm reportForm;

        public MyStockSimulatorForm()
        {
            InitializeComponent();
        }


        void Form1Closed(object sender, FormClosedEventArgs e)
        {
            child_form_1 = null;
            reportForm = null;
        }



        private void newSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (child_form_1 == null) // when we close the form then we can not open it again, but we can open again form 2(check)
            {
                child_form_1 = new NewSimulationForm();
                child_form_1.MdiParent = this;
                child_form_1.Show();//show he form
                child_form_1.FormClosed += new FormClosedEventHandler(this.Form1Closed);//call event handler
            }
            else
            {
                child_form_1.Activate();
            }
        }

		private void simulationReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (reportForm == null) 
            {
                reportForm = new ViewReportForm(null);
                reportForm.MdiParent = this;
                reportForm.Show();
                reportForm.FormClosed += new FormClosedEventHandler(this.Form1Closed);
            }
            else
            {
                child_form_1.Activate();
            }
        }
	}
}
