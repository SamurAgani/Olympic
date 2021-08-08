using GalaSoft.MvvmLight.Command;
using OlympicApp.Model;
using OlympicApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp.ViewModel
{
    class TeamVSTeamVM
    {
        public string Back { get; set; }
        public OppositeTeams OppositeTeams { get; set; }
        public TeamVSTeamVM(OppositeTeams a)
        {
            OppositeTeams = a;
            Back = GetImagePathes.GetBackGround("Back");
        }
    }
}
