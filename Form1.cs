﻿using Helper;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace progetto_scuola
{
    public partial class Form1 : Form
    {
        
        //checkifworksall
        Label[] Boxlettere = new Label[0];
        System.Windows.Forms.Panel[] boxTentativi = new System.Windows.Forms.Panel[7];
        Char[] lettere = new Char[0];
        Char[] lettereUsate = new Char[31];
        int numUsate = 0;
        int NTcorr = 6;
        string parola_untranslated = default;
        string parola = default;
        string insertion = default;
        string nicknameBefore = default;
        int n = 0;
        int volume = 0;
        string playerName = default;
        public int playerPoints = default;
        System.Windows.Forms.Panel panelRed = new System.Windows.Forms.Panel();
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        int SC = 0;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(screenWidth, screenHeight);
            this.Location = new Point(0, 0);
            panelTitle.Size = new Size(screenWidth, screenHeight / 8);

            bigLabel1.Location = new Point(this.Size.Width / 2 - bigLabel1.Size.Width / 2, panelTitle.Size.Height / 2 - bigLabel1.Size.Height / 2);

            labelVolume.Text = volume.ToString();
            KeyPreview = true;
            hScrollVolume.Value = volume;

            #region contorni txtInserimento

            #endregion
            buttonSettings.Location = new Point(this.Size.Width - buttonSettings.Size.Width, panelTitle.Size.Height+1);
            panelSettings.Location = new Point(this.Size.Width - panelSettings.Size.Width, panelTitle.Size.Height + buttonSettings.Size.Height + 1);
            panelName.Location = new Point(154, 240);
            panelName.Location = new Point(this.Size.Width / 2 - 359, this.Size.Height / 2 - 90);
            buttonPlay.Location = new Point(this.Size.Width / 2 - buttonPlay.Size.Width / 2, this.Size.Height / 2 - buttonPlay.Size.Height / 2);

            txtNickname.Focus();
            if (!File.Exists(Path.Combine(@"data", "playerinfo.dat")))
            {
                //Directory.CreateDirectory(@"data");
                

                buttonPlay.Visible = false;
                buttonPlay.Enabled = false;
                panelName.Visible = true;
                panelName.Enabled = true;
                labelNome.Visible = false;
                
            }

            else //===========PRENDI INFO DAL FILE
            {
                
                #region prendi info dal file esistente


                


                StreamReader read = new StreamReader(Path.Combine("data", "playerinfo.dat"));
                while (!read.EndOfStream)
                {
                    //nome
                    playerName = read.ReadLine().Split('=')[1];
                    labelNome.Text = playerName;
                    //punteggio
                    playerPoints = int.Parse(read.ReadLine().Split('=')[1]);
                    labelPts.Text = playerPoints.ToString();
                    //volume
                    volume = int.Parse(read.ReadLine().Split('=')[1]);
                    ScrollVolume.Value = volume;
                    //streak
                    SC = int.Parse(read.ReadLine().Split('=')[1]);
                    if (SC>1)
                    {
                        labelStreakCounter.Text = $"Streak di {SC}";
                        labelStreakCounter.BackColor = Color.FromArgb(255, 255, 0);
                        labelStreakCounter.BorderStyle = BorderStyle.FixedSingle;
                    }
                    
                    
                    #region alternativa non attiva
                    //string line = read.ReadLine();
                    //string[] split = line.Split('=');
                    //if (split[0] == "name")
                    //{
                    //    if (split[1] == "")
                    //    {
                    //        buttonPlay.Visible = false;
                    //        buttonPlay.Enabled = false;
                    //        panelName.Visible = true;
                    //        panelName.Enabled = true;
                    //        labelNome.Visible = false;
                    //        read.Close();
                    //        return;
                    //    }
                    //    playerName = split[1];
                    //    labelNome.Text = playerName;
                    //}
                    //if (split[0] == "score")
                    //{
                    //    playerPoints = int.Parse(split[1]);
                    //    labelPts.Text = playerPoints.ToString();
                    //}
                    //if (split[0] == "winstreak")
                    //{
                    //    if (int.Parse(split[1]) > 0)
                    //    {
                    //        SC = int.Parse(split[1]);
                    //        labelStreakCounter.Text = $"Streak di {SC}";
                    //        labelStreakCounter.BackColor = Color.FromArgb(255, 64, 0);
                    //        labelStreakCounter.BorderStyle = BorderStyle.FixedSingle;
                    //    }
                    //}
                    //if (split[0] == "volume")
                    //{
                    //    volume = int.Parse(split[1]);
                    //    ScrollVolume.Value = volume;
                    //}
                    #endregion
                }
                read.Close();

                #endregion
                panelName.Visible = false; panelName.Enabled = false; buttonPlay.Visible = true;
                buttonPlay.Enabled = true;
                labelNome.Visible = true;
                labelPts.Visible = true;
               
                panelInfo.Visible = true;
            }
            labelPts.Location = new Point(lblDescrPts.Location.X + lblDescrPts.Size.Width + 1, lblDescrPts.Location.Y);
            labelNome.Location = new Point(lblDescrNome.Location.X + lblDescrNome.Size.Width + 1, lblDescrNome.Location.Y);
            if (lblDescrNome.Size.Width+labelNome.Size.Width>lblDescrPts.Size.Width+labelPts.Size.Width)
            {
                panelInfo.Size = new Size(10 + lblDescrNome.Size.Width + labelNome.Size.Width, 10 + lblDescrNome.Size.Height + labelNome.Size.Height);
            }
            else panelInfo.Size = new Size(10 + lblDescrPts.Size.Width + labelPts.Size.Width, 10 + lblDescrPts.Size.Height + labelPts.Size.Height);
            panelInfo.Location = new Point(this.Size.Width / 2 + 10, panelTitle.Size.Height);
            labelStreakCounter.Location = new Point(panelInfo.Location.X+panelInfo.Size.Width, panelTitle.Size.Height);



        }

        private void hScrollVolume_Scroll(object sender, ScrollEventArgs e)
        {
            volume = hScrollVolume.Value;
            labelVolume.Text = volume.ToString();
        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = false;
            txtInsert.Text = "";
            lettereUsate = null;
            numUsate = 0;
           

            

            
            #region genera parola
            bool ok = false;
            while (!ok)
            {
                ok = true;
                parola_untranslated = Class1.datiFake();
                //parola = "qwerty";

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                    Headers =
    {
        { "X-RapidAPI-Key", "1921e6c576msh950b29f0deb4610p12af99jsnf9326a2067e5" },
        { "X-RapidAPI-Host", "google-translate113.p.rapidapi.com" },
    },
                    Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "from", "en" },
        { "to", "it" },
        { "text", parola_untranslated},
    }),
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();        
                    string parola_translated = body.Split('"')[3];

                    parola = parola_translated;
                    foreach (char carattere in parola)
                    {
                        if (carattere == Convert.ToChar(" ") || carattere == Convert.ToChar("-") || !Char.IsLetter(carattere))
                        {
                            ok = false;
                        }
                    }

                }
            }
            #endregion

     
            n = parola.Length;
            Array.Resize(ref Boxlettere, n);
            Array.Resize(ref lettere, n);

            for (int i = 0; i < n; i++)
            {
                char lettera = parola[i];
                char letteraUppered = Char.ToUpper(lettera);
                lettere[i] = letteraUppered;
            }

            int gssW = btnGuess.Size.Width;
            btnGuess.Location = new Point(this.Size.Width / 2 - gssW / 2, (screenHeight - panelTitle.Size.Height) * 3 / 4);
            btnGuess.Enabled = true;
            btnGuess.Visible = true;

            int insW = txtInsert.Size.Width;
            txtInsert.Location = new Point(this.Size.Width / 2 - insW / 2, btnGuess.Location.Y - (100 + txtInsert.Size.Height));
            txtInsert.Enabled = true;
            txtInsert.Visible = true;

            #region creazione label per le lettere 
            #region pari
            //==============CREA LABEL CON DISPARI===================================
            int x = 48; int y = 60;
            int crX = 0;
            if (n % 2 == 1)
            {

                n = n / 2;
                Label cr1 = new Label();
                cr1.Size = new Size(x, y);
                cr1.Location = new Point(this.Size.Width / 2 - 24, bigLabel1.Size.Height + 200);
                cr1.Text = "_";
                cr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                cr1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(cr1);
                crX = cr1.Location.X;

                Boxlettere[n] = cr1;

                while (n > 0)
                {

                    Label cr = new Label();
                    cr.Location = new Point(crX - x, bigLabel1.Size.Height + 200);
                    cr.Size = new Size(x, y);
                    cr.TabIndex = n;
                    //  cr.Name = $"L{n}";
                    cr.Text = "_";
                    cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                    cr.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(cr);
                    crX = cr.Location.X;

                    Boxlettere[n - 1] = cr;
                    n--;

                }
                n = parola.Length / 2 + 1;
                crX = cr1.Location.X;
                while (n < parola.Length)
                {

                    Label cr = new Label();
                    cr.Location = new Point(crX + x, bigLabel1.Size.Height + 200);
                    cr.Size = new Size(x, y);
                    cr.TabIndex = n;
                    cr.Name = $"L{n}";
                    cr.Text = "_";
                    cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                    cr.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(cr);
                    crX = cr.Location.X;
                    Boxlettere[n] = cr;
                    n++;
                }
            }
            #endregion
            #region dispari
            //==============CREA LABEL CON PARI===================================

            if (n % 2 == 0)
            {
                n = parola.Length / 2;
                Label cr1 = new Label();
                cr1.Location = new Point(this.Size.Width / 2 - x, bigLabel1.Size.Height + 200);
                cr1.Size = new Size(x, y);
                cr1.Text = "_";
                cr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                cr1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(cr1);
                crX = cr1.Location.X;

                Boxlettere[n - 1] = cr1;
                while (n > 1)
                {
                    n--;
                    Label cr = new Label();
                    cr.Location = new Point(crX - x, bigLabel1.Size.Height + 200);
                    cr.Size = new Size(x, y);
                    cr.TabIndex = n;
                    //  cr.Name = $"L{n}";
                    cr.Text = "_";
                    cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                    cr.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(cr);
                    crX = cr.Location.X;

                    Boxlettere[n - 1] = cr;

                }
                crX = cr1.Location.X;
                n = parola.Length / 2;
                while (n < parola.Length)
                {
                    n++;
                    Label cr = new Label();
                    cr.Location = new Point(crX + x, bigLabel1.Size.Height + 200);
                    cr.Size = new Size(x, y);
                    cr.TabIndex = n;
                    cr.Name = $"L{n}";
                    cr.Text = "_";
                    cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 37);
                    cr.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(cr);
                    crX = cr.Location.X;
                    Boxlettere[n - 1] = cr;


                }
            }
            #endregion
            #endregion

            #region creazione pannelli dei tentativi

            int crea = 0;
            x = 10;
            while (crea <= 6)
            {
                System.Windows.Forms.Panel np = new System.Windows.Forms.Panel();
                np.Location = new Point(x, 10 + panelTitle.Size.Height);
                np.Size = new Size(this.Size.Width / 2 / 7 - 10, 30);
                np.BackColor = Color.FromArgb(50, 255, 50);
                np.Margin = new Padding(0);
                np.BorderStyle = BorderStyle.FixedSingle;
                boxTentativi[crea] = np;
                x = x + np.Size.Width;
                this.Controls.Add(np);
                crea++;
            }
            #endregion
            

            NTcorr = 6; //7 tentativi

            buttonPlay.Enabled = false;
            buttonPlay.Visible = false;


            panelRed = new System.Windows.Forms.Panel()
            {
                BackColor = Color.FromArgb(0, 0, 0),
                Location = new Point(txtInsert.Location.X - 2, txtInsert.Location.Y - 2),
                Size = new Size(txtInsert.Size.Width + 4, txtInsert.Size.Height + 4),

            };
            this.Controls.Add(panelRed);


            txtInsert.Focus();
            
        }

        async Task backBecomeRed()
        {
            
            panelRed.BackColor = Color.FromArgb(255, 0, 0);
            for (int i = 255; i > 0; i--)
            {
                panelRed.BackColor = Color.FromArgb(i - 1, 0, 0);
                await Task.Delay(1);
            }

        }
        
        
        private async void btnGuess_Click(object sender, EventArgs e)
        {
            if (lettereUsate == null)
            {
                Array.Resize(ref lettereUsate, 31);
            }

            if (string.IsNullOrEmpty(txtInsert.Text))
            {

                txtInsert.Focus();


                await Task.Run(backBecomeRed);

                return;
            }

            string inserted = txtInsert.Text;
            int tf = 0;
            bool k = false;


            for (int i = 0; i < n - 1; i++)
            {
                if (Convert.ToChar(txtInsert.Text) == lettereUsate[i])
                {

                    Label used = new Label()
                    {
                        Text = $"Hai gia usato la lettera {lettereUsate[i]}!",
                        ForeColor = Color.Red,
                        Size = new Size(300, 50),
                        Font = new Font("Microsoft Sans Serif", 16.25F)
                    };
                    used.Location = new Point(txtInsert.Location.X + txtInsert.Width + 100, txtInsert.Location.Y);
                    this.Controls.Add(used);
                    await Task.Delay(500);
                    this.Controls.Remove(used);


                    for (int i2 = 0; i2 < parola.Length; i2++)
                    {

                        if (Boxlettere[i2].Text == txtInsert.Text)
                        {
                            Boxlettere[i2].BackColor = Color.LightBlue;
                            await Task.Delay(500);
                            Boxlettere[i2].BackColor = this.BackColor;
                        }
                    }
                    return;
                }
            }


            while (tf < parola.Length)
            {
                if (inserted == lettere[tf].ToString())
                {
                    Boxlettere[tf].Text = lettere[tf].ToString(); k = true;
                }
                tf++;
            }

            if (!k)
            {

                boxTentativi[NTcorr].BackColor = Color.White;
                NTcorr--;
                if (NTcorr == 3)
                {
                    boxTentativi[0].BackColor = Color.Yellow;
                    boxTentativi[1].BackColor = Color.Yellow;
                    boxTentativi[2].BackColor = Color.Yellow;
                    boxTentativi[3].BackColor = Color.Yellow;
                }
                if (NTcorr == 1)
                {
                    boxTentativi[0].BackColor = Color.Red;
                    boxTentativi[1].BackColor = Color.Red;
                }

            } //non indovinato


            if (NTcorr < 0)
            {
                gameLostReset();
                
                return;

            } //perso

            bool checkWin = true;
            for (int i = 0; i < parola.Length; i++)
            {
                if (Boxlettere[i].Text == "_")
                {
                    checkWin = false;
                }
            }

            if (checkWin) //-----------------Vince------------------
            {
                gameWinReset();
                return;
            } //===============  VINCE  ================

            lettereUsate[numUsate] = Convert.ToChar(txtInsert.Text);
            numUsate++;
            txtInsert.Text = null;
            txtInsert.Focus();

        }

        private void txtInsert_TextChanged(object sender, EventArgs e)
        {
            
            if (txtInsert.Text.Length > 1) { txtInsert.Text = insertion; return; }
            if (string.IsNullOrEmpty(txtInsert.Text)) return;
            
            if (!Char.IsLetter(Convert.ToChar(txtInsert.Text)))
            {
                txtInsert.Text = null; return;
            }

            insertion = txtInsert.Text;

            char value = Convert.ToChar(txtInsert.Text);
            char valueUpper = Char.ToUpper(value);
            
            int CharValue = valueUpper;


             if (CharValue<65 || CharValue>90 && CharValue!=192 && CharValue !=200 && CharValue !=204 && CharValue !=210 && CharValue !=217 &&
                CharValue !=193 && CharValue !=201 && CharValue !=205 && CharValue !=211 && CharValue !=218)
            {
                txtInsert.Text = null; return;
            }
            //MessageBox.Show(CharValue.ToString());
            txtInsert.Text = valueUpper.ToString();
        }

        private void txtNickname_TextChanged()//object sender, EventArgs e)
        {
            string insertingName = txtNickname.Text;
            for (int nIns = 0; nIns < insertingName.Length; nIns++)
            {
                if (!Char.IsLetter(insertingName[nIns]) && !Char.IsNumber(insertingName[nIns]))
                {
                    txtNickname.Text = nicknameBefore;
                    return;
                }
            }
            nicknameBefore = txtNickname.Text;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (txtNickname.Text.Length >= 3 && txtNickname.Text.Length <= 16 && !String.IsNullOrWhiteSpace(txtNickname.Text))
            {
                StreamWriter w;
                Directory.CreateDirectory(@"data");
                w = new StreamWriter(System.IO.Path.Combine(@"data", "playerinfo.dat"));
                
                w.WriteLine($"name={txtNickname.Text}"); 
                w.WriteLine("score=0");
                w.WriteLine($"volume=0");
                w.WriteLine("winstreak=0");
                w.Close();
                labelNome.Text = txtNickname.Text;
                buttonPlay.Enabled = true;
                panelName.Visible = false;
                panelName.Enabled = false;
                labelNome.Visible = true;
                labelPts.Visible = true;
                panelInfo.Visible = true;
                panelInfo.Size = new Size(10 + lblDescrNome.Size.Width + labelNome.Size.Width, 10 + lblDescrNome.Size.Height + labelNome.Size.Height);
                buttonPlay.Visible = true;
                return;
            }
            MessageBox.Show("La lunghezza del tuo nickname deve essere compresa tra 3 e 16 caratteri");
        }

        private void PressKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnGuess.Enabled)
            {
                btnGuess.PerformClick();

            }
            if (e.KeyCode == Keys.Enter && buttonPlay.Enabled)
            {

                buttonPlay.PerformClick();
            }
            if (e.KeyCode == Keys.Back && txtInsert.Enabled)
            {
                txtInsert.Text = "";
            }
            if (e.KeyCode == Keys.Enter && buttonConfirm.Enabled)
            {

                buttonConfirm.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



        private void ScrollVolume_Scroll(object sender, ScrollEventArgs e)
        {
            volume = ScrollVolume.Value;
            if (volume > 99) volume = 100;
            labelVolume.Text = volume.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo(@"data");
            if (Dir.Exists)
            {
                foreach (FileInfo file in Dir.GetFiles())
                {
                    file.Delete();
                }
                Dir.Delete();
            }
        }
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(Path.Combine(@"data", "playerinfo.dat")) && Directory.Exists(@"data"))
            {
                Directory.Delete(@"data");
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (!panelSettings.Visible)
            panelSettings.Visible = true;
            else panelSettings.Visible = false;
        }
        private async void gameLostReset()
        {
            
            btnGuess.Enabled = false;

            for (int numShow = 0; numShow < parola.Length; numShow++)
            {
                Boxlettere[numShow].Text = lettere[numShow].ToString();
            }
            Class1.Speaker(parola, volume);
            await Task.Delay(1200);
            for (int el = parola.Length - 1; el >= 0; el--)
            {
                this.Controls.Remove(Boxlettere[el]);
            }
            for (int el2 = 6; el2 >= 0; el2--)
            {
                this.Controls.Remove(boxTentativi[el2]);

            }
            lettereUsate = null;
            lettere = null;
            buttonPlay.Visible = true;
            buttonPlay.Enabled = true;
            btnGuess.Visible = false;
            btnGuess.Enabled = false;
            txtInsert.Visible = false;
            txtInsert.Enabled = false;
            panelRed.Visible = false;
            panelPerso.Location = new Point(this.Size.Width / 2 - panelPerso.Size.Width / 2, this.Size.Height / 2 - panelPerso.Size.Height / 2);
            panelPerso.Visible = true;

            
            await Task.Delay(2000);
            SC = 0;
            Class1.saveStreak(SC);
            labelStreakCounter.Text = null;
            labelStreakCounter.BackColor = this.BackColor;
            labelStreakCounter.BorderStyle = BorderStyle.None;


            panelPerso.Visible = false;
            buttonPlay.Focus();
            
        }

        private async void gameWinReset()
        {


            int WinPoints = Class1.winPoints(NTcorr + 1, parola.Length);



            playerPoints = playerPoints + WinPoints;

            labelPts.Text = playerPoints.ToString();
            if (lblDescrNome.Size.Width + labelNome.Size.Width > lblDescrPts.Size.Width + labelPts.Size.Width)
            {
                panelInfo.Size = new Size(10 + lblDescrNome.Size.Width + labelNome.Size.Width, 10 + lblDescrNome.Size.Height + labelNome.Size.Height);
            }
            else panelInfo.Size = new Size(10 + lblDescrPts.Size.Width + labelPts.Size.Width, 10 + lblDescrPts.Size.Height + labelPts.Size.Height);
            Class1.Speaker(parola, volume);

            
            panelVinto.Visible = true;
            panelVinto.Location = new Point(this.Size.Width / 2 - panelVinto.Size.Width / 2, this.Size.Height / 2 - panelVinto.Size.Height / 2);
            btnGuess.Visible = false;
            btnGuess.Enabled = false;
            txtInsert.Visible = false;
            txtInsert.Enabled = false;
            panelRed.Visible = false;
            await Task.Delay(2000);


            for (int el = parola.Length - 1; el >= 0; el--)
            {
                this.Controls.Remove(Boxlettere[el]);
            }
            lettereUsate = null;
            lettere = null;

            buttonPlay.Visible = true;
            buttonPlay.Enabled = true;


            for (int el2 = 6; el2 >= 0; el2--)
            {
                this.Controls.Remove(boxTentativi[el2]);

            }

            SC++;
            if (SC>1)
            {
                labelStreakCounter.Text = $"Streak di {SC}";
                labelStreakCounter.BackColor = Color.FromArgb(255, 255, 0);
                labelStreakCounter.BorderStyle = BorderStyle.FixedSingle;
                Class1.saveGamescore(playerPoints);
                Class1.saveStreak(SC);
            }
            
            




            panelVinto.Visible = false;
            buttonPlay.Focus();

        }
        private void formClose(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(Path.Combine(@"data", "playerinfo.dat")))
            {
                Class1.saveVolume(volume);
            }
           
        }
       

        
       
    }
}
