using OlympicApp.Model;
using OlympicApp.Repository;
using OlympicApp.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OlympicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Container.GetInstance<MainViewModel>();
            using (OlympicDB a = new OlympicDB())
            {
                //int j = 0;
                //foreach (var item in a.Team.ToList())
                //{
                //    int d = j + 4;

                //    if (d >= a.Athlet.Count())
                //    {
                //        j = 0;
                //        d = j + 4;
                //    }
                //        for (int i = j; i < d; i++)
                //        {
                //        item.Athlet.Add(a.Athlet.ToList()[j]);
                //        }
                //    j++;
                //}
                //foreach (var item in a.RaceForTeam.ToList())
                //{
                //    MessageBox.Show(item.Team.ToList()[0].OppositeTeams.ToList()[0].Team1.Country.Name);
                //}
                //    var C = a.Country.ToList<Country>();
                //    var G = a.Gender.ToList<Gender>();
                //    var CA = a.SportCathegory.ToList<SportCathegory>();
                //    var MT = a.MedalType.ToList<MedalType>();
                //    var M = a.Medal.ToList<Medal>();
                //    var R = a.Race.ToList<Race>();
                //var S = a.Stage.ToList<Stage>();
                // var T = a.Team.ToList<Team>();
                // var A = a.Athlet.ToList<Athlet>();
                //foreach (var item in a.Team.ToList())
                //{
                //    item.FlagPath = $@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\Flags\{item.Country.Name}.PNG";
                //}
                //foreach (var item in a.Stage)
                //{
                //    foreach (var item1 in A)
                //    {
                //        if (item.Race.SportCathegory.Id < 18 && item1.SportCathegores.Where(x => x.Name == item.Race.SportCathegory.Name).Count() >= 1)
                //        {
                //            Random Dd = new Random();
                //          if( Dd.Next(1,100)%3==0 )item.Athlet.Add(item1);
                //        }
                //    }
                //}

                //foreach (var item in a.Country.ToList())
                //{
                //    item.FlagPath = $@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\Flags\{item.Name}.PNG";
                //}


                //foreach (var item in a.Athlet.ToList())
                //{
                //    try
                //    {
                //        Directory.GetFiles($@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\AthlethImage\{item.Name}.jfif");

                //    }
                //    catch (Exception)
                //    {

                //        item.ImagePath = $@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\AthlethImage\Anonim.jfif";
                //    }
                //    try
                //    {
                //        Directory.GetFiles($@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\Flags\{item.Country.Name}.PNG");

                //    }
                //    catch (Exception)
                //    {

                //        item.CountryFlagImagePath = $@"C:\Users\Samur\OneDrive\Masaüstü\Olympic\OlympicApp\Image\Flags\Anonim.PNG";
                //    }
                //}
                // MessageBox.Show(a.Athlet.ToList()[0].);

                //int ca = 1;
                //foreach (var item in a.Race)
                //{

                //    int ii = 1;
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    a.RaceDegree.Add(new RaceDegree() { Place = ii++, Race = item });
                //    ii++;
                //    ca++;
                //    if (ca == CA.Count) ca = 0;
                //}
                //int i = 0;
                //foreach (var item in R)
                //{
                //    a.Stage.Add(new Stage()  { Time=new DateTime(2021,7,2), Race=item });
                //    a.Stage.Add(new Stage()  { Time=new DateTime(2021,7,3), Race=item });
                //    if(i%2==0)a.Stage.Add(new Stage()  { Time=new DateTime(2021,7,4), Race=item });
                //    if(i%3==0)a.Stage.Add(new Stage()  { Time=new DateTime(2021,7,5), Race=item });
                //    i++;
                //}
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[0], Name="Swimming" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[1], Name="Swimming" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[0], Name="Running" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[1], Name="Running" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[0], Name= "Badminton" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[1], Name= "Badminton" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[0], Name= "Boxing" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[1], Name= "Boxing" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[0], Name= "Judo" });
                // a.SportCathegory.Add(new SportCathegory() { Gender=G[1], Name="Judo" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[0], Name = "Wrestling" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[1], Name = "Wrestling" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[0], Name = "Shooting" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[1], Name = "Shooting" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[2], Name = "Shooting" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[0], Name = "Taekwondo" });
                // a.SportCathegory.Add(new SportCathegory() { Gender = G[1], Name = "Taekwondo" });

                //a.MedalType.Add(new MedalType() { Type="Gold"  });
                //a.MedalType.Add(new MedalType() { Type= "Silver" });
                //a.MedalType.Add(new MedalType() { Type= "Bronze" });
                //int i = 0;
                //for (int it = 0; it < CA.Count; it++)
                //{
                //    a.Medal.Add(new Medal() { MedalType = MT[0], SportCathegory = CA[it], TimeOfWon = new DateTime(2021, 7, i+1) });
                //    a.Medal.Add(new Medal() { MedalType = MT[1], SportCathegory = CA[it], TimeOfWon = new DateTime(2021, 7, i+1) });
                //    a.Medal.Add(new Medal() { MedalType = MT[2], SportCathegory = CA[it], TimeOfWon = new DateTime(2021, 7, i+1) });
                //    i++;
                //    if (i == 30) i = 1;
                //}


              // a.SaveChanges();
            }
        }
    }
}
