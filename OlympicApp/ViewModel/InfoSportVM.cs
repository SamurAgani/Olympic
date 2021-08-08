using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using OlympicApp.Messages;
using OlympicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp.ViewModel
{
    public class InfoSportVM : ViewModelBase
    {
        private Messenger messenger;
        private Sport currentSport;

        public Sport CurrentSport { get => currentSport; 
            set
            {
                Set(ref currentSport, value);
            }
        }


        public InfoSportVM()
        {
            
            messenger = App.Container.GetInstance<Messenger>();

            messenger.Register<SportMessage>(this, x =>
            {
                CurrentSport = x.Sport;
            });
        }
    }
}
