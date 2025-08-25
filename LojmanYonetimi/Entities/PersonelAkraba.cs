namespace LojmanYonetimi.Entities
{
    public class PersonelAkraba : BaseEntity
    {
        public string KonukAdSoyad { get; set; }
        public int ApplicationUserId { get; set; }
        public string KonukTckn { get; set; }
        public DateTime KonukDogumTarihi { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
