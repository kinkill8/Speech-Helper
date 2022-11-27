using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speech_Helper
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey700, Primary.Red400, Accent.Green700, TextShade.WHITE);
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            escucha.SetInputToDefaultAudioDevice();
            escucha.LoadGrammar(new DictationGrammar());
            escucha.SpeechRecognized += Detection;
            escucha.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;

        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            escucha.RecognizeAsyncStop();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Close();
            ventana1.Show();
        }
    }
}
