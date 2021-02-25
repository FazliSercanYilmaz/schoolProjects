namespace Prolab3Netflix
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programlistView = new System.Windows.Forms.ListView();
            this.windowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cikisButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.returnWatchButton = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.seciliProgram = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.seciliProgramBolumleri = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTur = new System.Windows.Forms.ComboBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resizer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oturumKapatButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.Label();
            this.onerilenButton = new System.Windows.Forms.Button();
            this.anaSayfaButton = new System.Windows.Forms.Button();
            this.mesajBox = new System.Windows.Forms.Label();
            this.windowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programlistView
            // 
            this.programlistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.programlistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programlistView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programlistView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.programlistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programlistView.ForeColor = System.Drawing.Color.White;
            this.programlistView.FullRowSelect = true;
            this.programlistView.HideSelection = false;
            this.programlistView.Location = new System.Drawing.Point(0, 390);
            this.programlistView.Margin = new System.Windows.Forms.Padding(20);
            this.programlistView.Name = "programlistView";
            this.programlistView.Size = new System.Drawing.Size(1400, 418);
            this.programlistView.TabIndex = 2;
            this.programlistView.UseCompatibleStateImageBehavior = false;
            this.programlistView.View = System.Windows.Forms.View.Details;
            this.programlistView.SelectedIndexChanged += new System.EventHandler(this.programlistView_SelectedIndexChanged_1);
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.windowPanel.Controls.Add(this.cikisButton);
            this.windowPanel.Controls.Add(this.maxButton);
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(1400, 38);
            this.windowPanel.TabIndex = 10;
            this.windowPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowPanel_MouseDown);
            this.windowPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowPanel_MouseMove);
            this.windowPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.windowPanel_MouseUp);
            // 
            // cikisButton
            // 
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(1320, 3);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(77, 35);
            this.cikisButton.TabIndex = 10;
            this.cikisButton.Text = "x";
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.BackgroundImage = global::Prolab3Netflix.Properties.Resources.oie_transparent;
            this.maxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxButton.FlatAppearance.BorderSize = 0;
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxButton.ForeColor = System.Drawing.Color.White;
            this.maxButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.maxButton.Location = new System.Drawing.Point(1237, 3);
            this.maxButton.Name = "maxButton";
            this.maxButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxButton.Size = new System.Drawing.Size(77, 35);
            this.maxButton.TabIndex = 18;
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prolab3Netflix.Properties.Resources.netflixLogo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.returnWatchButton);
            this.panel3.Controls.Add(this.watchButton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.seciliProgramBolumleri);
            this.panel3.Location = new System.Drawing.Point(224, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 145);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(381, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bölüm Seçiniz";
            // 
            // returnWatchButton
            // 
            this.returnWatchButton.BackColor = System.Drawing.Color.Red;
            this.returnWatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnWatchButton.FlatAppearance.BorderSize = 0;
            this.returnWatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnWatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnWatchButton.ForeColor = System.Drawing.Color.White;
            this.returnWatchButton.Location = new System.Drawing.Point(678, 88);
            this.returnWatchButton.Name = "returnWatchButton";
            this.returnWatchButton.Size = new System.Drawing.Size(287, 40);
            this.returnWatchButton.TabIndex = 2;
            this.returnWatchButton.Text = "Kaldığın Yerden Devam Et";
            this.returnWatchButton.UseVisualStyleBackColor = false;
            this.returnWatchButton.Visible = false;
            this.returnWatchButton.Click += new System.EventHandler(this.returnWatchButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.BackColor = System.Drawing.Color.Red;
            this.watchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchButton.FlatAppearance.BorderSize = 0;
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.ForeColor = System.Drawing.Color.White;
            this.watchButton.Location = new System.Drawing.Point(678, 17);
            this.watchButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(287, 40);
            this.watchButton.TabIndex = 1;
            this.watchButton.Text = "İzle";
            this.watchButton.UseVisualStyleBackColor = false;
            this.watchButton.Visible = false;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.seciliProgram);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(5, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 51);
            this.panel4.TabIndex = 6;
            // 
            // seciliProgram
            // 
            this.seciliProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seciliProgram.ForeColor = System.Drawing.Color.Red;
            this.seciliProgram.Location = new System.Drawing.Point(-1, 29);
            this.seciliProgram.Name = "seciliProgram";
            this.seciliProgram.Size = new System.Drawing.Size(349, 20);
            this.seciliProgram.TabIndex = 3;
            this.seciliProgram.Text = "label4";
            this.seciliProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seciliProgram.Click += new System.EventHandler(this.seciliProgram_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Secilen Program Adı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seciliProgramBolumleri
            // 
            this.seciliProgramBolumleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.seciliProgramBolumleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seciliProgramBolumleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seciliProgramBolumleri.ForeColor = System.Drawing.Color.White;
            this.seciliProgramBolumleri.FormattingEnabled = true;
            this.seciliProgramBolumleri.Location = new System.Drawing.Point(376, 60);
            this.seciliProgramBolumleri.Name = "seciliProgramBolumleri";
            this.seciliProgramBolumleri.Size = new System.Drawing.Size(293, 24);
            this.seciliProgramBolumleri.TabIndex = 0;
            this.seciliProgramBolumleri.SelectedIndexChanged += new System.EventHandler(this.SeciliProgramBolumleri_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchTur);
            this.panel2.Controls.Add(this.searchName);
            this.panel2.Location = new System.Drawing.Point(224, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 105);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(381, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program İsmi";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Yap";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTur
            // 
            this.searchTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.searchTur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchTur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.searchTur.ForeColor = System.Drawing.Color.White;
            this.searchTur.FormattingEnabled = true;
            this.searchTur.Location = new System.Drawing.Point(385, 67);
            this.searchTur.Margin = new System.Windows.Forms.Padding(0);
            this.searchTur.Name = "searchTur";
            this.searchTur.Size = new System.Drawing.Size(172, 30);
            this.searchTur.TabIndex = 1;
            this.searchTur.SelectedIndexChanged += new System.EventHandler(this.searchTur_SelectedIndexChanged);
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.searchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.searchName.ForeColor = System.Drawing.Color.White;
            this.searchName.Location = new System.Drawing.Point(71, 70);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(226, 21);
            this.searchName.TabIndex = 0;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1384, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "Programlar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resizer
            // 
            this.resizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.resizer.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizer.Location = new System.Drawing.Point(1382, 789);
            this.resizer.Name = "resizer";
            this.resizer.Size = new System.Drawing.Size(18, 19);
            this.resizer.TabIndex = 11;
            this.resizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizer_MouseDown);
            this.resizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizer_MouseMove);
            this.resizer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizer_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.oturumKapatButton);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(1213, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 104);
            this.panel1.TabIndex = 14;
            // 
            // oturumKapatButton
            // 
            this.oturumKapatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oturumKapatButton.BackColor = System.Drawing.Color.Red;
            this.oturumKapatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oturumKapatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oturumKapatButton.FlatAppearance.BorderSize = 0;
            this.oturumKapatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oturumKapatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oturumKapatButton.ForeColor = System.Drawing.Color.White;
            this.oturumKapatButton.Location = new System.Drawing.Point(13, 50);
            this.oturumKapatButton.Name = "oturumKapatButton";
            this.oturumKapatButton.Size = new System.Drawing.Size(147, 34);
            this.oturumKapatButton.TabIndex = 1;
            this.oturumKapatButton.Text = "Oturum Kapat";
            this.oturumKapatButton.UseVisualStyleBackColor = false;
            this.oturumKapatButton.Click += new System.EventHandler(this.oturumKapatButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(13, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 37);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "kullaniciadi";
            this.nameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onerilenButton
            // 
            this.onerilenButton.BackColor = System.Drawing.Color.Red;
            this.onerilenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onerilenButton.FlatAppearance.BorderSize = 0;
            this.onerilenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onerilenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onerilenButton.ForeColor = System.Drawing.Color.White;
            this.onerilenButton.Location = new System.Drawing.Point(206, 348);
            this.onerilenButton.Name = "onerilenButton";
            this.onerilenButton.Size = new System.Drawing.Size(140, 40);
            this.onerilenButton.TabIndex = 15;
            this.onerilenButton.Text = "Önerilenler";
            this.onerilenButton.UseVisualStyleBackColor = false;
            this.onerilenButton.Click += new System.EventHandler(this.onerilenButton_Click);
            // 
            // anaSayfaButton
            // 
            this.anaSayfaButton.BackColor = System.Drawing.Color.Red;
            this.anaSayfaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anaSayfaButton.FlatAppearance.BorderSize = 0;
            this.anaSayfaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaSayfaButton.ForeColor = System.Drawing.Color.White;
            this.anaSayfaButton.Location = new System.Drawing.Point(36, 348);
            this.anaSayfaButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.anaSayfaButton.Name = "anaSayfaButton";
            this.anaSayfaButton.Size = new System.Drawing.Size(145, 40);
            this.anaSayfaButton.TabIndex = 16;
            this.anaSayfaButton.Text = "Ana Sayfa";
            this.anaSayfaButton.UseVisualStyleBackColor = false;
            this.anaSayfaButton.Visible = false;
            this.anaSayfaButton.Click += new System.EventHandler(this.anaSayfaButton_Click);
            // 
            // mesajBox
            // 
            this.mesajBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mesajBox.AutoSize = true;
            this.mesajBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mesajBox.ForeColor = System.Drawing.Color.White;
            this.mesajBox.Location = new System.Drawing.Point(919, 356);
            this.mesajBox.Name = "mesajBox";
            this.mesajBox.Size = new System.Drawing.Size(333, 25);
            this.mesajBox.TabIndex = 17;
            this.mesajBox.Text = "Lütfen Aşağıdan Program Seçiniz";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 808);
            this.Controls.Add(this.mesajBox);
            this.Controls.Add(this.anaSayfaButton);
            this.Controls.Add(this.onerilenButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resizer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.programlistView);
            this.Controls.Add(this.windowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.windowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView programlistView;
        private System.Windows.Forms.FlowLayoutPanel windowPanel;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Button returnWatchButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label seciliProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seciliProgramBolumleri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchTur;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Panel resizer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button oturumKapatButton;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Button onerilenButton;
        private System.Windows.Forms.Button anaSayfaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mesajBox;
    }
}