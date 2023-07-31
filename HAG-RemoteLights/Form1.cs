using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace HAGRemoteLights
{
    public partial class Form1 : Form
    {

        private KeyboardHook keyboardhook;

        int _StartInSeconds = 2;
        double _LastPos = 0;
        long GesamtDeltaSleep = 0;
        string _GlobalCmd = "";
        private SoundPlayer player;
        long _InitialTime = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);

            this.KeyPreview = true;
            RegisterHotkeys();
            InitializeSound();
        }


        private void InitializeSound()
        {
            player = new SoundPlayer();
            player.LoadCompleted += new AsyncCompletedEventHandler(player_LoadCompleted);
        }

        private void player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            _InitialTime = Millis();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
            pic1.Tag = false;
            pic2.Tag = false;
            pic3.Tag = false;
            pic4.Tag = false;
            pic5.Tag = false;
            pic6.Tag = false;
            pic7.Tag = false;
            pic8.Tag = false;
        }

        private void RegisterHotkeys()
        {
            this.keyboardhook = new KeyboardHook(true);

            // add keys to listen or set HookAllKeys to true to listen all
            this.keyboardhook.AddHookedKey(Keys.F1);
            this.keyboardhook.AddHookedKey(Keys.F2);
            this.keyboardhook.AddHookedKey(Keys.F3);
            this.keyboardhook.AddHookedKey(Keys.F4);
            this.keyboardhook.AddHookedKey(Keys.F5);
            this.keyboardhook.AddHookedKey(Keys.F6);
            this.keyboardhook.AddHookedKey(Keys.F7);
            this.keyboardhook.AddHookedKey(Keys.F8);

            this.keyboardhook.KeyUp += new KeyEventHandler(keyboardhook_KeyUp);
            this.keyboardhook.KeyDown += new KeyEventHandler(keyboardhook_KeyDown);
            this.keyboardhook.Hook();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // dispose keyboard hook
            this.keyboardhook.KeyUp -= keyboardhook_KeyUp;
            this.keyboardhook.Dispose();
        }

        void keyboardhook_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    PicOff(pic1);
                    break;
                case Keys.F2:
                    PicOff(pic2);
                    break;
                case Keys.F3:
                    PicOff(pic3);
                    break;
                case Keys.F4:
                    PicOff(pic4);
                    break;
                case Keys.F5:
                    PicOff(pic5);
                    break;
                case Keys.F6:
                    PicOff(pic6);
                    break;
                case Keys.F7:
                    PicOff(pic7);
                    break;
                case Keys.F8:
                    PicOff(pic8);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            e.Handled = true;
        }

        void keyboardhook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    PicOn(pic1);
                    break;
                case Keys.F2:
                    PicOn(pic2);
                    break;
                case Keys.F3:
                    PicOn(pic3);
                    break;
                case Keys.F4:
                    PicOn(pic4);
                    break;
                case Keys.F5:
                    PicOn(pic5);
                    break;
                case Keys.F6:
                    PicOn(pic6);
                    break;
                case Keys.F7:
                    PicOn(pic7);
                    break;
                case Keys.F8:
                    PicOn(pic8);
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            e.Handled = true;
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private bool IsPlayerPlay()
        {
            return GetCurrentPos() > 1;
        }

        private long GetCurrentPos()
        {
            if (player.IsLoadCompleted && _InitialTime != 0)
                return Millis() - _InitialTime;
            else 
                return -1;
        }

        public long Millis()
        {
            return (long.MaxValue + DateTime.Now.ToBinary()) / 10000;
        }

        private void PicOn(PictureBox pic1)
        {
            string lFadeStr = "";
            string lPraefix = comboBox_praefix.Text;
            string lInputPraefix = comboBox_inputPraefix.Text; 
            if (IsPlayerPlay() && !(bool)pic1.Tag)
            {
                pic1.Tag = true;
                long lDeltaSleep = (long)((GetCurrentPos() - _LastPos));
                GesamtDeltaSleep += lDeltaSleep;
                _LastPos = GetCurrentPos();
                label_delta.Text = "Vergleich " + GesamtDeltaSleep + "ms";
                if (checkFade.Checked)
                    lFadeStr = " fade";
                else
                    lFadeStr = "";
                AddCMD("sleep " + lDeltaSleep);
                AddCMD(lPraefix + " " + lInputPraefix + pic1.Name.Substring(3, 1) + " 100" + lFadeStr);
            }
            pic1.Image = Properties.Resources.icons8_round_48;
        }

        private void AddCMD(string v)
        {
            _GlobalCmd += v + "\r\n";
            // textCMD.SelectionStart = textCMD.Text.Length;
            // textCMD.ScrollToCaret();
        }

        private void PicOff(PictureBox pic1)
        {
            string lFadeStr = "";
            string lPraefix = comboBox_praefix.Text;
            string lInputPraefix = comboBox_inputPraefix.Text;
            if (IsPlayerPlay() && (bool)pic1.Tag)
            {
                pic1.Tag = false;
                long lDeltaSleep = (long)((GetCurrentPos() - _LastPos));
                GesamtDeltaSleep += lDeltaSleep;
                _LastPos = GetCurrentPos();
                AddCMD("sleep " + lDeltaSleep);
                if (checkFade.Checked)
                    lFadeStr = " fade";
                else
                    lFadeStr = "";
                label_delta.Text = "Vergleich " + GesamtDeltaSleep + "ms";
                AddCMD(lPraefix + " " + lInputPraefix + pic1.Name.Substring(3, 1) + " 0" + lFadeStr);
            }
            pic1.Image = Properties.Resources.icons8_round_48_b;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if(!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Soundfile existiert nicht!");
                return;
            }
            if(button_start.Text == "Starten")
            {
                _StartInSeconds = 3;
                timer_jedeSekunde.Enabled = true;
                button_start.Text = "STOP!";

                textBox1.Enabled = false;
                _GlobalCmd = "";
                label_sec.Visible = true;
                label_current.Visible = true;
                label_start.Visible = true;

                timer_starteInXX.Enabled = true;
                timer_starteInXX_Tick(sender, e);
                _LastPos = 0;
                GesamtDeltaSleep = 0;
                label_delta.Visible = true; 
            } else
            {
                player.Stop();
                _InitialTime = 0;
                timer_jedeSekunde.Enabled = false;
                button_start.Text = "Starten";
                // C:\usr\gg.mp3

                textBox1.Enabled = true;
                label_sec.Visible = false;
                label_current.Visible = false;
                label_start.Visible = false;

                timer_starteInXX.Enabled = false;
                label_delta.Visible = false;
                label_startNow.Visible = false;
            }
        }

        private void timer_jede1ms_Tick(object sender, EventArgs e)
        {
            long lCurrentPos = GetCurrentPos();
            if(lCurrentPos > 3000)
                label_startNow.Visible = false;
            label_current.Text = lCurrentPos + "ms";
        }

        private void timer_starteInXX_Tick(object sender, EventArgs e)
        {
            _StartInSeconds--;

            if(_StartInSeconds >= 0)
            {
                label_sec.Text = _StartInSeconds + " Sekunden";
            } else
            {
                timer_starteInXX.Enabled = false;
                player.SoundLocation = textBox1.Text;
                player.Load();
                player.Play();
                while (!IsPlayerPlay())
                    System.Threading.Thread.Sleep(1);
                _InitialTime = Millis();
                label_startNow.Visible = true;
            }
        }

        private void label_sec_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(textCMD.Text, true);
        }

        private void comboBox_inputPraefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_start.Select();
        }

        private void comboBox_praefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_start.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchSoundFile();
        }

        private void SearchSoundFile()
        {
            bool lFound = false;
            bool lShowMessage = false;
            try
            {
                if(!textBox1.Text.Contains(".wav"))
                {
                    string[] fileEntries = Directory.GetFiles(textBox1.Text);
                    foreach (string lFileName in fileEntries)
                    {
                        if (lFileName.Contains(".wav"))
                        {
                            textBox1.Text = lFileName;
                            lFound = true;
                        }
                        else if (lFileName.Contains(".mp3"))
                        {
                            lShowMessage = true;
                            textBox1.Text = lFileName;
                        }

                    }
                }
            } catch(Exception e)
            {

            }
            if (!lFound && lShowMessage)
                MessageBox.Show("Datei muss in WAV Convertiert sein! Am besten mit der HAG-HomeMatic kram am Server (/tmp)", "Nicht WAV!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textCMD_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_refesh_Tick(object sender, EventArgs e)
        {
            textCMD.Text = _GlobalCmd;
        }
    }
}
