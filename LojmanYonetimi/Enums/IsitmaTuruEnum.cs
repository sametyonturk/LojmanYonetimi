using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum IsitmaTuruEnum
    {
        [Display(Name = "Klima")]
        Klima = 5,

        [Display(Name = "Kalorifer")]
        Kalorifer = 10,

        [Display(Name ="Doğalgaz")]
        Dogalgaz = 15,

        [Display(Name = "Soba")]
        Soba = 20,

        [Display(Name = "Diğer")]
        Diger = 25,

        
    }
}
