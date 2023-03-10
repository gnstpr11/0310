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
        CXMLcontrol _XML = new CXMLcontrol();

        Dictionary<string, string> _dData = new Dictionary<string, string>();
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
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString());
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();

            _dData.Add(CXMLcontrol._TEXT_DATA, strText);
            _dData.Add(CXMLcontrol._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLcontrol._NUMBER_DATA, iNumber.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath; //프로그램 실행 파일 위치
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //StreamWriter swSFdialog = new StreamWriter(strFilePath);

                //swSFdialog.WriteLine(tboxConfigData.Text);
                //swSFdialog.Close();

                // File.WriteAllText(strFilePath, tboxConfigData.Text);

                _XML.fXML_Writer(strFilePath, _dData);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; //프로그램 실행 파일 위치
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if(OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                //StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                //while(srOFDialog.EndOfStream == false)
                //{
                //    sb.Append(srOFDialog.ReadLine());
                //    sb.Append("\r\n");
                //}

                sb.Append(File.ReadAllText(strFilePath));

                File.ReadAllLines(strFilePath);

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);
            //numData.Value = int.Parse(strConfig[2]);

            tboxData.Text = _dData[CXMLcontrol._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLcontrol._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLcontrol._NUMBER_DATA]);
        }
    }
 }

