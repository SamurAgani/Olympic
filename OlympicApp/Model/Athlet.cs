using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Athlet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImagePath { get; set; }
        public int Weight { get; set; }
        public string FlagPath { get; set; }
        virtual public DateTime BirthDay { get; set; }
        virtual public List<SportCathegory> SportCathegores { get; set; }
        virtual public Country Country { get; set; }
        virtual public List<Medal> Medals { get; set; }
        virtual public Gender Gender { get; set; }
        virtual public List<RaceDegree> RaceDegree { get; set; }
        virtual public List<Stage> Stage { get; set; }
    }
}
