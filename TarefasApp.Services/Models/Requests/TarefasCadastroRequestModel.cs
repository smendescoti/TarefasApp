﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Services.Models.Requests
{
    /// <summary>
    /// Modelo de dados para a requisição de cadastro de tarefas
    /// </summary>
    public class TarefasCadastroRequestModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Entre com o nome da tarefa:")]
        [Required(ErrorMessage = "Por favor, informe o nome da tarefa.")]
        public string? Nome { get; set; }

        [Display(Name = "Data e hora de início:")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Por favor, informe a data e hora de início.")]
        public string? DataHoraInicio { get; set; }

        [Display(Name = "Data e hora de término:")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Por favor, informe a data e hora de término.")]
        public string? DataHoraFim { get; set; }

        [Display(Name = "Selecione a categoria desta tarefa:")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Por favor, selecione a categoria.")]
        public string? Categoria { get; set; }

        [Display(Name = "Informe as obervações:")]
        [DataType(DataType.MultilineText)]
        public string? Observacoes { get; set; }
    }
}
