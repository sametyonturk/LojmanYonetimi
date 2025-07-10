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

        // Diğer özel alanlar: CezaAlmisMi, SehitYakinlikDurumu vb.
    }
}
