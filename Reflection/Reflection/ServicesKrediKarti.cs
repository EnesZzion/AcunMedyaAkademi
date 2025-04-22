namespace OdemeUygulamasi.Reflection
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi Kartı ile {tutar:C} ödendi.";
        }
    }
}
