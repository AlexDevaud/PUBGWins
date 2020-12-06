using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PUBGWinsUI
{
    public partial class UI : Form, Interface
    {
        private List<ServerWin> serverWins; // The list of objects that represent stats based on wins on a given server.
        private List<MapWin> mapWins;
        private List<TeammatesNumberWin> teammatesWins;
        private Label[] topTeammates;
        private List<PerspectiveNumberWin> perspectiveNumberWins;

        public List<ServerWin> ServerWins
        {
            get { return serverWins; }
            set { serverWins = value; }
        }

        public List<MapWin> MapWins
        {
            get { return mapWins; }
            set { mapWins = value; }
        }

        public List<TeammatesNumberWin> TeammatesWins
        {
            get { return teammatesWins; }
            set { teammatesWins = value; }
        }

        public List<PerspectiveNumberWin> PerspectiveWins
        {
            get { return perspectiveNumberWins; }
            set { perspectiveNumberWins = value; }
        }

        public event Action EventStore;
        public event Action EventMostRecentWin;
        public event Action EventLessRecentWin;
        public event Action EventRemove;
        public event Action EventUpdate;
        public event Action EventDefaults;

        // Properties.
        // Entered data.
        public String TextKills
        {
            get { return BoxKills.Text; }
            set { BoxKills.Text = value; }
        }

        public String TextPerspective
        {
            get { return MenuPerspective.Text; }
            set { MenuPerspective.Text = value; }
        }

        public string TextServer
        {
            get { return MenuServer.Text; }
            set { MenuServer.Text = value; }
        }

        public string TextMap
        {
            get { return MenuMap.Text; }
            set { MenuMap.Text = value; }
        }
        public string TextTeammate1
        {
            get { return BoxTeammate1.Text; }
            set { BoxTeammate1.Text = value; }
        }
        public string TextTeammate2
        {
            get { return BoxTeammate2.Text; }
            set { BoxTeammate2.Text = value; }
        }
        public string TextTeammate3
        {
            get { return BoxTeammate3.Text; }
            set { BoxTeammate3.Text = value; }
        }
        public string TextDescription
        {
            get { return BoxDescription.Text; }
            set { BoxDescription.Text = value; }
        }

        // Wins
        public string TextWinsTotal
        {
            get { return WinsTotal.Text; }
            set { WinsTotal.Text = value; }
        }
       

        // Kills
        public string TextKillsTotal
        {
            get { return KillsTotal.Text; }
            set { KillsTotal.Text = value; }
        }
        public string TextKillsAverage
        {
            get { return KillsPerWin.Text; }
            set { KillsPerWin.Text = value; }
        }
        

        // Button visibility.
        public bool ButtonPreviousVisible
        {
            get { return ButtonPrevious.Visible; }
            set { ButtonPrevious.Visible = value; }
        }
        public bool ButtonRemoveVisible
        {
            get { return ButtonRemove.Visible; }
            set { ButtonRemove.Visible = value; }
        }
        public bool ButtonUpdateVisible
        {
            get { return ButtonUpdate.Visible; }
            set { ButtonUpdate.Visible = value; }
        }

        public Label[] TopTeammates { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public UI()
        {
            InitializeComponent();

            // Hook up info for servers.
            serverWins = new List<ServerWin>();

            ServerWin serverWinNA = new ServerWin("NA")
            {
                LabelKills = KillsNA,
                LabelWins = NAWins,
                LabelAverage = KPWNA
            };
            serverWins.Add(serverWinNA);

            ServerWin serverWinAS = new ServerWin("AS")
            {
                LabelKills = KillsAS,
                LabelWins = ASWins,
                LabelAverage = KPWAS
            };
            serverWins.Add(serverWinAS);

            ServerWin serverWinTest = new ServerWin("Test")
            {
                LabelKills = KillsTest,
                LabelWins = TestWins,
                LabelAverage = KPWTest
            };
            serverWins.Add(serverWinTest);

            ServerWin serverWinEU = new ServerWin("EU")
            {
                LabelKills = KillsEU,
                LabelWins = EUWins,
                LabelAverage = KPWEU
            };
            serverWins.Add(serverWinEU);

            ServerWin serverWinSEA = new ServerWin("SEA")
            {
                LabelKills = KillsSEA,
                LabelWins = SEAWins,
                LabelAverage = KPWSEA
            };
            serverWins.Add(serverWinSEA);

            ServerWin serverWinSA = new ServerWin("SA")
            {
                LabelKills = KillsSA,
                LabelWins = SAWins,
                LabelAverage = KPWSA
            };
            serverWins.Add(serverWinSA);

            // Hook up info for maps.
            mapWins = new List<MapWin>();

            MapWin mapWinErangel = new MapWin("Erangel")
            {
                LabelWins = WinsErangel,
                LabelKills = KillsErangel,
                LabelAverage = KPWErangel
            };
            mapWins.Add(mapWinErangel);

            MapWin mapWinMiramar = new MapWin("Miramar")
            {
                LabelWins = WinsMiramar,
                LabelKills = KillsMiramar,
                LabelAverage = KPWMiramar
            };
            mapWins.Add(mapWinMiramar);

            MapWin mapWinSanhok = new MapWin("Sanhok")
            {
                LabelWins = WinsSanhok,
                LabelKills = KillsSanhok,
                LabelAverage = KPWSanhok
            };
            mapWins.Add(mapWinSanhok);

            MapWin mapWinVikendi = new MapWin("Vikendi")
            {
                LabelWins = WinsVikendi,
                LabelKills = KillsVikendi,
                LabelAverage = KPWVikendi
            };
            mapWins.Add(mapWinVikendi);

            MapWin mapWinKarakin = new MapWin("Karakin")
            {
                LabelWins = WinsKarakin,
                LabelKills = KillsKarakin,
                LabelAverage = KPWKarakin
            };
            mapWins.Add(mapWinKarakin);

            MapWin mapWinParamo = new MapWin("Paramo")
            {
                LabelWins = WinsParamo,
                LabelKills = KillsParamo,
                LabelAverage = KPWParamo
            };
            mapWins.Add(mapWinParamo);

            // Hook up info for teammates.
            teammatesWins = new List<TeammatesNumberWin>();
            TeammatesNumberWin teammatesWin0 = new TeammatesNumberWin(0)
            {
                LabelAverage = KPWSolo,
                LabelKills = KillsSolo,
                LabelWins = SoloWins
            };
            teammatesWins.Add(teammatesWin0);

            TeammatesNumberWin teammatesWin1 = new TeammatesNumberWin(1)
            {
                LabelAverage = KPWDuo,
                LabelKills = KillsDuo,
                LabelWins = DuoWins
            };
            teammatesWins.Add(teammatesWin1);

            TeammatesNumberWin teammatesWin2 = new TeammatesNumberWin(2)
            {
                LabelAverage = KPWTrio,
                LabelKills = KillsTrio,
                LabelWins = TrioWins
            };
            teammatesWins.Add(teammatesWin2);

            TeammatesNumberWin teammatesWin3 = new TeammatesNumberWin(3)
            {
                LabelAverage = KPWSquad,
                LabelKills = KillsSquad,
                LabelWins = SquadWins
            };
            teammatesWins.Add(teammatesWin3);

            // Hook up perspective stats.
            perspectiveNumberWins = new List<PerspectiveNumberWin>();
            PerspectiveNumberWin fppWins = new PerspectiveNumberWin("FPP")
            {
                LabelAverage = KPWFPP,
                LabelKills = FPPKills,
                LabelWins = FPPWins
            };
            perspectiveNumberWins.Add(fppWins);

            PerspectiveNumberWin tppWins = new PerspectiveNumberWin("TPP")
            {
                LabelAverage = KPWTPP,
                LabelKills = TPPKills,
                LabelWins = TPPWins
            };
            perspectiveNumberWins.Add(tppWins);


            // Label to display top teammates.
            topTeammates = new Label[]
            {
                TopTeammate1,
                TopTeammate2,
                TopTeammate3,
                TopTeammate4,
                TopTeammate5
            };
            TopTeammates = topTeammates;
        }

        /// <summary>
        /// Store a game that has been entered.
        /// Also updates the stats when done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStore_Click(object sender, EventArgs e)
        {
            EventStore?.Invoke();
        }

        /// <summary>
        /// Show the last played game.
        /// </summary>
        private void ButtonLast_Click(object sender, EventArgs e)
        {
            EventMostRecentWin?.Invoke();
        }

        /// <summary>
        /// Go back one game through the wins entered.
        /// </summary>
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            EventLessRecentWin?.Invoke();
        }

        /// <summary>
        /// Change the entry in the DB to use this data.
        /// </summary>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            EventUpdate?.Invoke();
        }

        /// <summary>
        /// Remove the displayed old game from the DB.
        /// </summary>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            EventRemove?.Invoke();
        }

        private void ButtonDefaults_Click(object sender, EventArgs e)
        {
            EventDefaults?.Invoke();
        }
    }
    
}
