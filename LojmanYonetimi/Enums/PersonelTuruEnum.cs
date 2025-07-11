using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum PersonelTuruEnum
    {
        [Display(Name = "Akademik")]
        Akademik = 0,

        [Display(Name = "İdari")]
        Idari = 1,

        [Display(Name = "Sözleşmeli")]
        Sozlesmeli = 2
    }
}
