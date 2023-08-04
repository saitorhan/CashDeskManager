using System;
using System.Globalization;

namespace CashDeskManager.V2.Entity.Enums
{
    public enum CurrencyUnit
    {
        TRY,
        USD,
        EUR
    }

    public static class CurrencyUnitExtension
    {
        public static CultureInfo GetCultureInfo(this CurrencyUnit currencyUnit)
        {
            CultureInfo cultureInfo;
            switch (currencyUnit)
            {
                case CurrencyUnit.TRY:
                    cultureInfo = new CultureInfo("tr-TR");
                    break;
                case CurrencyUnit.USD:
                    cultureInfo = new CultureInfo("en-US");
                    break;
                case CurrencyUnit.EUR:
                    cultureInfo = new CultureInfo("fr-FR");
                    break;
                default:
                    cultureInfo = new CultureInfo("tr-TR");
                    break;
            }

            return cultureInfo;
        }
    }
}