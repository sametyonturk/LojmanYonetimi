using LojmanYonetimi.Enums;

namespace LojmanYonetimi.Entities
{
    public class Konut : BaseEntity
    {
        public int BinaId { get; set; }
        public Bina Bina { get; set; }
        public int OdaTipiId { get; set; } = default!;
        public OdaTipi OdaTipi { get; set; }
        public KatEnum KatEnum { get; set; } = default!;
        public int DaireNo { get; set; }
        public string DaireAd { get; set; }
        public int MetreKare { get; set; }
        public IsitmaTuruEnum IsitmaTuruEnum { get; set; }
        public DaireTuruEnum DaireTuruEnum { get; set; }
        public bool Esyalimi { get; set; }
        public KonutDurumEnum KonutDurumEnum { get; set; }
        public string Aciklama { get; set; }
    }
}
