using System.Collections.Generic;

namespace HTTR.Models
{
    public static class Roster
    {
        public static int counter = 0;

        public static List<Player> Players = new List<Player>();

        public static void LoadRoster()
        {
            Players.Add(new Player { Name = "Kirk Cousins", Id = 1, Image = Links.Content.Images.KirkCousins_png, Rating = 0, Position = Position.QB });
            Players.Add(new Player { Name = "Colt McCoy", Id = 2, Image = Links.Content.Images.ColtMcCoy_png, Rating = 0, Position = Position.QB });
            Players.Add(new Player { Name = "Nate Sudfield", Id = 3, Image = Links.Content.Images.NateSudfield_png, Rating = 0, Position = Position.QB });

            Players.Add(new Player { Name = "Matt Jones", Id = 4, Image = Links.Content.Images.MattJones_png, Rating = 0, Position = Position.RB });
            Players.Add(new Player { Name = "Chris Thompson", Id = 5, Image = Links.Content.Images.ChrisThompson_png, Rating = 0, Position = Position.RB });
            Players.Add(new Player { Name = "Rob Kelley", Id = 6, Image = Links.Content.Images.FatRobKelley_png, Rating = 0, Position = Position.RB });

            Players.Add(new Player { Name = "DeSean Jackson", Id = 7, Image = Links.Content.Images.DeSeanJackson_png, Rating = 0, Position = Position.WR });
            Players.Add(new Player { Name = "Pierre Garcon", Id = 8, Image = Links.Content.Images.PierreGarcon_png, Rating = 0, Position = Position.WR });
            Players.Add(new Player { Name = "Jamison Crowder", Id = 9, Image = Links.Content.Images.JamisonCrowder_png, Rating = 0, Position = Position.WR });


        }
    }
}