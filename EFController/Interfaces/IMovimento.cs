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
        void Cadastrar(Movimento obj);

        [OperationContract]
        Movimento Buscar(int id);

        [OperationContract]
        List<Movimento> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Movimento objNovo);
    }
}

