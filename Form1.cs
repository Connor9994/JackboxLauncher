using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackboxLauncher
{
    public partial class KaOs : Form
    {
        public KaOs()
        {
            InitializeComponent();
        }

        private void KaOsBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Connor9994/JackboxLauncher");
        }

        private void KaOs_Load(object sender, EventArgs e)
        {
            DropBox.SelectedIndex = 0;
            if (!File.Exists("1\\The Jackbox Party Pack.exe"))
            {
                Application.Exit();
            }
        }

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropBox.SelectedIndex)
                {
                case 0:
                    GamePicBox.Image = Properties.Resources._1;
                    break;
                case 1:
                    GamePicBox.Image = Properties.Resources._2;
                    break;
                case 2:
                    GamePicBox.Image = Properties.Resources._3;
                    break;
                case 3:
                    GamePicBox.Image = Properties.Resources._4;
                    break;
                case 4:
                    GamePicBox.Image = Properties.Resources._5;
                    break;
                case 5:
                    GamePicBox.Image = Properties.Resources._6;
                    break;
                case 6:
                    GamePicBox.Image = Properties.Resources._7;
                    break;
                case 7:
                    GamePicBox.Image = Properties.Resources._8;
                    break;
                case 8:
                    GamePicBox.Image = Properties.Resources._9;
                    break;
                case 9:
                    GamePicBox.Image = Properties.Resources._10;
                    break;
                case 10:
                    GamePicBox.Image = Properties.Resources._11;
                    break;
                case 11:
                    GamePicBox.Image = Properties.Resources._N;
                    break;
                }
        }

        private void GamePicBox_Click(object sender, EventArgs e)
        {
            switch (DropBox.SelectedIndex)
            {
                case 0:
                    Process.Start("https://store.steampowered.com/app/331670/");
                    break;
                case 1:
                    Process.Start("https://store.steampowered.com/app/397460/");
                    break;
                case 2:
                    Process.Start("https://store.steampowered.com/app/434170/");
                    break;
                case 3:
                    Process.Start("https://store.steampowered.com/app/610180/");
                    break;
                case 4:
                    Process.Start("https://store.steampowered.com/app/774461/");
                    break;
                case 5:
                    Process.Start("https://store.steampowered.com/app/1005300/");
                    break;
                case 6:
                    Process.Start("https://store.steampowered.com/app/1211630/");
                    break;
                case 7:
                    Process.Start("https://store.steampowered.com/app/1552350/");
                    break;
                case 8:
                    Process.Start("https://store.steampowered.com/app/1850960");
                    break;
                case 9:
                    Process.Start("https://store.steampowered.com/app/2216830");
                    break;
                case 10:
                    Process.Start("https://store.steampowered.com/app/3364070");
                    break;
                case 11:
                    Process.Start("https://store.steampowered.com/app/2652000");
                    break;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Process PlayGame = new Process();

            switch (DropBox.SelectedIndex)
            {
                case 0:
                    Directory.SetCurrentDirectory("1");
                    Process.Start("The Jackbox Party Pack.exe");
                    break;
                case 1:
                    Directory.SetCurrentDirectory("2");
                    Process.Start("The Jackbox Party Pack 2.exe");
                    break;
                case 2:
                    Directory.SetCurrentDirectory("3");
                    Process.Start("The Jackbox Party Pack 3.exe");
                    break;
                case 3:
                    Directory.SetCurrentDirectory("4");
                    Process.Start("The Jackbox Party Pack 4.exe");
                    break;
                case 4:
                    Directory.SetCurrentDirectory("5");
                    Process.Start("The Jackbox Party Pack 5.exe");
                    break;
                case 5:
                    Directory.SetCurrentDirectory("6");
                    Process.Start("The Jackbox Party Pack 6.exe");
                    break;
                case 6:
                    Directory.SetCurrentDirectory("7");
                    Process.Start("The Jackbox Party Pack 7.exe");
                    break;
                case 7:
                    Directory.SetCurrentDirectory("8");
                    Process.Start("The Jackbox Party Pack 8.exe");
                    break;
                case 8:
                    Directory.SetCurrentDirectory("9");
                    Process.Start("The Jackbox Party Pack 9.exe");
                    break;
                case 9:
                    Directory.SetCurrentDirectory("10");
                    Process.Start("The Jackbox Party Pack 10.exe");
                    break;
                case 10:
                    Directory.SetCurrentDirectory("11");
                    Process.Start("The Jackbox Party Pack 11.exe");
                    break;
                case 11:
                    Directory.SetCurrentDirectory("N");
                    Process.Start("The Jackbox Naughty Pack.exe");
                    break;
            }

            Application.Exit();
        }
    }
}
