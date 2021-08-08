using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class SportCathegory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        virtual public Gender Gender { get; set; }
        virtual public TeamOrOwn TeamOrOwn { get; set; }
        virtual public List<Athlet> Athlet { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
