namespace LojmanYonetimi.Entities
{
    public class PuanKurali : BaseEntitiy
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
    }
}
