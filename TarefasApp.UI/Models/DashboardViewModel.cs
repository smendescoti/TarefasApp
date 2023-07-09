using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.UI.Models
{
    /// <summary>
    /// Classe para definir o modelo de dados da página de dashboard
    /// </summary>
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            DashboardModelList = new List<DashboardModel>();

            DashboardModelList.Add(new DashboardModel { Categoria = "Trabalho", Quantidade = 15  });
            DashboardModelList.Add(new DashboardModel { Categoria = "Estudo", Quantidade = 10 });
            DashboardModelList.Add(new DashboardModel { Categoria = "Família", Quantidade = 5 });
            DashboardModelList.Add(new DashboardModel { Categoria = "Outros", Quantidade = 2 });
        }

        public List<DashboardModel> DashboardModelList { get; set; }
    }

    public class DashboardModel
    {
        public string Categoria { get; set; }
        public int? Quantidade { get; set; }
    }
}
