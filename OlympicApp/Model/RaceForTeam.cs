using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class RaceForTeam
    {
        public int Id { get; set; }
        virtual public SportCathegory SportCathegory { get; set; }
        virtual public List<StageForTeam> Team { get; set; }
        virtual public Team Winner { get; set; }
        virtual public Team Second { get; set; }
        virtual public Team Third { get; set; }
}
}
