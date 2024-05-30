
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
       [Key]
        public int Id { get; set; }
        
        [Column(TypeName = "text")]
        public string Titulo { get; set; }
        
        [Column(TypeName = "text")]
        public string Descricao { get; set; }
        
        [Column(TypeName = "timestamp")]
        public DateTime Data { get; set; }
        
        public EnumStatusTarefa Status { get; set; }
    }
}