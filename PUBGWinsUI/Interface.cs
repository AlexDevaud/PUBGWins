﻿using System;
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

        string TextKillsTotal { get; set; }
        string TextKillsAverage { get; set; }

        List<ServerWin> ServerWins { get; set; }
        List<MapWin> MapWins { get; set; }
        List<TeammatesWin> TeammatesWins { get; set; }

        // Events
        event Action EventStore;
        event Action EventMostRecentWin;
        event Action EventLessRecentWin;
        event Action EventRemove;
        event Action EventUpdate;
        event Action EventDefaults;
    }
}
