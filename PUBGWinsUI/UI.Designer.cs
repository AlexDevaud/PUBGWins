namespace PUBGWinsUI
{
    partial class UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuPerspective = new System.Windows.Forms.ComboBox();
            this.MenuServer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuMap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxKills = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonStore = new System.Windows.Forms.Button();
            this.BoxTeammate1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxTeammate2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxTeammate3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WinsErangel = new System.Windows.Forms.Label();
            this.KillsErangel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.KillsTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.WinsTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.KillsMiramar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.WinsMiramar = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.KillsSavage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.WinsSavage = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.KillsPerWin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NAWins = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ASWins = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TestWins = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.EUWins = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SoloWins = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.DuoWins = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TrioWins = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SquadWins = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter info about a win.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perspective: ";
            // 
            // MenuPerspective
            // 
            this.MenuPerspective.FormattingEnabled = true;
            this.MenuPerspective.Items.AddRange(new object[] {
            "FPP",
            "TPP"});
            this.MenuPerspective.Location = new System.Drawing.Point(93, 62);
            this.MenuPerspective.Name = "MenuPerspective";
            this.MenuPerspective.Size = new System.Drawing.Size(61, 21);
            this.MenuPerspective.TabIndex = 3;
            // 
            // MenuServer
            // 
            this.MenuServer.FormattingEnabled = true;
            this.MenuServer.Items.AddRange(new object[] {
            "NA",
            "AS",
            "EU",
            "SEA",
            "Test"});
            this.MenuServer.Location = new System.Drawing.Point(93, 89);
            this.MenuServer.Name = "MenuServer";
            this.MenuServer.Size = new System.Drawing.Size(61, 21);
            this.MenuServer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server: ";
            // 
            // MenuMap
            // 
            this.MenuMap.FormattingEnabled = true;
            this.MenuMap.Items.AddRange(new object[] {
            "Erangel",
            "Miramar",
            "Savage"});
            this.MenuMap.Location = new System.Drawing.Point(59, 116);
            this.MenuMap.Name = "MenuMap";
            this.MenuMap.Size = new System.Drawing.Size(98, 21);
            this.MenuMap.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Map: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kills: ";
            // 
            // BoxKills
            // 
            this.BoxKills.Location = new System.Drawing.Point(54, 36);
            this.BoxKills.Name = "BoxKills";
            this.BoxKills.Size = new System.Drawing.Size(100, 20);
            this.BoxKills.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description: ";
            // 
            // BoxDescription
            // 
            this.BoxDescription.Location = new System.Drawing.Point(93, 248);
            this.BoxDescription.Multiline = true;
            this.BoxDescription.Name = "BoxDescription";
            this.BoxDescription.Size = new System.Drawing.Size(564, 291);
            this.BoxDescription.TabIndex = 13;
            // 
            // ButtonStore
            // 
            this.ButtonStore.Location = new System.Drawing.Point(582, 545);
            this.ButtonStore.Name = "ButtonStore";
            this.ButtonStore.Size = new System.Drawing.Size(75, 23);
            this.ButtonStore.TabIndex = 14;
            this.ButtonStore.Text = "Store Game";
            this.ButtonStore.UseVisualStyleBackColor = true;
            this.ButtonStore.Click += new System.EventHandler(this.ButtonStore_Click);
            // 
            // BoxTeammate1
            // 
            this.BoxTeammate1.Location = new System.Drawing.Point(93, 170);
            this.BoxTeammate1.Name = "BoxTeammate1";
            this.BoxTeammate1.Size = new System.Drawing.Size(108, 20);
            this.BoxTeammate1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teammate 1: ";
            // 
            // BoxTeammate2
            // 
            this.BoxTeammate2.Location = new System.Drawing.Point(93, 196);
            this.BoxTeammate2.Name = "BoxTeammate2";
            this.BoxTeammate2.Size = new System.Drawing.Size(108, 20);
            this.BoxTeammate2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Teammate 2: ";
            // 
            // BoxTeammate3
            // 
            this.BoxTeammate3.Location = new System.Drawing.Point(93, 222);
            this.BoxTeammate3.Name = "BoxTeammate3";
            this.BoxTeammate3.Size = new System.Drawing.Size(108, 20);
            this.BoxTeammate3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Teammate 3: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Wins on Erangel: ";
            // 
            // WinsErangel
            // 
            this.WinsErangel.AutoSize = true;
            this.WinsErangel.Location = new System.Drawing.Point(362, 13);
            this.WinsErangel.Name = "WinsErangel";
            this.WinsErangel.Size = new System.Drawing.Size(13, 13);
            this.WinsErangel.TabIndex = 23;
            this.WinsErangel.Text = "0";
            // 
            // KillsErangel
            // 
            this.KillsErangel.AutoSize = true;
            this.KillsErangel.Location = new System.Drawing.Point(495, 13);
            this.KillsErangel.Name = "KillsErangel";
            this.KillsErangel.Size = new System.Drawing.Size(13, 13);
            this.KillsErangel.TabIndex = 26;
            this.KillsErangel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Kills on Erangel: ";
            // 
            // KillsTotal
            // 
            this.KillsTotal.AutoSize = true;
            this.KillsTotal.Location = new System.Drawing.Point(495, 82);
            this.KillsTotal.Name = "KillsTotal";
            this.KillsTotal.Size = new System.Drawing.Size(13, 13);
            this.KillsTotal.TabIndex = 28;
            this.KillsTotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(398, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total Kills: ";
            // 
            // WinsTotal
            // 
            this.WinsTotal.AutoSize = true;
            this.WinsTotal.Location = new System.Drawing.Point(362, 82);
            this.WinsTotal.Name = "WinsTotal";
            this.WinsTotal.Size = new System.Drawing.Size(13, 13);
            this.WinsTotal.TabIndex = 30;
            this.WinsTotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Wins: ";
            // 
            // KillsMiramar
            // 
            this.KillsMiramar.AutoSize = true;
            this.KillsMiramar.Location = new System.Drawing.Point(495, 37);
            this.KillsMiramar.Name = "KillsMiramar";
            this.KillsMiramar.Size = new System.Drawing.Size(13, 13);
            this.KillsMiramar.TabIndex = 34;
            this.KillsMiramar.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(398, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Kills on Miramar: ";
            // 
            // WinsMiramar
            // 
            this.WinsMiramar.AutoSize = true;
            this.WinsMiramar.Location = new System.Drawing.Point(362, 37);
            this.WinsMiramar.Name = "WinsMiramar";
            this.WinsMiramar.Size = new System.Drawing.Size(13, 13);
            this.WinsMiramar.TabIndex = 32;
            this.WinsMiramar.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(265, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Wins on Miramar: ";
            // 
            // KillsSavage
            // 
            this.KillsSavage.AutoSize = true;
            this.KillsSavage.Location = new System.Drawing.Point(495, 61);
            this.KillsSavage.Name = "KillsSavage";
            this.KillsSavage.Size = new System.Drawing.Size(13, 13);
            this.KillsSavage.TabIndex = 38;
            this.KillsSavage.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(398, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Kills on Savage: ";
            // 
            // WinsSavage
            // 
            this.WinsSavage.AutoSize = true;
            this.WinsSavage.Location = new System.Drawing.Point(362, 61);
            this.WinsSavage.Name = "WinsSavage";
            this.WinsSavage.Size = new System.Drawing.Size(13, 13);
            this.WinsSavage.TabIndex = 36;
            this.WinsSavage.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(265, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Wins on Savage: ";
            // 
            // KillsPerWin
            // 
            this.KillsPerWin.AutoSize = true;
            this.KillsPerWin.Location = new System.Drawing.Point(495, 102);
            this.KillsPerWin.Name = "KillsPerWin";
            this.KillsPerWin.Size = new System.Drawing.Size(13, 13);
            this.KillsPerWin.TabIndex = 40;
            this.KillsPerWin.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Average Kills per Win: ";
            // 
            // NAWins
            // 
            this.NAWins.AutoSize = true;
            this.NAWins.Location = new System.Drawing.Point(394, 147);
            this.NAWins.Name = "NAWins";
            this.NAWins.Size = new System.Drawing.Size(13, 13);
            this.NAWins.TabIndex = 42;
            this.NAWins.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(334, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "NA Wins: ";
            // 
            // ASWins
            // 
            this.ASWins.AutoSize = true;
            this.ASWins.Location = new System.Drawing.Point(394, 169);
            this.ASWins.Name = "ASWins";
            this.ASWins.Size = new System.Drawing.Size(13, 13);
            this.ASWins.TabIndex = 44;
            this.ASWins.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(334, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "AS Wins: ";
            // 
            // TestWins
            // 
            this.TestWins.AutoSize = true;
            this.TestWins.Location = new System.Drawing.Point(393, 191);
            this.TestWins.Name = "TestWins";
            this.TestWins.Size = new System.Drawing.Size(13, 13);
            this.TestWins.TabIndex = 46;
            this.TestWins.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(333, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "TestWins: ";
            // 
            // EUWins
            // 
            this.EUWins.AutoSize = true;
            this.EUWins.Location = new System.Drawing.Point(393, 211);
            this.EUWins.Name = "EUWins";
            this.EUWins.Size = new System.Drawing.Size(13, 13);
            this.EUWins.TabIndex = 48;
            this.EUWins.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(333, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "EU Wins: ";
            // 
            // SoloWins
            // 
            this.SoloWins.AutoSize = true;
            this.SoloWins.Location = new System.Drawing.Point(495, 147);
            this.SoloWins.Name = "SoloWins";
            this.SoloWins.Size = new System.Drawing.Size(13, 13);
            this.SoloWins.TabIndex = 50;
            this.SoloWins.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(427, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Solo Wins: ";
            // 
            // DuoWins
            // 
            this.DuoWins.AutoSize = true;
            this.DuoWins.Location = new System.Drawing.Point(495, 169);
            this.DuoWins.Name = "DuoWins";
            this.DuoWins.Size = new System.Drawing.Size(13, 13);
            this.DuoWins.TabIndex = 52;
            this.DuoWins.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(427, 169);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "Duo Wins: ";
            // 
            // TrioWins
            // 
            this.TrioWins.AutoSize = true;
            this.TrioWins.Location = new System.Drawing.Point(495, 192);
            this.TrioWins.Name = "TrioWins";
            this.TrioWins.Size = new System.Drawing.Size(13, 13);
            this.TrioWins.TabIndex = 54;
            this.TrioWins.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(426, 192);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Trio Wins: ";
            // 
            // SquadWins
            // 
            this.SquadWins.AutoSize = true;
            this.SquadWins.Location = new System.Drawing.Point(495, 211);
            this.SquadWins.Name = "SquadWins";
            this.SquadWins.Size = new System.Drawing.Size(13, 13);
            this.SquadWins.TabIndex = 56;
            this.SquadWins.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(427, 211);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "Squad Wins: ";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 578);
            this.Controls.Add(this.SquadWins);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.TrioWins);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.DuoWins);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.SoloWins);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.EUWins);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TestWins);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ASWins);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.NAWins);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.KillsPerWin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KillsSavage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.WinsSavage);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.KillsMiramar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.WinsMiramar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.WinsTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.KillsTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.KillsErangel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WinsErangel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BoxTeammate3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BoxTeammate2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxTeammate1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonStore);
            this.Controls.Add(this.BoxDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BoxKills);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MenuMap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MenuServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MenuPerspective);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "PUBG Wins Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MenuPerspective;
        private System.Windows.Forms.ComboBox MenuServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MenuMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxKills;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxDescription;
        private System.Windows.Forms.Button ButtonStore;
        private System.Windows.Forms.TextBox BoxTeammate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxTeammate2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BoxTeammate3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label WinsErangel;
        private System.Windows.Forms.Label KillsErangel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label KillsTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label WinsTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label KillsMiramar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label WinsMiramar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label KillsSavage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label WinsSavage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label KillsPerWin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NAWins;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ASWins;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label TestWins;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label EUWins;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label SoloWins;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label DuoWins;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label TrioWins;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label SquadWins;
        private System.Windows.Forms.Label label27;
    }
}

