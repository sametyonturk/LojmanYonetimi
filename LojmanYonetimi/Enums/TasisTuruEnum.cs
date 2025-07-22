using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum TasisTuruEnum
    {
        [Display(Name = "Sıra")]
        Sira = 1,

        [Display(Name = "görev")]
        Gorev = 2,

        [Display(Name = "Hizmetli")]
        Hizmetli = 3
    }
}
