using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace PCComm
{
    class SerialHelper
    {


        #region SetParityValues
        public void SetParityValues(object obj)
        {
            ((ComboBox)obj).Items.Clear();
            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetStopBitValues
        public void SetStopBitValues(object obj)
        {
            ((ComboBox)obj).Items.Clear();
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetPortNameValues
        public void SetPortNameValues(object obj)
        {
            ((ComboBox)obj).Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string str in ports)
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

       


    }
}
