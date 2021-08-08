using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OlympicApp.Messages;
using OlympicApp.Model;
using OlympicApp.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp.ViewModel
{
    public class SportsVM : ViewModelBase
    {
        private List<Sport> sports;
        private Messenger messenger;
        private RelayCommand selectCommand;
        private Sport selectedSport;

        public Sport SelectedSport { get => selectedSport; set => Set(ref selectedSport, value); }

        public List<Sport> Sports { get => sports; set => Set(ref sports, value); }
        public RelayCommand SelectCommand => selectCommand ?? (selectCommand = new RelayCommand(() =>
        {
            messenger.Send(new SportMessage() { Sport = SelectedSport });
            messenger.Send(new ViewChange() { ViewModel = App.Container.GetInstance<InfoSportVM>() });
        }));

        public SportsVM()
        {
            messenger = App.Container.GetInstance<Messenger>();

            using (var db = new OlympicDB())
            {
             //   Sports = db.Sport.ToList();
            }


            //foreach (var item in Sports)
            //{
            //    item.ImagePath = @"F:\GitHub\Olympic\OlympicApp\" + item.ImagePath;
            //}

            //Sports.Add(Sports[0]);
            //Sports.Add(Sports[1]);
            //Sports.Add(Sports[2]);
            //Sports.Add(Sports[3]);
            //Sports.Add(Sports[1]);
            //Sports.Add(Sports[2]);
            //Sports.Add(Sports[0]);
            //Sports.Add(Sports[3]);
        }

    }
}
