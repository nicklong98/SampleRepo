using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GreeterAndRandomNumberGame.Models
{
    public class RandomNumberGameViewModel
    {
        [DisplayName("Minimum Value")]
        public int MinValue { get; set; } = 0;
        [DisplayName("Maximum Value")]
        public int MaxValue { get; set; } = 10;
        public bool StartNewGame { get; set; }
        
        public int TargetNumber { get; set; }
        public int? Guess { get; set; }
    }
}