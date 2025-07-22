namespace LojmanYonetimi.Entities
{
    public class Tahsis : BaseEntitiy
    {
        public int KonutId { get; set; }
        public int BasvuruId { get; set; }
        public DateTime TahsisTarihi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal ToplamPuan { get; set; }

    }
}
