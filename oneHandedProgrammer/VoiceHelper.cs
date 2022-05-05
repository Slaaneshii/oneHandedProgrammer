using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace oneHandedProgrammer
{
    internal class VoiceHelper
    {
        public  Action<ComparisonSTT> callback;
        public STTComparisonManager comparisonManager;
        public VoiceHelper(STTComparisonManager stt)
        {
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("fr-FR"));
            engine.LoadGrammar(new DictationGrammar());
            engine.SpeechRecognized += Engine_SpeechRecognized;
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);
            comparisonManager = stt;
        }
        
        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-6.0
        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ComparisonSTT compared;
            string heared = e.Result.Text.ToLower();
            compared = comparisonManager.convertSTT(heared);
            SendKeys.SendWait(compared.Converti);
            callback(compared);
        }
    }
}
