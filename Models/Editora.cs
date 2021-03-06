using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaAPI.Models
{
    public class Editora
    {

        public Editora() { }
        public Editora(int id, string nome, string cidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cidade = cidade;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}