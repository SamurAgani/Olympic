using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Medal
    {
       public int Id { get; set; }
       virtual public MedalType MedalType { get; set; }
       virtual public DateTime TimeOfWon { get; set; }
       virtual public SportCathegory SportCathegory { get; set; }
    }
}
