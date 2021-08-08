using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Stage
    {
        public int Id { get; set; }
        virtual public DateTime Time { get; set; }
        virtual public List<Athlet> Athlet { get; set; }
        virtual public Race Race { get; set; }
        string Athlets;
        public override string ToString()
        {
            foreach (var item in Athlet)
            {
                Athlets = Athlet+"  "+item.Name;
            }
            return Athlets;
        }
    }
}
