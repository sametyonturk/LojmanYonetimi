using System.ComponentModel.DataAnnotations;

namespace LojmanYonetimi.Enums
{
    public enum DaireTuruEnum
    {
        [Display(Name = "Konut")]
        Konut = 5,

        [Display(Name = "Rektörlük")]
        Rektorluk = 10,

        [Display(Name = "Erasmus")]
        Erasmus = 15,

        [Display(Name = "Sosyal Tesis")]
        SosyalTesis = 20,

        [Display(Name = "Misafirhane")]
        Misafirhane = 25,

        [Display(Name = "Kapıcı Dairesi")]
        Kapici = 30
    }

}
