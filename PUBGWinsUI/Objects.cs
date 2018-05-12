using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBGWinsUI
{
    public class ServerWin
    {
        public string Server { get; }
        public int Wins { get; set; }
        public int Kills { get; set; }
        public double KPW { get; set; }

        public Label LabelWins { get; set; }
        public Label LabelKills { get; set; }
        public Label LabelAverage { get; set; }

        public ServerWin(string server)
        {
            Server = server;
        }
    }
}
