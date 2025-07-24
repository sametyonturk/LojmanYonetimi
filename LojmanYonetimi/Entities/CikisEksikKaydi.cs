namespace LojmanYonetimi.Entities
{
    public class CikisEksikKaydi : BaseEntitiy
    {
        public int KonutCikisBasvuruId { get; set; }
        public KonutCikisBasvuru KonutCikisBasvuru { get; set; }
        public string Aciklama { get; set; }
        public bool Giderildimi { get; set; }
        public DateTime EkleenmeTarihi { get; set; }
        public DateTime? GiderilmeTarihi { get; set; }
        public string GeriBildirim { get; set; }


    }
}
