using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.ResponseDTO
{
    public class GetCinemaDto
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Foto")]
        public string LogoURL { get; set; }


        public List<string> NomeFilmes { get; set; }
        public List<string> FotoURLFilmes { get; set; }
    }
}
