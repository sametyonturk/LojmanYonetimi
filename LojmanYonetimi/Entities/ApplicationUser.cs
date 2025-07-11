using LojmanYonetimi.Enums;
using Microsoft.AspNetCore.Identity;

namespace LojmanYonetimi.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Ad { get; set; } = default!;
        public string Soyad { get; set; } = default!;
        public string KurumSicilNo { get; set; } = default!;
        public bool EngelliMi { get; set; }
        public MedeniDurumEnum MedeniDurum { get; set; }
        public int UnvanId { get; set; }
        public Unvan Unvan{ get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
     

        public ICollection<PersonelAkraba> PersonelAkrabas { get; set; } = new List<PersonelAkraba>();
        // Diğer özel alanlar: CezaAlmisMi, SehitYakinlikDurumu vb.
    }
}
