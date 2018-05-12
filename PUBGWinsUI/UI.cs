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
        private static string WinDB; // The connection string to the DB
        private int lastPlayedID; // The last game entered into the database.
        private int currentOldID; // The game we are lookin at.

        private List<ServerWin> serverWins; // The list of objects that represent stats based on wins on a given server.

        public List<ServerWin> ServerWins
        {
            get { return serverWins; }
            set { serverWins = value; }
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
        public string TextWinsSolo
        {
            get { return SoloWins.Text; }
            set { SoloWins.Text = value; }
        }
        public string TextWinsDuo
        {
            get { return DuoWins.Text; }
            set { DuoWins.Text = value; }
        }
        public string TextWinsTrio
        {
            get { return TrioWins.Text; }
            set { TrioWins.Text = value; }
        }
        public string TextWinsSquad
        {
            get { return SquadWins.Text; }
            set { SquadWins.Text = value; }
        }
        /*
        public string TextWinsNA
        {
            get { return NAWins.Text; }
            set { NAWins.Text = value; }
        }
        
        public string TextWinsAS
        {
            get { return ASWins.Text; }
            set { ASWins.Text = value; }
        }
        public string TextWinsTest
        {
            get { return TestWins.Text; }
            set { TestWins.Text = value; }
        }
        public string TextWinsEU
        {
            get { return EUWins.Text; }
            set { EUWins.Text = value; }
        }
        public string TextWinsSEA
        {
            get { return SEAWins.Text; }
            set { SEAWins.Text = value; }
        }
        public string TextWinsSA
        {
            get { return SAWins.Text; }
            set { SAWins.Text = value; }
        }
        */
        public string TextWinsErangel
        {
            get { return WinsErangel.Text; }
            set { WinsErangel.Text = value; }
        }
        public string TextWinsMiramar
        {
            get { return WinsMiramar.Text; }
            set { WinsMiramar.Text = value; }
        }
        public string TextWinsSanhok
        {
            get { return WinsSanhok.Text; }
            set { WinsSanhok.Text = value; }
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
        public string TextKillsSolo
        {
            get { return KillsSolo.Text; }
            set { KillsSolo.Text = value; }
        }
        public string TextKillsDuo
        {
            get { return KillsDuo.Text; }
            set { KillsDuo.Text = value; }
        }
        public string TextKillsTrio
        {
            get { return KillsTrio.Text; }
            set { KillsTrio.Text = value; }
        }
        public string TextKillsSquad
        {
            get { return KillsSquad.Text; }
            set { KillsSquad.Text = value; }
        }
        /*
        public string TextKillsNA
        {
            get { return KillsNA.Text; }
            set { KillsNA.Text = value; }
        }
        
        public string TextKillsAS
        {
            get { return KillsAS.Text; }
            set { KillsAS.Text = value; }
        }
        public string TextKillsTest
        {
            get { return KillsTest.Text; }
            set { KillsTest.Text = value; }
        }
        public string TextKillsEU
        {
            get { return KillsEU.Text; }
            set { KillsEU.Text = value; }
        }
        public string TextKillsSEA
        {
            get { return KillsSEA.Text; }
            set { KillsSEA.Text = value; }
        }
        public string TextKillsSA
        {
            get { return KillsSA.Text; }
            set { KillsSA.Text = value; }
        }
        */
        public string TextKillsErangel
        {
            get { return KillsErangel.Text; }
            set { KillsErangel.Text = value; }
        }
        public string TextKillsMiramar
        {
            get { return KillsMiramar.Text; }
            set { KillsMiramar.Text = value; }
        }
        public string TextKillsSanhok
        {
            get { return KillsSanhok.Text; }
            set { KillsSanhok.Text = value; }
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

        // Kills per win average
        public string TextKPWSolo
        {
            get { return KPWSolo.Text; }
            set { KPWSolo.Text = value; }
        }
        public string TextKPWDuo
        {
            get { return KPWDuo.Text; }
            set { KPWDuo.Text = value; }
        }
        public string TextKPWTrio
        {
            get { return KPWTrio.Text; }
            set { KPWTrio.Text = value; }
        }
        public string TextKPWSquad
        {
            get { return KPWSquad.Text; }
            set { KPWSquad.Text = value; }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        public UI()
        {
            InitializeComponent();

            lastPlayedID = 0;
            currentOldID = 0;

            // SQL database.
            WinDB = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Alex\\source\\repos\\PUBGWins\\PUBGWinsUI\\WinDB.mdf; Integrated Security = True";

            // Hook up info for servers.
            serverWins = new List<ServerWin>();

            ServerWin serverWinNA = new ServerWin("NA");
            serverWinNA.LabelKills = KillsNA;
            serverWinNA.LabelWins = NAWins;
            serverWinNA.LabelAverage = KPWNA;
            serverWins.Add(serverWinNA);

            ServerWin serverWinAS = new ServerWin("AS");
            serverWinAS.LabelKills = KillsAS;
            serverWinAS.LabelWins = ASWins;
            serverWinAS.LabelAverage = KPWAS;
            serverWins.Add(serverWinAS);

            ServerWin serverWinTest = new ServerWin("Test");
            serverWinTest.LabelKills = KillsTest;
            serverWinTest.LabelWins = TestWins;
            serverWinTest.LabelAverage = KPWTest;
            serverWins.Add(serverWinTest);

            ServerWin serverWinEU = new ServerWin("EU");
            serverWinEU.LabelKills = KillsEU;
            serverWinEU.LabelWins = EUWins;
            serverWinEU.LabelAverage = KPWEU;
            serverWins.Add(serverWinEU);

            ServerWin serverWinSEA = new ServerWin("SEA");
            serverWinSEA.LabelKills = KillsSEA;
            serverWinSEA.LabelWins = SEAWins;
            serverWinSEA.LabelAverage = KPWSEA;
            serverWins.Add(serverWinSEA);

            ServerWin serverWinSA = new ServerWin("SA");
            serverWinSA.LabelKills = KillsSA;
            serverWinSA.LabelWins = SAWins;
            serverWinSA.LabelAverage = KPWSA;
            serverWins.Add(serverWinSA);
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
