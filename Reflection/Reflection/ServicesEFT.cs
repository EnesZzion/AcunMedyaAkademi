namespace OdemeUygulamasi.Reflection
{
    public class EFT : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"EFT ile {tutar:C} ödendi.";
        }
    }
}