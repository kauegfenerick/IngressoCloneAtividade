using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostFilmeDTO
    {
        [Required(ErrorMessage ="Nome do filme é obrigatório")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preço do filme é obrigatório")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Imagem do filme é obrigatório")]
        public string ImageURL { get; set; }

        #region relacionamentos
        public string NomeCinema { get; set; }

        public int ProdutorId { get; set; }

        public List<int> AtoresId { get; set; }
        public List<int> CategoriasId { get; set; } //Por Id
        #endregion
    }
}
