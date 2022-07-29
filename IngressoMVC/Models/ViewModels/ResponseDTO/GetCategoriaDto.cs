using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.ResponseDTO
{
    public class GetCategoriaDto
    {
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }
   

        public List<string> NomeFilmes { get; set; }
        public List<string> FotoURLFilmes { get; set; }
    }
}
