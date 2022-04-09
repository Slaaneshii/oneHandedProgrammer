using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;

namespace oneHandedProgrammer
{
    public partial class FrmDebug : Form
    {
        public FrmDebug()
        {
            InitializeComponent();
        }

        private void btnSendInput_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-6.0
            Thread t1 = new Thread(() =>
            {
                Thread.Sleep(2000);
            SendKeys.SendWait("k");
            });
            t1.Start();
        }

        private void FrmDebug_Load(object sender, EventArgs e)
        {
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("fr-FR"));
            engine.LoadGrammar(new DictationGrammar());
            engine.SpeechRecognized += Engine_SpeechRecognized;
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);
            tbxVoice.Text = System.Globalization.CultureInfo.CurrentCulture.Name;
        }

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            tbxVoice.Text=e.Result.Text;
        }
    }
}
