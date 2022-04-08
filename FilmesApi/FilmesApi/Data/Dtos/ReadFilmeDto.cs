using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo genero não pode ultrapassar 30 caractéres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ser entre 1 a 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
