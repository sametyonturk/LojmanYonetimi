namespace LojmanYonetimi.Entities
{
    public class Birim : BaseEntitiy
    {
        public string BirimAd { get; set; }

        public int? UstBirimId { get; set; }             // Kendini referans eder
        public Birim? UstBirim { get; set; }             // Üst birim
        public ICollection<Birim> AltBirimler { get; set; } = new List<Birim>(); // Alt birimle

        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
    }
}
