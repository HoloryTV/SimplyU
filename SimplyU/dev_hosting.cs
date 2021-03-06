﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_hosting : Form
    {
        public dev_hosting()
        {
            InitializeComponent();
        }

        private void dev_hosting_Load(object sender, EventArgs e)
        {
            Process.Start("StartServer.bat");
            Application.Exit();
        }

        private void ipv4_Tick(object sender, EventArgs e)
        {
            lbl_ip.Text = "Check ipconfig";
            lbl_stats.Text = "Hosting Online!";
        }

        private void dev_hosting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}