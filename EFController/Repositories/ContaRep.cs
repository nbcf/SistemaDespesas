using EFController.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFController.Repositories
{
    public class ContaRep
    {

        SistemaContext ctx = new SistemaContext();
        public int listarQtPesquisa = 0;
        public string acaoCrudConta = "";
        public void Cadastrar(Conta obj)
        {

            //// using (SistemaContext ctx = new SistemaContext())
            // {

            try
            {
                ctx.Contas.Add(obj);
                ctx.SaveChanges();
                acaoCrudConta = "S!";
            }
            catch (Exception e)
            {
                acaoCrudConta = "NS";
            }
            //}

        }


        public Conta Buscar(int id)
        {
            Conta obj = new Conta();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Contas.Find(id);
            }
            return obj;
        }


        public List<Conta> Listar()
        {

            // using (var ctx = new SistemaContext()){
            var Contas = (from obj in ctx.Contas select obj).OrderBy(x => x.Nome).ToList();
            return Contas;

        }

        public List<Conta> ListarPaginada(string listarPor, string ordernarPor, int limitt, int offset)
        {

            var ctx = new SistemaContext();
            List<Conta> contasListadas = new List<Conta>();


            if (listarPor.Equals("id") && ordernarPor.Equals("asc"))
            {
                var Contas = (from obj in ctx.Contas select obj).OrderBy(x => x.Id).Skip(limitt).Take(offset).ToList();
                contasListadas = Contas;
            }
            else if (listarPor.Equals("id") && ordernarPor.Equals("desc"))
            {
                var Contas = (from obj in ctx.Contas select obj).OrderByDescending(x => x.Id).Skip(limitt).Take(offset).ToList();
                contasListadas = Contas;
            }
            else if (listarPor.Equals("nome") && ordernarPor.Equals("asc"))
            {

                var Contas = (from obj in ctx.Contas select obj).OrderBy(x => x.Nome).Skip(limitt).Take(offset).ToList();
                contasListadas = Contas;
            }
            else if (listarPor.Equals("nome") && ordernarPor.Equals("desc"))
            {
                var Contas = (from obj in ctx.Contas select obj).OrderByDescending(x => x.Nome).Skip(limitt).Take(offset).ToList();
                contasListadas = Contas;
            }

            return contasListadas;

        }

        public int ListarTudo()
        {
            var Contas = (from obj in ctx.Contas select obj);
            return Contas.Count();

        }

        public void Deletar(int id)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + id, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Conta obj = ctx.Contas.Find(id);
                    ctx.Contas.Remove(obj);
                    ctx.SaveChanges();
                    acaoCrudConta = "DEL";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);

                }
            }
            else if (resultado == DialogResult.No)
            {
                acaoCrudConta = "NDEL";
            }

        }

        public void Editar(Conta objNovo)
        {
            //   using (var ctx = new SistemaContext())
            // {
            try
            {
                Conta objAntigo = ctx.Contas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Banco = objNovo.Banco;
                objAntigo.Agencia = objNovo.Agencia;
                objAntigo.NumeroConta = objNovo.NumeroConta;
                objAntigo.Digito = objNovo.Digito;
                objAntigo.Saldo = objNovo.Saldo;
                ctx.SaveChanges();
                acaoCrudConta = "EDIT!";
            }
            catch (Exception e)
            {
                acaoCrudConta = "NEDIT";

            }

            // }
        }


        public int ListarPesquisados()
        {
            return listarQtPesquisa;
        }

        public string AcaoCrudContaREP()
        {
            return acaoCrudConta;
        }


        //List<Conta> ListarPaginada(string listarPor, string ordernarPor, int limitt, int offset)
        public List<Conta> PesquisarComeca(string coluna, object campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Conta> contasListadasPesquisarComeca = new List<Conta>();

            try
            {

                if (pesquisar == "")
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.StartsWith(pesquisar)).OrderBy(x => x.Nome).ToList();
                    contasListadasPesquisarComeca = Contas;

                }
                else
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.StartsWith(pesquisar)).OrderBy(x => x.Nome).ToList();
                    contasListadasPesquisarComeca = Contas;
                }
                listarQtPesquisa = contasListadasPesquisarComeca.Count;
                return contasListadasPesquisarComeca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Conta> PesquisarContem(string coluna, string campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Conta> contasListadasPesquisarContem = new List<Conta>();
            try
            {

                if (pesquisar == "")
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.Contains(pesquisar)).OrderBy(x => x.Nome).ToList();
                    contasListadasPesquisarContem = Contas;
                }
                else
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.Contains(pesquisar)).OrderBy(x => x.Nome).ToList();
                    contasListadasPesquisarContem = Contas;
                }
                listarQtPesquisa = contasListadasPesquisarContem.Count;
                return contasListadasPesquisarContem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Conta> PesquisarTermina(string coluna, string campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Conta> listaPesquisarTermina = new List<Conta>();

            try
            {


                if (pesquisar == "")
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.EndsWith(pesquisar)).OrderBy(x => x.Nome).ToList();
                    listaPesquisarTermina = Contas;
                }
                else
                {
                    var Contas = (from obj in ctx.Contas select obj).Where(x => x.Nome.EndsWith(pesquisar)).OrderBy(x => x.Nome).ToList();
                    listaPesquisarTermina = Contas;
                }



                listarQtPesquisa = listaPesquisarTermina.Count;
                return listaPesquisarTermina;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}