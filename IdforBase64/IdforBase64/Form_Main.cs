using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace IdforBase64
{
    public partial class Form_Main : Skin_Mac
    {
        public Form_Main()
        {
            InitializeComponent();
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["ProcessorId"].Value.ToString();//获取CPU的硬件ID标志
                break;
            }
            la_cpuID.Text = "(E.g: " + strID+" )";
        }

        private void bt_encryption_Click(object sender, EventArgs e)
        {
            string cpuid = tb_Dkey.Text.Trim();
            //string key = tb_Akey.Text.Trim();
            if (cpuid.Equals(""))
            {
                MessageBox.Show("Please enter  the Devive Key！");
                return;
            }
            byte[] bytes = Encoding.Default.GetBytes(cpuid);
            tb_Akey.Text = Base64Encoder.GetEncoded(bytes);
        }

        private void bt_decrypt_Click(object sender, EventArgs e)
        {
            //string cpuid = tb_Dkey.Text.Trim();
            string key = tb_Akey.Text.Trim();
            if (key.Equals(""))
            {
                MessageBox.Show("Please enter  the Activation Key！");
                return;
            }
            byte[] bytes = Base64Decoder.GetDecoded(key);
            tb_Dkey.Text = Encoding.Default.GetString(bytes);
        }

        private void bt_encryption_MouseEnter(object sender, EventArgs e)
        {
        }

        private void bt_encryption_MouseLeave(object sender, EventArgs e)
        {
            bt_encryption.BackgroundImage = IdforBase64.Properties.Resources.anniu2;
        }

        private void bt_decrypt_MouseEnter(object sender, EventArgs e)
        {
        }

        private void bt_decrypt_MouseLeave(object sender, EventArgs e)
        {
            bt_decrypt.BackgroundImage = IdforBase64.Properties.Resources.anniu2;
        }

        private void bt_encryption_MouseDown(object sender, MouseEventArgs e)
        {
            bt_encryption.BackgroundImage = IdforBase64.Properties.Resources.anniu3;
        }

        private void bt_decrypt_MouseHover(object sender, EventArgs e)
        {
        }

        private void bt_decrypt_MouseDown(object sender, MouseEventArgs e)
        {
            bt_decrypt.BackgroundImage = IdforBase64.Properties.Resources.anniu3;
        }
    }
}
