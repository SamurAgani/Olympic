using GalaSoft.MvvmLight.Messaging;
using OlympicApp.Repository;
using OlympicApp.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OlympicApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }

        protected override async void OnStartup(StartupEventArgs e)
        {

            OlympicDB a = new OlympicDB();

            if (File.Exists(Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + $@"\Image\AthlethImage\{a.Athlet.ToList()[0].Name}.jfif"))
            {
                foreach (var item in a.Athlet.ToList())
                {
                    item.ImagePath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\AthlethImage\" + item.Name + ".jfif";
                }
            }
            if (File.Exists(Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + $@"\Image\Flags\{a.Country.ToList()[0].Name}.png"))
            {
                foreach (var item in a.Country.ToList())
                {
                    item.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    foreach (var item1 in a.Athlet.ToList().Where(x => x.Country.Name == item.Name))
                    {
                        item1.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    }
                }
            }
            if (File.Exists(Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + $@"\Image\Flags\{a.Country.ToList()[0].Name}.png"))
            {
                foreach (var item in a.Country.ToList())
                {
                    item.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    foreach (var item1 in a.Athlet.ToList().Where(x => x.Country.Name == item.Name))
                    {
                        item1.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    }
                }
            }
            if (File.Exists(Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + $@"\Image\Flags\{a.Country.ToList()[0].Name}.png"))
            {
                foreach (var item in a.Country.ToList())
                {
                    item.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    foreach (var item1 in a.Athlet.ToList().Where(x => x.Country.Name == item.Name))
                    {
                        item1.FlagPath = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\Flags\" + item.Name + ".png";
                    }
                }
            }
            await a.SaveChangesAsync();
            await asdasd();

            base.OnStartup(e);
        }

        private static Task asdasd()
        {          
            return new Task(()=> {
                Container = new Container();
                Container.RegisterSingleton<Messenger>();
                Container.RegisterSingleton<SportsVM>();
                Container.RegisterSingleton<MainViewModel>();
                Container.RegisterSingleton<ResultVM>();
                Container.RegisterSingleton<TeamNocVM>();
                Container.RegisterSingleton<AthletsVM>();
                Container.RegisterSingleton<BestOfVM>();
                Container.RegisterSingleton<InfoSportVM>();
            });
        }
    }
}
