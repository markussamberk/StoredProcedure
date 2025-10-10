using System.ComponentModel.DataAnnotations;

namespace StoredProcedure123.Models
{
    public class Cars
    {
        [Key]
        public string FirstName { get; set; }
        public string TopSpeed { get; set; }
        public int HamburgersEaten { get; set; }
        public int TimesRanOutOfGas { get; set; }
        public int RacesWon { get; set; }
    }
}
