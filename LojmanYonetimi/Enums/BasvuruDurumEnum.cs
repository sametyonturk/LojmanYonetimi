using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum BasvuruDurumEnum
    {
        [Display(Name = "Beklemede")]
        Beklemede = 5,

        [Display(Name = "Onay")]
        Onay = 10,

        [Display(Name = "Red")]
        Red = 15,

        [Display(Name = "Tadilatta")]
        Tadilatta = 20
    }
}
