using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerenciamento_Biblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }


        public void RealizarReserva()
        {
            // Lógica para realizar a reserva do livro
        }

        public void RealizarEmprestimo()

        {
            // Lógica para realizar o emprés�mo do livro
        }
        public void AtualizarLivro()
        {
            // Lógica para atualizar as informações do livro no banco de dados
        }

        public void RegistrarInformacoesRetirante()
        {
            // Lógica para registrar as informações de quem retirou o livro
        }
    }
}
