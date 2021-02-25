using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab3Netflix
{
    public partial class MainScreen : Form
    {
        List<Dictionary<string, object>> programlar;
        List<Dictionary<string, object>> turler;
        public MainScreen()
        {
            InitializeComponent();
           nameBox.Text =  (string)Program.user.user["User_Name"];
            programlistView.Columns.Add("Adı",253);
            programlistView.Columns.Add("Tipi",41);
            programlistView.Columns.Add("Türü",357);
           programlistView.Columns.Add("Puanı",54);
            programlistView.Columns.Add("Bölüm sayısı",105);
            programlistView.Columns.Add("Kullanıcı Puanı",180);
            programlar = Program.netflix.watchLoad();
            turler = Program.netflix.TurLoad();
            searchTur.Items.Add("Secili Degil");
            foreach(var tur in turler)
            {
                searchTur.Items.Add(tur["Tur_Name"]);
            }
            programListViewUpdate();

        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;

        private void programlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void programListViewUpdate()
        {
            programlistView.SelectedIndices.Clear();
            programlistView.SelectedItems.Clear();
            programlistView.Items.Clear();
           foreach(var program in programlar)
            {
                List<string> satir = new List<string>();
                satir.Add(program["Program_Name"].ToString());
                if(program["Program_Type"].ToString() == "1")
                {
                    satir.Add("Film");
                }
                else
                {
                    satir.Add("Dizi");
                }
                satir.Add(program["Program_Turleri"].ToString());
                satir.Add(program["Program_Score"].ToString());
                satir.Add(program["Program_ChapterNumber"].ToString());
                if(Program.user.selectedUserProgramGet(program["Program_Id"].ToString()) != null)
                {
                    if (Program.user.selectedUserProgramGet(program["Program_Id"].ToString())["UserProgram_Puan"].ToString() != "0")
                    {
                        satir.Add(Program.user.selectedUserProgramGet(program["Program_Id"].ToString())["UserProgram_Puan"].ToString());
                    }
                }
                string[] array = satir.ToArray();
                ListViewItem list = new ListViewItem(array);
                programlistView.Items.Add(list);
               // programlistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
               // programlistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void searchTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            onerilenButton.Visible = true;
            anaSayfaButton.Visible = false;
            if (searchTur.SelectedIndex == -1 ||searchTur.SelectedIndex == 0)
            {
                if(searchName.Text != "")
                {
                    this.programlar = Program.netflix.watchSearchProgramAdi(searchName.Text);
                }
                else
                {
                    this.programlar = Program.netflix.watchLoad();
                }
            }
            else
            {
                if (searchName.Text != "")
                {
                    this.programlar = Program.netflix.watchSearch(searchName.Text.ToString(),turler[searchTur.SelectedIndex - 1]["Tur_Name"].ToString());
                }
                else
                {
                    this.programlar = Program.netflix.watchSearch(turler[searchTur.SelectedIndex - 1]["Tur_Name"].ToString());
                }
            }
            programListViewUpdate();
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            onerilenButton.Visible = true;
            anaSayfaButton.Visible = false;
            if (searchTur.SelectedIndex == -1 || searchTur.SelectedIndex == 0)
            {
                if (searchName.Text != "")
                {
                    this.programlar = Program.netflix.watchSearchProgramAdi(searchName.Text);
                }
                else
                {
                    this.programlar = Program.netflix.watchLoad();
                }
            }
            else
            {
                if (searchName.Text != "")
                {
                    this.programlar = Program.netflix.watchSearch(searchName.Text.ToString(), turler[searchTur.SelectedIndex - 1]["Tur_Name"].ToString());
                }
                else
                {
                    this.programlar = Program.netflix.watchSearch(turler[searchTur.SelectedIndex - 1]["Tur_Name"].ToString());
                }
            }
            programListViewUpdate();
        }

        private void seciliProgram_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void programlistView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           if(programlistView.SelectedIndices.Count == 1)
            {
                panel3.Visible = true;
                mesajBox.Visible = false;
                seciliProgram.Text = programlar[programlistView.SelectedIndices[0]]["Program_Name"].ToString();
                seciliProgramBolumleri.SelectedIndex = -1;
                watchButton.Visible = false;
                returnWatchButton.Visible = false;
                seciliProgramBolumleri.Items.Clear();
                for(int i =0; i< Convert.ToInt32(programlar[programlistView.SelectedIndices[0]]["Program_ChapterNumber"]); i++)
                {
                    seciliProgramBolumleri.Items.Add((i + 1).ToString());
                }
            }
            else
            {
                panel3.Visible = false;
                mesajBox.Visible = true;
            }
        }

        private void SeciliProgramBolumleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            watchButton.Visible = true;
            if (Program.user.selectedUserProgramGet(programlar[programlistView.SelectedIndices[0]]["Program_Id"].ToString()) != null)
            {
                if (Program.user.selectedUserProgramGet(programlar[programlistView.SelectedIndices[0]]["Program_Id"].ToString())["UserProgrma_KaldigiBolum"].ToString() == (seciliProgramBolumleri.SelectedIndex+1).ToString())
                returnWatchButton.Visible = true;
                else
                    returnWatchButton.Visible = false;
            }
            else
            {
                returnWatchButton.Visible = false;
            }
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var izlemeEkrani = new WatchScreen(programlar[programlistView.SelectedIndices[0]]["Program_Id"].ToString(),(seciliProgramBolumleri.SelectedIndex+1).ToString());
            izlemeEkrani.Closed += (s, args) => this.Close();
            izlemeEkrani.Show();
        }

        private void returnWatchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var izlemeEkrani = new WatchScreen(Program.user.selectedUserProgramGet(programlar[programlistView.SelectedIndices[0]]["Program_Id"].ToString()));
            izlemeEkrani.Closed += (s, args) => this.Close();
            izlemeEkrani.Show();


        }
        private void resizer_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void resizer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void resizer_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void windowPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void windowPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void windowPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int resCon = 0;

        private void oturumKapatButton_Click(object sender, EventArgs e)
        {
            Program.user = null;
            this.Hide();
            var giris = new StartScreen();
            giris.Closed += (s, args) => this.Close();
            giris.Show();
        }
       
        private void onerilenButton_Click(object sender, EventArgs e)
        {
            onerilenButton.Visible = false;
            anaSayfaButton.Visible = true;
            this.programlar = Program.user.UserRecommendPrograms();
            programListViewUpdate();
           
        }
        private void anaSayfaButton_Click(object sender, EventArgs e)
        {
            onerilenButton.Visible = true;
            anaSayfaButton.Visible = false;
            this.programlar = Program.netflix.watchLoad();
            programListViewUpdate();
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

       

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (resCon == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                resCon = 1;
                resizer.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                resCon = 0;
                resizer.Visible = true;
            }

        }

    }
}
