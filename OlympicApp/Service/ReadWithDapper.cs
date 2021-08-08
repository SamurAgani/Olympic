using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using OlympicApp.Model;
using System.Data.SqlClient;
using System.Windows;

namespace OlympicApp.Service
{
    public static class ReadWithDapper
    {
        public static string Constr { get; set; } = @"Data Source=DESKTOP-28DRIHF\SQLEXPRESS;Initial Catalog=Olyimpic;Integrated Security=True";
        public static List<Athlet> GetAthlets()
        {
            using (var con = new SqlConnection(Constr))
            {
                con.Open();
                var reader = con.Query<Athlet>("SELECT * FROM Athlets;");
                foreach (var item in reader.ToList())
                {
                    var medalreader= con.Query<Medal>($@"select *from medals  where Athlet_Id={item.Id.ToString()};");
                    item.Medals = medalreader.ToList();                    
                }
                return reader.ToList();
            }
        }
        public static List<Country> GetCountry()
        {
            using (var con = new SqlConnection(Constr))
            {
                con.Open();
                var reader = con.Query<Country>("SELECT * FROM Countries;");
                foreach (var item in reader.ToList())
                {
                    var medalreader = con.Query<Medal>($@"select *from medals  where Athlet_Id={item.Id.ToString()};");
                    item.Medals = medalreader.ToList();

                }
                return reader.ToList();
            }
        }
        public static Race GetRace(int Id)
        {
            using (var con = new SqlConnection(Constr))
            {
                con.Open();
                var reader = con.Query<Race>($"SELECT * FROM Races Where Id={Id.ToString()};");
                foreach (var item in reader.ToList())
                {
                    item.Winner= con.Query<Athlet>($"SELECT * FROM Athlets Where Id={item.Winner.Id};").FirstOrDefault();
                    item.Second= con.Query<Athlet>($"SELECT * FROM Athlets Where Id={item.Second.Id};").FirstOrDefault();
                    item.Third= con.Query<Athlet>($"SELECT * FROM Athlets Where Id={item.Third.Id};").FirstOrDefault();
                }

                return reader.ToList().FirstOrDefault();
            }
        }
    }
}
