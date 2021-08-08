using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class RaceDegree
    {
        public int Id { get; set; }
        virtual public SportCathegory SportCathegory { get; set; }
        public double Place { get; set; }
        virtual public Race Race { get; set; }
    }
}
