
namespace Softplan_CalculaJuros.Services.JurosService.cs
{
    public interface IJurosService
    {
        double CalculaJuros(double valorInicial, int tempo);
        string GetUrl();
    }
}
