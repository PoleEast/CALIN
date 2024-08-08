using GitHub.secile.Video;
using PCI_DMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SixLabors.Fonts;

namespace CALIN
{
    internal class Init
    {
        ///////讀寫INI檔/////////////////
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);
        internal static void dmc04pi_init(ref ushort gCardNo)
        {
            short rc;
            for (ushort nodeid = 1; nodeid <= 4; nodeid++)
            {
                switch (nodeid)
                {
                    case 4:
                        rc = CPCI_DMC.CS_DMC_01_set_rm_04pi_opulser_mode(gCardNo, nodeid, 0, 2);//plus/dir
                        break;
                    default:
                        rc = CPCI_DMC.CS_DMC_01_set_rm_04pi_opulser_mode(gCardNo, nodeid, 0, 1);//cw/ccw
                        break;
                }
                /////////////////////////////
                //Cmdreset(nodeid)
                rc = CPCI_DMC.CS_DMC_01_set_rm_04pi_svon_polarity(gCardNo, nodeid, 0, 1);//SVON 負極性   //low active
                rc = CPCI_DMC.CS_DMC_01_rm_04pi_set_MEL_polarity(gCardNo, nodeid, 0, 0);//MEL正極性
                rc = CPCI_DMC.CS_DMC_01_rm_04pi_set_PEL_polarity(gCardNo, nodeid, 0, 0);//PEL正極性

            }
        }
        internal static void Read_INI_Set()
        {
            string iniPath = @".\setup\config.ini";
            Read_ini_Setup(iniPath);
        }
        internal static void Read_ini_Setup(string iniPath)
        {

            StringBuilder data = new StringBuilder(255);
            //讀出ini

            string section = "setting";

            GetPrivateProfileString(section, "txtPOS1s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS2s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS3s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS4s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS5s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS6s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS7s", "0", data, 255, iniPath);

            GetPrivateProfileString(section, "txtPOS8s", "0", data, 255, iniPath);
        }
        internal static void  CameraInit(ref ComboBox cmbCameraID)
        {
            string[] devices = UsbCamera.FindDevices();
            foreach (string device in devices)
            {
                cmbCameraID.Items.Add(device);
            }
        }
        public static SixLabors.Fonts.Font font_setting()
        {
            var fontCollection = new FontCollection();
            SixLabors.Fonts.FontFamily fontFamily = fontCollection.Add("..\\..\\..\\Assets\\CONSOLA.TTF");
            return fontFamily.CreateFont(11, SixLabors.Fonts.FontStyle.Bold);
        }
    }
}
