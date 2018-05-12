using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGWinsUI
{
    interface Interface
    {
        // UI text
        string TextKills { get; set; }
        string TextPerspective { get; set; }
        string TextServer { get; set; }
        string TextMap { get; set; }
        string TextTeammate1 { get; set; }
        string TextTeammate2 { get; set; }
        string TextTeammate3 { get; set; }
        string TextDescription { get; set; }

        // UI Buttons
        bool ButtonPreviousVisible { get; set; }
        bool ButtonRemoveVisible { get; set; }
        bool ButtonUpdateVisible { get; set; }

        string TextWinsTotal { get; set; }
        string TextWinsSolo { get; set; }
        string TextWinsDuo { get; set; }
        string TextWinsTrio { get; set; }
        string TextWinsSquad { get; set; }
        string TextWinsNA { get; set; }
        string TextWinsAS { get; set; }
        string TextWinsTest { get; set; }
        string TextWinsEU { get; set; }
        string TextWinsSEA { get; set; }
        string TextWinsSA { get; set; }
        string TextWinsErangel { get; set; }
        string TextWinsMiramar { get; set; }
        string TextWinsSanhok { get; set; }

        string TextKillsTotal { get; set; }
        string TextKillsAverage { get; set; }
        string TextKillsSolo { get; set; }
        string TextKillsDuo { get; set; }
        string TextKillsTrio { get; set; }
        string TextKillsSquad { get; set; }
        string TextKillsNA { get; set; }
        string TextKillsAS { get; set; }
        string TextKillsTest { get; set; }
        string TextKillsEU { get; set; }
        string TextKillsSEA { get; set; }
        string TextKillsSA { get; set; }
        string TextKillsErangel { get; set; }
        string TextKillsMiramar { get; set; }
        string TextKillsSanhok { get; set; }


        // Events
        event Action EventStore;
        event Action EventMostRecentWin;
        event Action EventLessRecentWin;
        event Action EventRemove;
        event Action EventUpdate;

    }
}
