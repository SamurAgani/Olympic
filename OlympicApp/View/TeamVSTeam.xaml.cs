using OlympicApp.Model;
using OlympicApp.ViewModel;
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
    /// Interaction logic for TeamVSTeam.xaml
    /// </summary>
    public partial class TeamVSTeam : Window
    {
        public TeamVSTeam(OppositeTeams a)
        {
            InitializeComponent();
            DataContext = new TeamVSTeamVM(a);
        }
    }
}
