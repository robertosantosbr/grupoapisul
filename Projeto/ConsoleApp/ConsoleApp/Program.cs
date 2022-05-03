

using ConsoleApp.Modelo;
using ConsoleApp.Servico;
using ConsoleApp.Utilidade;

const string DIRETORIO = @"C:\Users\rss11\Documents\grupoapisul\Projeto\ConsoleApp\";
const string ARQUIVO = @"ConsoleApp\input.json";

var fluxos = JsonExtensions.Convert(DIRETORIO, ARQUIVO);
var servico = new ElevadorServico(fluxos);

Console.WriteLine("Grupo APISUL");

var menosUtilizados = servico.andarMenosUtilizado();
Console.WriteLine(@" => Ordem de ANDARES MENOS utilizados.");
Console.WriteLine(@"Resposta: {0}", String.Join(" | ", menosUtilizados));

var maisFrequentados = servico.elevadorMaisFrequentado();
Console.WriteLine(@" => Ordem de ELEVADORES MAIS frequentados.");
Console.WriteLine(@"Resposta: {0}", String.Join(" | ", maisFrequentados));

var periodoMaiorFluxoElevador = servico.periodoMaiorFluxoElevadorMaisFrequentado();
Console.WriteLine(@" => PERIODO do maior fluxo de elevadores mais frequentados.");
Console.WriteLine(@"Resposta: {0}", String.Join(" | ", periodoMaiorFluxoElevador));

var menosFrequentados = servico.elevadorMenosFrequentado();
Console.WriteLine(@" => Ordem de ELEVADORES MENOS frequentados.");
Console.WriteLine(@"Resposta: {0}", String.Join(" | ", menosFrequentados));

var periodoMenorFluxoElevador = servico.periodoMenorFluxoElevadorMenosFrequentado();
Console.WriteLine(@" => PERIODO do menor fluxo de elevadores menos frequentados.");
Console.WriteLine(@"Resposta: {0}", String.Join(" | ", periodoMenorFluxoElevador));

Console.WriteLine(@" => PERCENTUAL de uso do(s) elevador(es).");
var percentualElevador = servico.percentualDeUsoElevadorA();
Console.WriteLine(@"Resposta: Percentual de uso do elevador A {0} %", percentualElevador.ToString("F"));
percentualElevador = servico.percentualDeUsoElevadorB();
Console.WriteLine(@"Resposta: Percentual de uso do elevador B {0} %", percentualElevador.ToString("F"));
percentualElevador = servico.percentualDeUsoElevadorC();
Console.WriteLine(@"Resposta: Percentual de uso do elevador C {0} %", percentualElevador.ToString("F"));
percentualElevador = servico.percentualDeUsoElevadorD();
Console.WriteLine(@"Resposta: Percentual de uso do elevador D {0} %", percentualElevador.ToString("F"));
percentualElevador = servico.percentualDeUsoElevadorE();
Console.WriteLine(@"Resposta: Percentual de uso do elevador E {0} %", percentualElevador.ToString("F"));