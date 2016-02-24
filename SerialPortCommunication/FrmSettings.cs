using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PCComm
{
    public partial class FrmSettings : Form
    {
        SerialHelper sh = new SerialHelper();

        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(Object obj)
        {
            InitializeComponent();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
           

            sh.SetParityValues(cboParityHMI);
            sh.SetParityValues(cboParityMain);
            sh.SetPortNameValues(cboPortHMI);
            sh.SetPortNameValues(cboPortMain);
            sh.SetStopBitValues(cboStopHMI);
            sh.SetStopBitValues(cboStopMain);


            SetDefaults();
        }

        private void SetDefaults()
        {
            if(cboPortHMI.Items.Count > 0)
                cboPortHMI.SelectedIndex = 0;
            if (cboPortMain.Items.Count > 0)
                cboPortMain.SelectedIndex = 0;





            cboBaudHMI.SelectedText = ConfigHelper.GetValueFromConfig("HMIBaudRate");
            cboBaudMain.SelectedText = ConfigHelper.GetValueFromConfig("MainBaudRate");
            cboParityHMI.SelectedText = ConfigHelper.GetValueFromConfig("HMIParity");
            cboParityMain.SelectedText = ConfigHelper.GetValueFromConfig("MainParity");
            cboStopHMI.SelectedText = ConfigHelper.GetValueFromConfig("HMIStopBit");
            cboStopMain.SelectedText = ConfigHelper.GetValueFromConfig("MainStopBit");
            cboDataHMI.SelectedText = ConfigHelper.GetValueFromConfig("HMIDataBits");
            cboDataMain.SelectedText = ConfigHelper.GetValueFromConfig("MainDataBits");
            if (ConfigHelper.GetValueFromConfig("TransmissionType") == "HEX")
                this.rdoHex.Checked = true;
            else
                this.rdoText.Checked = true;
            cbxHMITimer.SelectedText = ConfigHelper.GetValueFromConfig("HMITimer");
            cbxMainTimer.SelectedText = ConfigHelper.GetValueFromConfig("MainTimer");
            cbxTestCount.SelectedText = ConfigHelper.GetValueFromConfig("TestCount");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sh.SetPortNameValues(cboPortHMI);
            sh.SetPortNameValues(cboPortMain);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ConfigHelper.SetValueFromConfig("HMIBaudRate", cboBaudHMI.Text);
            ConfigHelper.SetValueFromConfig("MainBaudRate", cboBaudMain.Text);
            ConfigHelper.SetValueFromConfig("HMIParity", cboParityHMI.Text);
            ConfigHelper.SetValueFromConfig("MainParity", cboParityMain.Text);
            ConfigHelper.SetValueFromConfig("HMIStopBit", cboStopHMI.Text);
            ConfigHelper.SetValueFromConfig("MainStopBit", cboStopMain.Text);
            ConfigHelper.SetValueFromConfig("HMIDataBits", cboDataHMI.Text);
            ConfigHelper.SetValueFromConfig("MainDataBits", cboDataMain.Text);
            ConfigHelper.SetValueFromConfig("HMITimer", cbxHMITimer.Text);
            ConfigHelper.SetValueFromConfig("MainTimer", cbxMainTimer.Text);
            ConfigHelper.SetValueFromConfig("TestCount", cbxTestCount.Text);
            if (rdoHex.Checked)
                ConfigHelper.SetValueFromConfig("TransmissionType", "HEX");
            else if(rdoText.Checked)
                ConfigHelper.SetValueFromConfig("TransmissionType", "TEXT");

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
