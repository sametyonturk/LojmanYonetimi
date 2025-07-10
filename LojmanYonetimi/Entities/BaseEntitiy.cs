namespace LojmanYonetimi.Entities
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public string Ekleyen { get; set; }
        public string Duzenleyen { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public DateTime DuzenlemeTarihi { get; set; }
        public bool Silinmismi { get; set; }
        public bool Aktif { get; set; }
    }
}
