using System.Security.Principal;

namespace LojmanYonetimi.Entities
{
    public class OdaTipi : BaseEntitiy
    {
        public int OdaSayisi { get; set; }
        public string OdaAd { get; set; } = default!;
        public string Aciklama { get; set; } = default!;
        public ICollection<Konut> Konuts { get; set; } = new List<Konut>();
    }
}
