namespace OdemeUygulamasi.Reflection
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar:C} ödendi.";
        }
    }
}
