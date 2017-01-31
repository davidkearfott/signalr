namespace HTTR.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Position Position { get; set; }
        public int Rating { get; set; }
    }

    public enum Position
    {
       QB = 0,
       RB = 1,
       WR = 2
    }
}