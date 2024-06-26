
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public interface IPlanoContaService
    {
        List<PlanoContaModel> ListarRegistros();
        
        void Salvar(PlanoContaModel model);

        void Excluir(int id);

        PlanoContaModel RetornarRegistro(int id);
    }
}