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
    public class MovimentoRep
    {

        SistemaContext ctx = new SistemaContext();
        public int listarQtPesquisa = 0;
        public string acaoCrudMovimento = "";
        public void Cadastrar(Movimento obj)
        {
            try
            {
                ctx.Movimentos.Add(obj);
                ctx.SaveChanges();
                acaoCrudMovimento = "S!";
            }
            catch (Exception e)
            {
                acaoCrudMovimento = "NS";
            }

        }

        public void Editar(Movimento objNovo)
        {
            try
            {
                Movimento objAntigo = ctx.Movimentos.Find(objNovo.Id);
                objAntigo.Descricao = objNovo.Descricao;
                objAntigo.Tipomov= objNovo.Tipomov;
                objAntigo.Datamov = objNovo.Datamov;
                objAntigo.Valor = objNovo.Valor;
                objAntigo.Idconta = objNovo.Idconta;
                ctx.SaveChanges();
                acaoCrudMovimento = "AT";
            }
            catch (Exception e)
            {
                acaoCrudMovimento = "NAT";

            }

        }
        public void Deletar(int id)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + id, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Movimento obj = ctx.Movimentos.Find(id);
                    ctx.Movimentos.Remove(obj);
                    ctx.SaveChanges();
                    acaoCrudMovimento = "DEL";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);

                }
            }
            else if (resultado == DialogResult.No)
            {
                acaoCrudMovimento = "NDEL";
            }

        }


        public Movimento Buscar(int id)
        {
            Movimento obj = new Movimento();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Movimentos.Find(id);
            }
            return obj;
        }


        public List<Movimento> Listar()
        {
            var Movimentos = (from obj in ctx.Movimentos select obj).OrderBy(x => x.Descricao).ToList();
            return Movimentos;

        }



        public List<Movimento> ListarPaginada(string listarPor, string ordernarPor, int limitt, int offset)
        {

            var ctx = new SistemaContext();
            List<Movimento> MovimentosListadas = new List<Movimento>();


            if (listarPor.Equals("id") && ordernarPor.Equals("asc"))
            {
                var Movimentos = (from obj in ctx.Movimentos select obj).OrderBy(x => x.Id).Skip(limitt).Take(offset).ToList();
                MovimentosListadas = Movimentos;
            }
            else if (listarPor.Equals("id") && ordernarPor.Equals("desc"))
            {
                var Movimentos = (from obj in ctx.Movimentos select obj).OrderByDescending(x => x.Id).Skip(limitt).Take(offset).ToList();
                MovimentosListadas = Movimentos;
            }
            else if (listarPor.Equals("nome") && ordernarPor.Equals("asc"))
            {

                var Movimentos = (from obj in ctx.Movimentos select obj).OrderBy(x => x.Descricao).Skip(limitt).Take(offset).ToList();
                MovimentosListadas = Movimentos;
            }
            else if (listarPor.Equals("nome") && ordernarPor.Equals("desc"))
            {
                var Movimentos = (from obj in ctx.Movimentos select obj).OrderByDescending(x => x.Descricao).Skip(limitt).Take(offset).ToList();
                MovimentosListadas = Movimentos;
            }

            return MovimentosListadas;

        }

        public int ListarTudo()
        {
            var Movimentos = (from obj in ctx.Movimentos select obj);
            return Movimentos.Count();

        }

      
    


        public int ListarPesquisados()
        {
            return listarQtPesquisa;
        }

        public string AcaoCrudMovimentoREP()
        {
            return acaoCrudMovimento;
        }


        public List<Movimento> PesquisarComeca(string coluna, object campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Movimento> MovimentosListadasPesquisarComeca = new List<Movimento>();
            string ajusteEF;
            if (String.IsNullOrEmpty(pesquisar) || pesquisar.Trim().Equals(""))
            {
                ajusteEF = "A*9@A28#&^ª^~º~";

            }
            else
            {
                ajusteEF = pesquisar;
            }
            try
            {

                if (pesquisar == "")
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.StartsWith(ajusteEF)).OrderBy(x => x.Descricao).ToList();
                    MovimentosListadasPesquisarComeca = Movimentos;

                }
                else
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.StartsWith(ajusteEF)).OrderBy(x => x.Descricao).ToList();
                    MovimentosListadasPesquisarComeca = Movimentos;
                }
                listarQtPesquisa = MovimentosListadasPesquisarComeca.Count;
                return MovimentosListadasPesquisarComeca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Movimento> PesquisarContem(string coluna, string campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Movimento> MovimentosListadasPesquisarContem = new List<Movimento>();
            try
            {

                if (pesquisar == "")
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.Contains(pesquisar)).OrderBy(x => x.Descricao).ToList();
                    MovimentosListadasPesquisarContem = Movimentos;
                }
                else
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.Contains(pesquisar)).OrderBy(x => x.Descricao).ToList();
                    MovimentosListadasPesquisarContem = Movimentos;
                }
                listarQtPesquisa = MovimentosListadasPesquisarContem.Count;
                return MovimentosListadasPesquisarContem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Movimento> PesquisarTermina(string coluna, string campo, string pesquisar)
        {
            var ctx = new SistemaContext();
            List<Movimento> listaPesquisarTermina = new List<Movimento>();

            try
            {


                if (pesquisar == "")
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.EndsWith(pesquisar)).OrderBy(x => x.Descricao).ToList();
                    listaPesquisarTermina = Movimentos;
                }
                else
                {
                    var Movimentos = (from obj in ctx.Movimentos select obj).Where(x => x.Descricao.EndsWith(pesquisar)).OrderBy(x => x.Descricao).ToList();
                    listaPesquisarTermina = Movimentos;
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