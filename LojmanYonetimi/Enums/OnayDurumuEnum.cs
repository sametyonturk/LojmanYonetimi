using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum OnayDurumuEnum
    {
        [Display(Name = "Beklemede")] Beklemede = 0,
        [Display(Name = "Onaylandı")] Onaylandi = 1,
        [Display(Name = "Reddedildi")] Reddedildi = 2
    }
}
