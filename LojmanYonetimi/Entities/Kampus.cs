namespace LojmanYonetimi.Entities
{
    public class Kampus : BaseEntitiy
    {
        
        public string KampusAd { get; set; } = default!;
        public ICollection<Bina> Binas { get; set; } = new List<Bina>();
    }
}
