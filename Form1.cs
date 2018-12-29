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
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace Ploozer
{

    public partial class Form1 : Form
    {

        public Point mouseLocation;

        Process[] procs;
        public Form1()
        {
            InitializeComponent();
        }
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
                
            }
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\BattlEye"))
            {
                System.Diagnostics.Process.Start(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\BattlEye");
            }
            else
            {
                if (Directory.Exists(@"D:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\BattlEye"))
                {
                    System.Diagnostics.Process.Start(@"D:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\BattlEye");
                }
                    
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string file = "deleteidf";
            Process.Start(file);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("@echo off");
            cmd.StandardInput.WriteLine("ipconfig /release");
            cmd.StandardInput.WriteLine("ipconfig /flushdns");
            cmd.StandardInput.WriteLine("ipconfig /renew");
            cmd.StandardInput.WriteLine("ipconfig /flushdns");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                if (Directory.Exists(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\EasyAntiCheat\EasyAntiCheat_Setup"))
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\EasyAntiCheat\EasyAntiCheat_Setup");
                }
                else
                {
                    if (Directory.Exists(@"D:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\EasyAntiCheat\EasyAntiCheat_Setup"))
                    {
                        System.Diagnostics.Process.Start(@"D:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\EasyAntiCheat\EasyAntiCheat_Setup");
                    }

                }

            }
        }
            private void button6_Click(object sender, EventArgs e)
        {
            string file = "igothoeeeeees";
            Process.Start(file);

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("@@echo off");
            cmd.StandardInput.WriteLine("rem Hostname change");
            cmd.StandardInput.WriteLine("SET TextFile = D:\antiOS\host.txt");
            cmd.StandardInput.WriteLine("ipconfig /renew");
            cmd.StandardInput.WriteLine("ipconfig /flushdns");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string file = "hardware";
            Process.Start(file);
        }

        private void button9_Click(object sender, EventArgs e)
        {
                string file = "dark_cleaner2";
            Process.Start(file);
        }

        private void button8_Click(object sender, EventArgs e)
        {    
                string file = "altstreamview";
            Process.Start(file);
        }

        private void button10_Click(object sender, EventArgs e)
        {
                string file = "main_cleaner";
            Process.Start(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {       
                string file = "loop";
            Process.Start(file);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/FortniteMods");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
            else
            {          
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public bool minimize;
        private string Assets;

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
