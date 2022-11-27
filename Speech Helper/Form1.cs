using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speech_Helper
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer voz;
        List<VoiceInfo> listvoces = new List<VoiceInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey700, Primary.Red400, Accent.Green700, TextShade.WHITE);

            voz = new SpeechSynthesizer();
            foreach (InstalledVoice x in voz.GetInstalledVoices())
            {
                listvoces.Add(x.VoiceInfo);
                cbseleccionvoz.Items.Add(x.VoiceInfo.Name);
            }

            cbseleccionvoz.SelectedIndex = 0;
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            voz = new SpeechSynthesizer();

            int ind;
            double volumen = tbviolumen.Value;
            double velocidad = tbvelocidad.Value;

            ind = cbseleccionvoz.SelectedIndex;
            string nombrevoces = listvoces.ElementAt(ind).Name;
            voz.SelectVoice(nombrevoces);

            voz.Volume = (int)volumen;
            voz.Rate = (int)velocidad;
            voz.SpeakAsync(txtleer.Text);

            btnpausar.Text = "pausado";
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (voz != null)
            {
                voz.Dispose();
            }
        }

        private void btnpausar_Click(object sender, EventArgs e)
        {
            if (voz != null)
            {
                if (voz.State == SynthesizerState.Speaking)
                {
                    voz.Pause(); btnpausar.Text = "RESUMEN";
                }
                else if (voz.State == SynthesizerState.Paused)
                {
                    voz.Resume(); btnpausar.Text = "PAUSADO";
                }

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                voz = new SpeechSynthesizer();
                using (SaveFileDialog vai = new SaveFileDialog())
                {
                    vai.Filter = "Wav files|*.wav";
                    if (vai.ShowDialog() == DialogResult.OK)
                    {
                        int ind;
                        double volumen = tbviolumen.Value;
                        double velocidad = tbvelocidad.Value;

                        ind = cbseleccionvoz.SelectedIndex;
                        string nombrevoces = listvoces.ElementAt(ind).Name;
                        voz.SelectVoice(nombrevoces);

                        FileStream team = new FileStream(vai.FileName, FileMode.Create, FileAccess.Write);
                        voz.SetOutputToWaveStream(team);
                        voz.Speak(txtleer.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aplicacion creada y codificada por renato sepulveda");
        }

        private void btnirareconocimiento_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            this.Hide();
            ventana2.Show();
        }
    }
}
