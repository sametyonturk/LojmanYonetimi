using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum KonutDurumEnum
    {
        [Display(Name = "Boş")]
        Bos = 5,

        [Display(Name = "Dolu")]
        Dolu = 10,

        [Display(Name = "Tadilatta")]
        Tadilat = 15,

        [Display(Name = "Teslim Almada")]
        TeslimAlmada = 20
    }
}
