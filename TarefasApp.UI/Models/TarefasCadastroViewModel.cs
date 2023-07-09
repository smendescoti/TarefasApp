using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Services.Models.Requests;

namespace TarefasApp.UI.Models
{
    /// <summary>
    /// Classe para definir o modelo de dados da página de cadastro de tarefa
    /// </summary>
    public class TarefasCadastroViewModel
    {
        //propriedade para acesso ao modelo do formulário
        public TarefasCadastroRequestModel TarefasCadastroRequestModel { get; set; }

        //construtor
        public TarefasCadastroViewModel()
        {
            TarefasCadastroRequestModel = new TarefasCadastroRequestModel();
        }
    }
}
