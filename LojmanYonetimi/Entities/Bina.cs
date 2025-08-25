namespace LojmanYonetimi.Entities
{
    public class Bina : BaseEntity
    {
        public int KampusId { get; set; }
        public Kampus Kampus { get; set; } = default!;
        public string BinaAd { get; set; }
        public string BinaNo { get; set; }
        public bool AsansorVarmi { get; set; }
        public bool CatiVarmi { get; set; }
        public bool OtoparkVarmi { get; set; }
        public bool EngelliGirisiVarmi { get; set; }
        public string Aciklama { get; set; }

        public ICollection<Konut> Konuts { get; set; } = new List<Konut>();

    }
}
