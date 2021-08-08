using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OlympicApp.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentViewModel;
        private RelayCommand athlets;
        private RelayCommand bestOfVM;
        private RelayCommand result;
        private RelayCommand teamNoc;
        private RelayCommand sportsCommand;

        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        public Messenger Mes { get; set; }
        public MainViewModel()
        {
            Mes = App.Container.GetInstance<Messenger>();
            Mes.Register<ViewChange>(this, x => CurrentViewModel = x.ViewModel);
        }
        public RelayCommand Athlets => athlets ?? (athlets = new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<AthletsVM>(); ;
        }));
        public RelayCommand SportsCommand => sportsCommand ?? (sportsCommand = new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<SportsVM>();
        }));
        public RelayCommand BestOfVM => bestOfVM ?? (bestOfVM = new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<BestOfVM>(); ;
        }));
        public RelayCommand Result => result ?? (result = new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<ResultVM>(); ;
        }));
        public RelayCommand TeamNoc => teamNoc ?? (teamNoc = new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<TeamNocVM>();
        }));
    }
}
