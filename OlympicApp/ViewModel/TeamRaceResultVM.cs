using GalaSoft.MvvmLight.Command;
using OlympicApp.Model;
using OlympicApp.Repository;
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
    class TeamRaceResultVM
    {
        private RelayCommand selectCommand;
        public int St { get; set; }
        public RaceForTeam Race { get; set; }
        public Team Winner { get; set; }
        public Team Second { get; set; }
        public Team Third { get; set; }
        public string Back { get; set; }
        public TeamRaceResultVM(int id)
        {
            OlympicDB a = new OlympicDB();
            Race = a.RaceForTeam.Where(x => x.Id == id).FirstOrDefault();
            Winner = Race.Winner;
            Second = Race.Second;
            Third = Race.Third;
            Back = GetImagePathes.GetBackGround("Race");
           //Race.Team[0].OppositeTeams
            //Race.Team[0].OppositeTeams[0].Team1.Country
        }
        public RelayCommand SelectCommand => selectCommand ?? (selectCommand=new RelayCommand(()=> {

            TeamSatgeView a = new TeamSatgeView(Race.Team[St]);
            a.Show();
        }));
    }
}
