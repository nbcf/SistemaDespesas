using EFController.Interfaces;
using EFController.Repositories;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MovimentoController : IMovimento
    {
        private MovimentoRep rep = new MovimentoRep();


        public void Cadastrar(string descricao, string Tipomov, DateTime datamov, double Valor, int idmovi)
        {
            Movimento movicad = new Movimento();
            movicad.Descricao = descricao;
            movicad.Tipomov = Tipomov;
            movicad.Datamov = datamov;
            movicad.Valor = Valor;
            movicad.Idconta = idmovi;
            rep.Cadastrar(movicad);
        }




        public Movimento Buscar(int id)
        {
            return rep.Buscar(id);
        }


        public List<Movimento> Listar()
        {
            return rep.Listar();
        }


        //public DataTable ComboBoxmovi() {

        //    return rep.combobox();
        //}
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(int id, string descricao, string Tipomov, DateTime datamov, double Valor, int idmovi)
        {
            Movimento moviedit = new Movimento();
            moviedit.Id = id;
            moviedit.Descricao = descricao;
            moviedit.Tipomov = Tipomov;
            moviedit.Datamov = datamov;
            moviedit.Valor = Valor;
            moviedit.Idconta = idmovi;
            rep.Editar(moviedit);
        }


        public List<Movimento> ListarPaginada(string listarPor, string ordernarPor, int limitt, int offset)
        {
            return rep.ListarPaginada(listarPor, ordernarPor, limitt, offset);
        }
        public List<Movimento> PesquisarComecaCom(string coluna, string campo, string pesquisar)
        {
            ListarPesquisados();



            return rep.PesquisarComeca(coluna, campo, pesquisar);
        }

        public List<Movimento> PesquisarContemCom(string coluna, string campo, string pesquisar)
        {
            ListarPesquisados();
            return rep.PesquisarContem(coluna, campo, pesquisar);
        }

        public List<Movimento> PesquisarTerminaCom(string coluna, string campo, string pesquisar)
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

        Conta IMovimento.Buscar(int id)
        {
            throw new NotImplementedException();
        }

        List<Conta> IMovimento.Listar()
        {
            throw new NotImplementedException();
        }

        public string AcaoCrudMovimentoController()
        {
            return rep.AcaoCrudMovimentoREP();

        }
    }
}


