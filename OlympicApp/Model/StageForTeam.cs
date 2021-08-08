using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class StageForTeam
    {
        public int Id { get; set; }
        virtual public DateTime Time { get; set; }
        virtual public List<OppositeTeams> OppositeTeams { get; set; }
        virtual public Race Race { get; set; }
    }
}
