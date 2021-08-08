using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Team
    {
        public int Id { get; set; }
       virtual public Country Country { get; set; }
       virtual public List<Athlet> Athlet { get; set; }
       virtual public SportCathegory SportCathegory { get; set; }
       virtual public List<Medal> Medal { get; set; }
        public string FlagPath { get; set; }
    }
}
