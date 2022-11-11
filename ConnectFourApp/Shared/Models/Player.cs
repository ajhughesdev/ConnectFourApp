using System.ComponentModel.DataAnnotations;

namespace ConnectFourApp.Shared.Models
{
    [Serializable]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
