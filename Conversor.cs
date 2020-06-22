namespace Aula_22___Static
{
    public static class Conversor
    {
       public static float CotacaoDolar = 5.29f;
       public static float CotacaoEuro = 5.90f;

        public static float RealParaDolar(float valor){
        return valor / CotacaoDolar;
        }

        public static float DolarParaReal(float valor){
        return valor * CotacaoDolar;
        }

        public static float RealParaEuro(float valor){
        return valor / CotacaoDolar;
        }

        public static float EuroParaReal(float valor){
        return valor * CotacaoEuro;
        }
    } 
}