using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PCComm
{
    public partial class FrmMainTest : Form
    {
        /// <summary>
        /// 触控板
        /// </summary>
        CommunicationManager commRX = new CommunicationManager(CommunicationManager.DirectionType.Rx);
        /// <summary>
        /// 电源板
        /// </summary>
        CommunicationManager commTX = new CommunicationManager();

        public FrmMainTest()
        {
            InitializeComponent();
        }

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
            if (frmSettings.DialogResult == DialogResult.OK)
            {
                this.progressBar1.Maximum = int.Parse(ConfigHelper.GetValueFromConfig("TestCount"));
            }

        }

        private void FrmMainTest_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = int.Parse(ConfigHelper.GetValueFromConfig("TestCount"));
        }

        //button stop
        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        //button start
        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 0;


            commRX.PortName = ConfigHelper.GetValueFromConfig("HMIPortName");
            commRX.BaudRate = ConfigHelper.GetValueFromConfig("HMIBaudRate");
            commRX.DataBits = ConfigHelper.GetValueFromConfig("HMIDataBits");
            commRX.Parity = ConfigHelper.GetValueFromConfig("HMIParity");
            commRX.StopBits = ConfigHelper.GetValueFromConfig("HMIStopBit");


            commTX.PortName = ConfigHelper.GetValueFromConfig("MainPortName");
            commTX.BaudRate = ConfigHelper.GetValueFromConfig("MainBaudRate");
            commTX.DataBits = ConfigHelper.GetValueFromConfig("MainDataBits");
            commTX.Parity = ConfigHelper.GetValueFromConfig("MainParity");
            commTX.StopBits = ConfigHelper.GetValueFromConfig("MainStopBit");


            if (ConfigHelper.GetValueFromConfig("TransmissionType") == "HEX")
                commRX.CurrentTransmissionType = CommunicationManager.TransmissionType.Hex;
            else
                commRX.CurrentTransmissionType = CommunicationManager.TransmissionType.Text;
            commRX.DisplayWindow = lvHMI;
            commTX.DisplayWindow = lvMain;

            commRX.OpenPort();
            commTX.OpenPort();

            if ((true != commRX.isPortOpen))
            { 
                MessageBox.Show("接收模块端口未打开");
                return;
            }
            if ((true != commTX.isPortOpen))
            {
                MessageBox.Show("发送模块端口未打开");
                return;
            }


            for (int i = 0; i < int.Parse(ConfigHelper.GetValueFromConfig("TestCount")); i++)
            {
                commRX.WriteData("FF FF 04 01 01 01 07");
                Thread.Sleep(int.Parse(ConfigHelper.GetValueFromConfig("HMITimer")));
                this.progressBar1.Increment(1);
                
                
            }
            
        }

        private  void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.Show();
        }
    }
}
