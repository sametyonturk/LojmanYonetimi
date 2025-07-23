using LojmanYonetimi.Enums;

namespace LojmanYonetimi.Entities
{
    public class Basvuru : BaseEntitiy
    {
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = default!;
        public DateTime BasvuruTarihi { get; set; }
        public BasvuruDurumEnum BasvuruDurum { get; set; }
        public string Aciklama { get; set; }
        public int TahsisId { get; set; }
        public string TercihEdilenKampus { get; set; }
        public string  TercihEdilenKonut { get; set; }
        public TasisTuruEnum TasisTuru { get; set; }

    }
}
