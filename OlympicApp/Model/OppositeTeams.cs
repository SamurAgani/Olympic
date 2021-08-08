using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class OppositeTeams
    {
        public int Id { get; set; }
         virtual public Team Team1 { get; set; }
        virtual public Team Team2 { get; set; }
    }
}
