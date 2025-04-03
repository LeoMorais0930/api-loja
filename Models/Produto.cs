using System.ComponentModel.DataAnnotations.Schema;

namespace Lojinha_Jorges.Models
{
    [Table("PRODUTOS")]
    public class Produto : Generico
    {
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }

        
        public Produto(string descricao, double preco)
        {
            Id = Guid.NewGuid();

            Descricao = descricao;
            Preco = preco;  
        }
    }

   
}
