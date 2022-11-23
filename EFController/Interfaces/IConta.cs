using Entidades;
using System.ServiceModel;

namespace EFController.Interfaces
{
    public interface IConta
    {
        [OperationContract]
        void Cadastrar(string Nome, string Banco, string Agencia, string NumeroConta, string Digito, double Saldo);

        [OperationContract]
        Conta Buscar(int id);

        [OperationContract]
        List<Conta> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(int id, string Nome, string Banco, string Agencia, string NumeroConta, string Digito, double Saldo);
    }
}

