using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Model
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        virtual public List<SportCathegory> SportCathegory { get; set; }
        public string ImagePath { get; set; }
    }
}
