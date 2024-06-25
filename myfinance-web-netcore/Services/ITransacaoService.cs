using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public interface ITransacaoService
    {
        List<TransacaoModel> ListarRegistros();
        
        void Salvar(TransacaoModel model);

        void Excluir(int id);

        TransacaoModel RetornarRegistro(int id);
    }
}