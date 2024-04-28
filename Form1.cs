using Helper;
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

namespace progetto_scuola
{
    public partial class Form1 : Form
    {
        //aaaaaaaaaaa
        //aaaaaa
        //aaaaaaaa
        //aaaaallllllll
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
        int playerPoints = default;
        System.Windows.Forms.Panel panelRed = new System.Windows.Forms.Panel();
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public Form1()
        {
            InitializeComponent();
        }

        private void themeForm1_Click(object sender, EventArgs e)
        {

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


            panelName.Location = new Point(154, 240);
            panelName.Location = new Point(this.Size.Width / 2 - 359, this.Size.Height / 2 - 90);
            buttonPlay.Location = new Point(this.Size.Width / 2 - buttonPlay.Size.Width / 2, this.Size.Height / 2 - buttonPlay.Size.Height / 2);

            txtNickname.Focus();
            if (!Directory.Exists(@"data"))
            {
                Directory.CreateDirectory(@"data");
            

                buttonPlay.Visible = false;
                buttonPlay.Enabled = false;
                panelName.Visible = true;
                panelName.Enabled = true;
                labelUsrName.Visible = false;
            }

            else //===========PRENDI INFO DAL FILE
            {
                #region prendi info dal file esistente
                panelName.Visible = false; panelName.Enabled = false; buttonPlay.Visible = true;
                buttonPlay.Enabled = true;
                labelUsrName.Visible = true;
                labelPts.Visible = true;
                //panelVolumeInside.Visible = false;


                StreamReader read = new StreamReader(Path.Combine("data", "playerinfo.txt"));
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    string[] split = line.Split('=');
                    if (split[0] == "name")
                    {
                        if (split[1] == "")
                        {
                            buttonPlay.Visible = false;
                            buttonPlay.Enabled = false;
                            panelName.Visible = true;
                            panelName.Enabled = true;
                            labelUsrName.Visible = false;
                            read.Close();
                            return;
                        }
                        playerName = split[1];
                        labelUsrName.Text = playerName;
                    }
                    if (split[0] == "score")
                    {
                        playerPoints = int.Parse(split[1]);
                        labelPts.Text = playerPoints.ToString();
                    }
                }
                read.Close();

                #endregion
            }
            panelInfo.Location = new Point(screenWidth - 450, panelTitle.Size.Height + 4);





        }

        private void hScrollVolume_Scroll(object sender, ScrollEventArgs e)
        {
            volume = hScrollVolume.Value;
            labelVolume.Text = volume.ToString();
        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            txtInsert.Text = "";
            lettereUsate = null;
            numUsate = 0;
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
                MessageBox.Show(body);
                string fp = body.Split(',')[0];
                //int cc = 10;
                //while ((Char)body[cc] != (Char)"") 
                
                string jsonString = JsonSerializer.Serialize(body);
                MessageBox.Show(jsonString);
            }

            //Class1.traduzione(trad, parola);



            parola = parola_untranslated;
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
                np.Size = new Size((this.Size.Height - 20) / 7, 30);
                np.BackColor = Color.FromArgb(50, 255, 50);
                np.Margin = new Padding(0);
                np.BorderStyle = BorderStyle.FixedSingle;
                boxTentativi[crea] = np;
                x = x + np.Size.Width;
                this.Controls.Add(np);
                crea++;
            }
            #endregion
            NTcorr = 6; //imposta i tentativi (7)

            buttonPlay.Enabled = false;
            buttonPlay.Visible = false;


            panelRed = new System.Windows.Forms.Panel()
            {
                BackColor = Color.FromArgb(150, 150, 255),
                Location = new Point(txtInsert.Location.X - 2, txtInsert.Location.Y - 2),
                Size = new Size(txtInsert.Size.Width + 4, txtInsert.Size.Height + 4),

            };
            this.Controls.Add(panelRed);


            txtInsert.Focus();
            //NON ATTIVO 
            #region gestione casi con trattini o spazi generati
            //
            //for (int m = 0; m<PAROLA.Length; m++)
            //{
            //    if (lettere[m] == Convert.ToChar("-")) 
            //    {
            //        Boxlettere[m].Text = "-";
            //    }
            //    if (lettere[m] == Convert.ToChar(" "))
            //    {
            //        Boxlettere[m].Text = " ";
            //    }
            //}
            //
            #endregion
            //NON ATTIVO 
        }

        async Task backBecomeRed()
        {
            MessageBox.Show("aaaa");
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
                    for (int i2 = 0; i2 < parola.Length; i2++)
                    {

                        if (Boxlettere[i2].Text == txtInsert.Text)
                        {
                            Boxlettere[i2].BackColor = Color.LightBlue;
                            await Task.Delay(500);
                            Boxlettere[i2].BackColor = Color.White;
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


                btnGuess.Enabled = false;

                for (int numShow = 0; numShow < parola.Length; numShow++)
                {
                    Boxlettere[numShow].Text = lettere[numShow].ToString();
                }
                panelPerso.Location = new Point(this.Size.Width / 2 - panelPerso.Size.Width / 2, this.Size.Height / 2 - panelPerso.Size.Height / 2);
                panelPerso.Visible = true;

                Class1.Speaker(parola, volume);
                await Task.Delay(2000);

                for (int el = parola.Length - 1; el >= 0; el--)
                {
                    this.Controls.Remove(Boxlettere[el]);
                }
                lettereUsate = null;
                lettere = null;
                buttonPlay.Visible = true;
                buttonPlay.Enabled = true;
                btnGuess.Visible = false;
                btnGuess.Enabled = false;
                txtInsert.Visible = false;
                txtInsert.Enabled = false;

                panelPerso.Visible = false;
                for (int el2 = 6; el2 >= 0; el2--)
                {
                    this.Controls.Remove(boxTentativi[el2]);

                }
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
                panelVinto.Visible = true;
                panelVinto.Location = new Point(this.Size.Width / 2 - panelVinto.Size.Width / 2, this.Size.Height / 2 - panelVinto.Size.Height / 2);

                int WinPoints = Class1.winPoints(NTcorr + 1, parola.Length);


                playerPoints = playerPoints + WinPoints;

                labelPts.Text = playerPoints.ToString();

                Class1.Speaker(parola, volume);

                Class1.saveGamescore(playerPoints);


                await Task.Delay(2000);

                #region torna allo stato iniziale
                panelVinto.Visible = false;
                for (int el = parola.Length - 1; el >= 0; el--)
                {
                    this.Controls.Remove(Boxlettere[el]);
                }
                lettereUsate = null;
                lettere = null;
                buttonPlay.Visible = true;
                buttonPlay.Enabled = true;
                btnGuess.Visible = false;
                btnGuess.Enabled = false;
                txtInsert.Visible = false;
                txtInsert.Enabled = false;

                for (int el2 = 6; el2 >= 0; el2--)
                {
                    this.Controls.Remove(boxTentativi[el2]);

                }
                buttonPlay.Focus();
                #endregion

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

            if (txtNickname.Text.Length >= 3 && txtNickname.Text.Length <= 16)
            {
                StreamWriter w;
                w = new StreamWriter(System.IO.Path.Combine(@"data", "playerinfo.txt"));
                w.WriteLine($"name={txtNickname.Text}"); buttonPlay.Visible = true;
                int initScore = 0;
                w.WriteLine($"score={initScore}");
                w.Close();
                labelUsrName.Text = txtNickname.Text;
                buttonPlay.Enabled = true;
                panelName.Visible = false;
                panelName.Enabled = false;
                labelUsrName.Visible = true;
                labelPts.Visible = true;
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
            labelVolume.Text = ScrollVolume.Value.ToString();
            if (int.Parse(labelVolume.Text) > 99) labelVolume.Text = "100";
        }


    }
}
