using ConsoleApp.Modelo;
using ConsoleApp.Utilidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Servico
{
    public class ElevadorServico : IElevadorServico
    {
        private List<Fluxo> Fluxos;
        private ConvertListChar Util = new ConvertListChar();

        /// <summary>
        ///     
        /// </summary>
        /// <param name="fluxos"></param>
        public ElevadorServico(List<Fluxo> fluxos)
        {
            Fluxos = fluxos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> andarMenosUtilizado() => 
            Fluxos.GroupBy(a => a.Andar)
                .Select(n => new { Andar = n.Key, Qtd = n.Count() })
                .OrderByDescending(a => a.Qtd)
                    .Select(s => s.Andar)
                    .ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<char> elevadorMaisFrequentado()
        {
            var retorno = Fluxos.GroupBy(a => a.Elevador)
                .Select(n => new { Elevador = n.Key, Frenquencia = n.Count() })
                .OrderBy(a => a.Frenquencia)
                    .Select(s => s.Elevador)
                    .ToList();
            return Util.Convert(retorno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            var retorno = Fluxos.GroupBy(a => new { a.Elevador, a.Turno })
                .Select(g => 
                    new { Elevador = g.Key.Elevador, Turno = g.Key.Turno, Frenquencia = g.Count() })
                .OrderByDescending(a => a.Frenquencia)
                    .Select(s => s.Turno)
                    .Take(1)
                    .ToList();
            return Util.Convert(retorno);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public List<char> elevadorMenosFrequentado()
        {
            var retorno = Fluxos.GroupBy(a => a.Elevador)
                .Select(n => new { Elevador = n.Key, Frenquencia = n.Count() })
                .OrderByDescending(a => a.Frenquencia)
                    .Select(s => s.Elevador)
                    .ToList();
            return Util.Convert(retorno);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            var retorno = Fluxos.GroupBy(a => new { a.Elevador, a.Turno })
                .Select(g =>
                    new { Elevador = g.Key.Elevador, Turno = g.Key.Turno, Frenquencia = g.Count() })
                .OrderBy(a => a.Elevador)
                .OrderBy(a => a.Frenquencia)
                    .Select(s => s.Turno)
                    .Take(1)
                    .ToList();
            return Util.Convert(retorno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevadorA() =>
            percentualDeUsoElevador("A");

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevadorB() =>
            percentualDeUsoElevador("B");


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevadorC() =>
            percentualDeUsoElevador("C");

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevadorD() =>
            percentualDeUsoElevador("D");

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevadorE() =>
            percentualDeUsoElevador("E");

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float percentualDeUsoElevador(string elevador)
        {
            var elevadorA = Fluxos.Where(a => a.Elevador.Equals(elevador))
                .GroupBy(a => a.Elevador)
                .SelectMany(grp => grp.Select(row => new
                {
                    Elevador = row.Elevador,
                    Frenquencia = row.Elevador.Count(),
                    Percentual = Convert.ToSingle(100.0 * row.Elevador.Count() / grp.Sum(dd => dd.Elevador.Count()))
                })
                .Take(1)
                .Select(a => a.Percentual)
            ).ToList();

            return elevadorA[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            try
            {
                return new List<char>();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
