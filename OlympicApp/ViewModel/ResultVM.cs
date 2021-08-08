using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OlympicApp.Model;
using OlympicApp.Repository;
using OlympicApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp.ViewModel
{
    class ResultVM : ViewModelBase
    {
        private List<string> sportCathegory;
        private RelayCommand search;
        private string selectedGender = "";
        private string selectedSport = "";
        private List<string> gender = new List<string>();

        public List<string> SportCathegory { get => sportCathegory; set => sportCathegory = value; }
        public List<string> Gender { get => gender; set => Set(ref gender,value); }
        public string SelectedSport
        {
            get => selectedSport; set
            {
                Set(ref selectedSport, value);
                using (OlympicDB a = new OlympicDB())
                {
                    foreach (var item in a.SportCathegory.Where(x => x.Name == SelectedSport).ToList())
                    {
                        Gender.Add(item.Gender.FemaleOrMale);
                    }
                }
                Search.RaiseCanExecuteChanged();
            }
        }
        public string SelectedGender
        {
            get => selectedGender; set
            {
                Set(ref selectedGender, value);
                Search.RaiseCanExecuteChanged();
            }
        }
        public ResultVM()
        {
            using (OlympicDB a = new OlympicDB())
            {
                SportCathegory = a.SportCathegory.ToList().Select(x => x.Name).Distinct().ToList();
            }
        }
        public RelayCommand Search => search ?? (search = new RelayCommand(() =>
          {
              OlympicDB a = new OlympicDB();
              if (a.Race.Where(x=>x.SportCathegory.Name==SelectedSport).ToList().Count>1)
              {
                  Race asa = a.Race.Where(x => x.SportCathegory.Name == SelectedSport).ToList().FirstOrDefault();
                  OwnRaceView Race = new OwnRaceView(asa.Id);
                  Race.Show();
              }
              else
              {
                  RaceForTeam asa = a.RaceForTeam.Where(x => x.SportCathegory.Name == SelectedSport).ToList().FirstOrDefault();
                  TeamRaceResult Race = new TeamRaceResult(asa.Id);
                  Race.Show();
              }
         }, () =>
         {
             return SelectedSport.Length > 2 && SelectedGender.Length > 2;
         }));
    }
}
