using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EFController.Interfaces
{
    public interface IMovimento
    {
        [OperationContract]
        void Cadastrar(string descricao, string Tipomov, DateTime datamov, double Valor, int idconta);

        [OperationContract]
        Conta Buscar(int id);

        [OperationContract]
        List<Conta> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(int id, string descricao, string Tipomov, DateTime datamov, double Valor, int idconta);
    }
}