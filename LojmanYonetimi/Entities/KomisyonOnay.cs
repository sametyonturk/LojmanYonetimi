using LojmanYonetimi.Enums;

namespace LojmanYonetimi.Entities
{
    public class KomisyonOnay : BaseEntity
    {
        public int KonutCikisBasvuruId { get; set; }
        public KonutCikisBasvuru KonutCikisBasvuru { get; set; }
        public int KomisyonUyeId { get; set; }
        public ApplicationUser KomisyonUye { get; set; } = default!;

        public OnayDurumuEnum OnayDurumu { get; set; }

        public string? Aciklama { get; set; }

        public DateTime OnayTarihi { get; set; }
    }
}
