using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum CikisBasvuruDurumEnum
    {
        [Display(Name = "Beklemede")]
        Beklemede = 5,

        [Display(Name = "Onay")]
        Onay = 10,

        [Display(Name = "Red")]
        Red = 15,
    }
}
