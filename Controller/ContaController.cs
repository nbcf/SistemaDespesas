using EFController.Interfaces;
using EFController.Map;
using EFController.Repositories;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ContaController : IConta
    {
        private ContaRep rep = new ContaRep();

 
        public void Cadastrar(string Nome, string Banco, string Agencia, string NumeroConta, string Digito, double Saldo, DateTime dataAbertura, string descricao)
        {
            Conta contacad = new Conta();
            contacad.Nome = Nome;
            contacad.Banco = Banco;
            contacad.Agencia = Agencia;
            contacad.NumeroConta = NumeroConta;
            contacad.Digito = Digito;
            contacad.Saldo = Saldo;
            contacad.Data_Abertura = dataAbertura;
            contacad.Descricao = descricao;
            rep.Cadastrar(contacad);
        }

        public Conta Buscar(int id)
        {
            return rep.Buscar(id);
        }


        public List<Conta> Listar()
        {
            return rep.Listar();
        }


        //public DataTable ComboBoxConta() {

        //    return rep.combobox();
        //}
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(int id, string Nome, string Banco, string Agencia, string NumeroConta, string Digito, double Saldo, DateTime dataAbertura, string descricao)
        {
            Conta contaedit = new Conta();
            contaedit.Id = id;
            contaedit.Nome = Nome;
            contaedit.Banco = Banco;
            contaedit.Agencia = Agencia;
            contaedit.NumeroConta = NumeroConta;
            contaedit.Digito = Digito;
            contaedit.Saldo = Saldo;
            contaedit.Data_Abertura = dataAbertura;
            contaedit.Descricao = descricao;
            rep.Editar(contaedit);
        }


        public List<Conta> ListarPaginada(string listarPor, string ordernarPor, int limitt, int offset)
        {
            return rep.ListarPaginada(listarPor, ordernarPor, limitt, offset);
        }
        public List<Conta> PesquisarComecaCom(string coluna, string campo, string pesquisar)
        {
            ListarPesquisados();



            return rep.PesquisarComeca(coluna, campo, pesquisar);
        }

        public List<Conta> PesquisarContemCom(string coluna, string campo, string pesquisar)
        {
            ListarPesquisados();
            return rep.PesquisarContem(coluna, campo, pesquisar);
        }

        public List<Conta> PesquisarTerminaCom(string coluna, string campo, string pesquisar)
        {
            ListarPesquisados();
            return rep.PesquisarTermina(coluna, campo, pesquisar);
        }

        public int ListarTudoController()
        {
            return rep.ListarTudo();
        }

        public int ListarPesquisados()
        {

            return rep.ListarPesquisados();
        }
        public string AcaoCrudContaController()
        {
            return rep.AcaoCrudContaREP();

        }
    }
}

