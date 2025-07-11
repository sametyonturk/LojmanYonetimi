namespace LojmanYonetimi.Entities
{
    public class Birim : BaseEntitiy
    {
        public string BirimAd { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
    }
}
