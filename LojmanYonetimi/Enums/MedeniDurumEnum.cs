using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum MedeniDurumEnum
    {
        [Display(Name = "Evli")]
        Evli = 5,
        [Display(Name = "Bekar")]
        Bekar = 10,
        [Display(Name = "Boşanmış")]
        Bosanmis = 15,

    }
}
