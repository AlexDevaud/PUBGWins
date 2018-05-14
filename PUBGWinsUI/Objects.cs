using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBGWinsUI
{
    /// <summary>
    /// Object to track calculating and displaying stats.
    /// For wins on a certain server.
    /// </summary>
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

    /// <summary>
    /// Object to track calculating and displaying stats.
    /// For wins on a certain map.
    /// </summary>
    public class MapWin
    {
        public string Map { get; }
        public int Wins { get; set; }
        public int Kills { get; set; }
        public double KPW { get; set; }
        
        public Label LabelWins { get; set; }
        public Label LabelKills { get; set; }
        public Label LabelAverage { get; set; }

        public MapWin(string map)
        {
            Map = map;
        }
    }

    /// <summary>
    /// Object to track calculating and displaying stats.
    /// For wins with a given number of teammates.
    /// </summary>
    public class TeammatesNumberWin
    {
        public int Teammates { get; }
        public int Wins { get; set; }
        public int Kills { get; set; }
        public double KPW { get; set; }

        public Label LabelWins { get; set; }
        public Label LabelKills { get; set; }
        public Label LabelAverage { get; set; }
        public TeammatesNumberWin(int teammates)
        {
            Teammates = teammates;
        }

       
    }

    /// <summary>
    /// Tracking how many games I have won with a given teammate.
    /// </summary>
    public class SpecificTeammateWins : IComparable<SpecificTeammateWins>
    {
        public string Name { get; }
        public int Wins { get; set; }

        public SpecificTeammateWins(string name)
        {
            Name = name;
            Wins = 1;
        }

        public int CompareTo(SpecificTeammateWins specificTeammateWins)
        {
            if (specificTeammateWins == null)
            {
                return 1;
            }
            else
            {
                return this.Wins.CompareTo(specificTeammateWins.Wins);
            }
        }
    }

}
