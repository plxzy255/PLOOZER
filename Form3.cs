using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ploozer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("settings.txt",System.IO.FileMode.OpenOrCreate, isolatedStorageFile))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                        {
                            var activated = activation.isActivated(sr.ReadLine());
                            if (!activated)
                            {
                                //goto activationform
                            }
                            else
                            {  
                                Form1 myForm = new Form1();
                                myForm.ShowDialog();
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    sb.Append(c.Text);
                }
            }
            activation.activateSoftware(sb.ToString());
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
