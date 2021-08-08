using GalaSoft.MvvmLight;
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

namespace OlympicApp.ViewModel
{
    class TeamNocVM : ViewModelBase
    {
        private RelayCommand alphabetic;
        private List<Country> countries;
        private RelayCommand medal;
        private RelayCommand selectCommand;

        public List<Country> Countries
        {
            get => countries; set
            {
                Set(ref countries, value);
            }
        }
        public TeamNocVM()
        {
           Countries = ReadWithDapper.GetCountry().ToList().OrderBy(x => x.Medals.Count()).ToList();
            
        }
        public RelayCommand Alphabetic => alphabetic ?? (alphabetic = new RelayCommand(() =>
          {
              Countries = Countries.OrderBy(x => x.Name).ToList();
          }));

        public RelayCommand Medal => medal ?? (medal = new RelayCommand(() =>
          {
                Countries = ReadWithDapper.GetCountry().ToList().OrderBy(x => x.Medals.Count()).ToList();
          }));
        public Country Index { get; set; }
        public RelayCommand SelectCommand => selectCommand ?? (selectCommand = new RelayCommand(() =>
        {
            CountryInfo NewA = new CountryInfo(Index);
            NewA.Show();
        }));
    }
}
