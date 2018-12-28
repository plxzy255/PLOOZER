using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ploozer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Process[] procs;
        private void GetProcesses()
        {
            procs = Process.GetProcesses();
            if(Convert.ToInt32(label2.Text)!= procs.Length)
            {
                listBox1.Items.Clear();
                for(int i=0; i<procs.Length; i++)
                {
                    listBox1.Items.Add(procs[i].ProcessName);
                }
                label2.Text = procs.Length.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
