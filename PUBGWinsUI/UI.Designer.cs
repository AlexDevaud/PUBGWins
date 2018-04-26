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
            this.LabelDebug = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WinsErangel = new System.Windows.Forms.Label();
            this.ButtonStats = new System.Windows.Forms.Button();
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
            "SEA"});
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
            // LabelDebug
            // 
            this.LabelDebug.AutoSize = true;
            this.LabelDebug.Location = new System.Drawing.Point(213, 731);
            this.LabelDebug.Name = "LabelDebug";
            this.LabelDebug.Size = new System.Drawing.Size(39, 13);
            this.LabelDebug.TabIndex = 21;
            this.LabelDebug.Text = "Debug";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Wins on Erangel: ";
            // 
            // WinsErangel
            // 
            this.WinsErangel.AutoSize = true;
            this.WinsErangel.Location = new System.Drawing.Point(780, 65);
            this.WinsErangel.Name = "WinsErangel";
            this.WinsErangel.Size = new System.Drawing.Size(13, 13);
            this.WinsErangel.TabIndex = 23;
            this.WinsErangel.Text = "0";
            // 
            // ButtonStats
            // 
            this.ButtonStats.Location = new System.Drawing.Point(733, 13);
            this.ButtonStats.Name = "ButtonStats";
            this.ButtonStats.Size = new System.Drawing.Size(75, 23);
            this.ButtonStats.TabIndex = 24;
            this.ButtonStats.Text = "Show Stats";
            this.ButtonStats.UseVisualStyleBackColor = true;
            this.ButtonStats.Click += new System.EventHandler(this.ButtonStats_Click);
            // 
            // KillsErangel
            // 
            this.KillsErangel.AutoSize = true;
            this.KillsErangel.Location = new System.Drawing.Point(913, 65);
            this.KillsErangel.Name = "KillsErangel";
            this.KillsErangel.Size = new System.Drawing.Size(13, 13);
            this.KillsErangel.TabIndex = 26;
            this.KillsErangel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(816, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Kills on Erangel: ";
            // 
            // KillsTotal
            // 
            this.KillsTotal.AutoSize = true;
            this.KillsTotal.Location = new System.Drawing.Point(913, 134);
            this.KillsTotal.Name = "KillsTotal";
            this.KillsTotal.Size = new System.Drawing.Size(13, 13);
            this.KillsTotal.TabIndex = 28;
            this.KillsTotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(816, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total Kills: ";
            // 
            // WinsTotal
            // 
            this.WinsTotal.AutoSize = true;
            this.WinsTotal.Location = new System.Drawing.Point(780, 134);
            this.WinsTotal.Name = "WinsTotal";
            this.WinsTotal.Size = new System.Drawing.Size(13, 13);
            this.WinsTotal.TabIndex = 30;
            this.WinsTotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(683, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Wins: ";
            // 
            // KillsMiramar
            // 
            this.KillsMiramar.AutoSize = true;
            this.KillsMiramar.Location = new System.Drawing.Point(913, 89);
            this.KillsMiramar.Name = "KillsMiramar";
            this.KillsMiramar.Size = new System.Drawing.Size(13, 13);
            this.KillsMiramar.TabIndex = 34;
            this.KillsMiramar.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(816, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Kills on Miramar: ";
            // 
            // WinsMiramar
            // 
            this.WinsMiramar.AutoSize = true;
            this.WinsMiramar.Location = new System.Drawing.Point(780, 89);
            this.WinsMiramar.Name = "WinsMiramar";
            this.WinsMiramar.Size = new System.Drawing.Size(13, 13);
            this.WinsMiramar.TabIndex = 32;
            this.WinsMiramar.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(683, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Wins on Miramar: ";
            // 
            // KillsSavage
            // 
            this.KillsSavage.AutoSize = true;
            this.KillsSavage.Location = new System.Drawing.Point(913, 113);
            this.KillsSavage.Name = "KillsSavage";
            this.KillsSavage.Size = new System.Drawing.Size(13, 13);
            this.KillsSavage.TabIndex = 38;
            this.KillsSavage.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(816, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Kills on Savage: ";
            // 
            // WinsSavage
            // 
            this.WinsSavage.AutoSize = true;
            this.WinsSavage.Location = new System.Drawing.Point(780, 113);
            this.WinsSavage.Name = "WinsSavage";
            this.WinsSavage.Size = new System.Drawing.Size(13, 13);
            this.WinsSavage.TabIndex = 36;
            this.WinsSavage.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(683, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Wins on Savage: ";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 777);
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
            this.Controls.Add(this.ButtonStats);
            this.Controls.Add(this.WinsErangel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LabelDebug);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.Label LabelDebug;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label WinsErangel;
        private System.Windows.Forms.Button ButtonStats;
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
    }
}

