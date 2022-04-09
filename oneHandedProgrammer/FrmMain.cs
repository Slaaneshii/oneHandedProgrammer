using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            sttM.addASTTComparison("retour", "{ENTER}");
            sttM.addASTTComparison("au tour", "{ENTER}");
            sttM.addASTTComparison("autour", "{ENTER}");

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
    }
}
