using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study16_streamreader_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText);
            sb.Append(bChecked.ToString());
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath; //프로그램 실행 파일 위치
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //StreamWriter swSFdialog = new StreamWriter(strFilePath);

                //swSFdialog.WriteLine(tboxConfigData.Text);
                //swSFdialog.Close();

                File.WriteAllText(strFilePath, tboxConfigData.Text);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; //프로그램 실행 파일 위치
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if(OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                while(srOFDialog.EndOfStream == false)
                {
                    sb.Append(srOFDialog.ReadLine());
                    sb.Append("\r\n");
                }

                tboxConfigData.Text = sb.ToString();
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
        }
    }
}
