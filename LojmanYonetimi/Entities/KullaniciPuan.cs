namespace LojmanYonetimi.Entities
{
    public class KullaniciPuan : BaseEntitiy
    {
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int PuanKuraliId { get; set; }
        public PuanKurali PuanKurali { get; set; }
        public decimal Puan { get; set; }
    }
}
