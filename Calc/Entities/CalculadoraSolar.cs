using System.Globalization;

namespace Calc.Entities;

internal class CalculadoraSolar
{
    public double Consumo;
    public double Potencia;

    public double PercaSistema = 0.84;
    public double IrradiacaoTo = 4.9;
    public double PotenciaModulo = 575;
    public int Dias = 30;

    public double CalculaPotencia()
    {
        return Consumo * 1000 / Dias / IrradiacaoTo / PercaSistema /1000;
    }

    public override string ToString()
    {
        return $"A potencia do sistema é : " + CalculaPotencia().ToString("F2",CultureInfo.InvariantCulture) +$"kWp";
    }
}
