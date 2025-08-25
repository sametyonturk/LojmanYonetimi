namespace LojmanYonetimi.Entities
{
    public class Gorev : BaseEntity
    {
        public string GorevAd { get; set; }
        public string GorevKisaAd { get; set; }
        public int Sira { get; set; }
        public int Puan { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
    }
}
