using GalaSoft.MvvmLight.Command;
using OlympicApp.Model;
using OlympicApp.Service;
using OlympicApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp.ViewModel
{
    class TeamStageVM
    {
        private RelayCommand selectCommand;

        public string Back { get; set; }
        public string Time { get; set; }
        public OppositeTeams OppositeTeam { get; set; }
        public List<OppositeTeams> OppositeTeams { get; set; }
        public TeamStageVM(StageForTeam a)
        {
            // MessageBox.Show(a.OppositeTeams[0].Team1.Id.ToString());
            OppositeTeams = a.OppositeTeams;
            Back = GetImagePathes.GetBackGround("Race");
            Time = a.Time.ToString();
        }
        public RelayCommand SelectCommand => selectCommand ?? (selectCommand=new RelayCommand(()=>
        {
            var a = new TeamVSTeam(OppositeTeam);
            a.Show();
        }));

    }
}
