using GalaSoft.MvvmLight.Command;
using OlympicApp.Model;
using OlympicApp.Repository;
using OlympicApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OlympicApp.View
{
    /// <summary>
    /// Interaction logic for AthletInfo.xaml
    /// </summary>
    public partial class AthletInfo : Window
    {
        private List<Athlet> athlets;
        private RelayCommand selectCommand;
        private Athlet index;
        public string BackGround { get; set; }
        public Athlet Index { get => index; set => index = value; }
        public int GoldMedals { get; set; }
        public int SilverMedals { get; set; }
        public int BronzeMedals { get; set; }
        public Country Country { get; set; }
        public Athlet Athlet { get; set; }
        public List<Athlet> Athlets { get => athlets; set => athlets = value; }
        public AthletInfo(int athlet)
        {
            InitializeComponent();
            DataContext = this;
            OlympicDB a = new OlympicDB();
            Athlet = a.Athlet.ToList().Where(x=>x.Id==athlet).FirstOrDefault();
            BackGround = GetImagePathes.GetBackGround("Athlet");
            GoldMedals = Athlet.Medals.Where(x => x.MedalType.Type == "Gold").Count();
            BronzeMedals = Athlet.Medals.Where(x => x.MedalType.Type == "Bronze").Count();
            SilverMedals = Athlet.Medals.Where(x => x.MedalType.Type == "Silver").Count();
            Athlets = a.Athlet.Where(x => x.Country.Name == Athlet.Country.Name).OrderByDescending(x => x.Medals.Count).ToList();

            // Athlet.Weight
        }
        public RelayCommand SelectCommand => selectCommand ?? (selectCommand = new RelayCommand(() =>
        {
            AthletInfo NewA = new AthletInfo(Index.Id);
            NewA.Show();
        }));
    }
}
