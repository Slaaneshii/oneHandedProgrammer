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

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace oneHandedProgrammer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        STTComparisonManager sttM = new STTComparisonManager();
        VoiceHelper vh;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            vh = new VoiceHelper(sttM);
            vh.callback = displayInfo;
        }

        private void displayInfo(ComparisonSTT STT)
        {
            tbxConverti.Text = STT.Converti;
            tbxEntendu.Text = STT.Entendu;
        }

        private void btnAdd_Click(object sender, EventArgs e) 
        {
            sttM.addASTTComparison(tbxEntendu.Text, tbxConverti.Text);
            vh.comparisonManager = sttM;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serialize();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "slaanesh files (*.slaanesh)|*.slaanesh";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                deserialize(path);
            }
        }

        private void serialize()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"./savedVoice.slaanesh";
            //Stream s = File.Open(path,FileMode.Create);
            //BinaryFormatter b = new BinaryFormatter();
            //b.Serialize(s, sttM);
            //s.Close();
            SlaXmlSerializer.serializeXML(sttM, path);
        }

        private void deserialize(string path)
        {
            //Stream s = File.Open(path, FileMode.Open);
            //BinaryFormatter b = new BinaryFormatter();
            //sttM = (STTComparisonManager)b.Deserialize(s);
            //vh.comparisonManager = sttM;
            //s.Close();
            STTComparisonManager sttT = SlaXmlSerializer.deserializeXML<STTComparisonManager>(path);
            sttM._listManager = sttT._listManager;
        }

        private void tbrTransparency_Scroll(object sender, EventArgs e)
        {
            this.Opacity = tbrTransparency.Value / 100.0;
        }
    }
}
