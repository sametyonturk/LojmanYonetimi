using LojmanYonetimi.Enums;

namespace LojmanYonetimi.Entities
{
    public class KonutCikisBasvuru : BaseEntity
    {
        public int TahsisId { get; set; }
        public Tahsis Tahsis { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public DateTime BasvuruTarihi { get; set; }
        public Basvuru Basvuru { get; set; }
        public CikisBasvuruDurumEnum CikisBasvuruDurumEnum { get; set; }
        public string Aciklama { get; set; }
    }
}
