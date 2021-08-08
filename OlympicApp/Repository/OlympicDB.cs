using OlympicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Repository
{
    public class OlympicDB: DbContext
    {
        public DbSet<Athlet> Athlet { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<OppositeTeams> OppositeTeams { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Medal> Medal { get; set; }
        public DbSet<MedalType> MedalType { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<RaceForTeam> RaceForTeam { get; set; }
        public DbSet<RaceDegree> RaceDegree { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<SportCathegory> SportCathegory { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<StageForTeam> StageForTeam { get; set; }
        public DbSet<Team> Team { get; set; }
        public OlympicDB():base("name=Olyimpic")
        {}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Athlet>().HasKey(x=>x.Id);
            modelBuilder.Entity<Athlet>().HasIndex(x=>x.Id);

            modelBuilder.Entity<Country>().HasKey(x => x.Id);
            modelBuilder.Entity<Country>().HasIndex(x => x.Id);

            modelBuilder.Entity<Gender>().HasKey(x => x.Id);
            modelBuilder.Entity<Gender>().HasIndex(x => x.Id);

            modelBuilder.Entity<Medal>().HasKey(x => x.Id);
            modelBuilder.Entity<Medal>().HasIndex(x => x.Id);

            modelBuilder.Entity<MedalType>().HasKey(x => x.Id);
            modelBuilder.Entity<MedalType>().HasIndex(x => x.Id);

            modelBuilder.Entity<Race>().HasKey(x => x.Id);
            modelBuilder.Entity<Race>().HasIndex(x => x.Id);

            modelBuilder.Entity<RaceForTeam>().HasKey(x => x.Id);
            modelBuilder.Entity<RaceForTeam>().HasIndex(x => x.Id);

            modelBuilder.Entity<RaceDegree>().HasKey(x => x.Id);
            modelBuilder.Entity<RaceDegree>().HasIndex(x => x.Id);

            modelBuilder.Entity<OppositeTeams>().HasKey(x => x.Id);
            modelBuilder.Entity<OppositeTeams>().HasIndex(x => x.Id);

            modelBuilder.Entity<Sport>().HasKey(x => x.Id);
            modelBuilder.Entity<Sport>().HasIndex(x => x.Id);

            modelBuilder.Entity<SportCathegory>().HasKey(x => x.Id);
            modelBuilder.Entity<SportCathegory>().HasIndex(x => x.Id);

            modelBuilder.Entity<Stage>().HasKey(x => x.Id);
            modelBuilder.Entity<Stage>().HasIndex(x => x.Id);

            modelBuilder.Entity<StageForTeam>().HasKey(x => x.Id);
            modelBuilder.Entity<StageForTeam>().HasIndex(x => x.Id);

            modelBuilder.Entity<Team>().HasKey(x => x.Id);
            modelBuilder.Entity<Team>().HasIndex(x => x.Id);
        }
    }
}
