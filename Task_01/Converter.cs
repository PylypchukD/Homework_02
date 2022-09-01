namespace Task_01
{
    internal class Converter
    {
        readonly double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd <= 0 ? 1 : usd;
            this.eur = eur <= 0 ? 1 : eur;
            this.rub = rub <= 0 ? 1 : rub;
        }

        public double ConvertToUsd(double sum) => sum / usd;
        public double ConvertToEur(double sum) => sum / eur;
        public double ConvertToRub(double sum) => sum / rub;

        public double ConvertFromUsd(double sum) => sum * usd;
        public double ConvertFromEur(double sum) => sum * eur;
        public double ConvertFromRub(double sum) => sum * rub;

    }
}
