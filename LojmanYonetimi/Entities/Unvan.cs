namespace LojmanYonetimi.Entities
{
    public class Unvan : BaseEntitiy
    {
        public string UnvanAd { get; set; }
        public string UnvanKisaAd { get; set; }
        public int Sira { get; set; }
        public int Puan { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
    }
}
