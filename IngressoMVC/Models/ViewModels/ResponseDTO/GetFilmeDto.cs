using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.ResponseDTO
{
    public class GetFilmeDto
    {
        [Display(Name = "Título")]
        public string Titutlo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }


        public List<string> Categorias { get; set; }
        public List<string> FotoURLProdutores { get; set; }
    }
}

