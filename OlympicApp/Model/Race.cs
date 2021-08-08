using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Race
    {
        public int Id { get; set; }
        virtual public SportCathegory SportCathegory { get; set; }
        virtual public List<Stage> Athlet { get; set; }
        virtual public Athlet Winner { get; set; }
        virtual public Athlet Second { get; set; }
        virtual public Athlet Third { get; set; }
    }
}
