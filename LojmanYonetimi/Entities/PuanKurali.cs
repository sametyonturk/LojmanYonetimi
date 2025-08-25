namespace LojmanYonetimi.Entities
{
    public class PuanKurali : BaseEntity
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public decimal SabitPuan { get; set; }
        public decimal KisiBasiKatSayisi { get; set; }
        public decimal YilKatSayi { get; set; }
        public decimal AylKatSayi { get; set; }
        public decimal AkademikTesvikPuan { get; set; }
        public decimal MaksimumPuan { get; set; }
        public string Aciklama { get; set; }
        public ICollection<KullaniciPuan> KullaniciPuans { get; set; } = new List<KullaniciPuan>();
    }
}
