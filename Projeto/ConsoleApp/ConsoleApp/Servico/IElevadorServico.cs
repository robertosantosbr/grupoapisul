using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Servico
{
    public interface IElevadorServico
    {
        List<int> andarMenosUtilizado();

        List<char> elevadorMaisFrequentado();

        List<char> periodoMaiorFluxoElevadorMaisFrequentado();

        List<char> elevadorMenosFrequentado();

        List<char> periodoMenorFluxoElevadorMenosFrequentado();

        List<char> periodoMaiorUtilizacaoConjuntoElevadores();

        float percentualDeUsoElevadorA();

        float percentualDeUsoElevadorB();

        float percentualDeUsoElevadorC();

        float percentualDeUsoElevadorD();

        float percentualDeUsoElevadorE();
    }
}
