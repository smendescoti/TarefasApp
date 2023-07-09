﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Services.Models.Requests;

namespace TarefasApp.UI.Models
{
    /// <summary>
    /// Classe para definir o modelo de dados da página de recuperação de senha
    /// </summary>
    public class RecuperarSenhaViewModel
    {
        //Propriedade para acessar o modelo de dados
        public RecuperarSenhaRequestModel RecuperarSenhaRequestModel { get; set; }

        //construtor
        public RecuperarSenhaViewModel()
        {
            this.RecuperarSenhaRequestModel = new RecuperarSenhaRequestModel();
        }
    }
}
