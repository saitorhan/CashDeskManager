using System;

namespace CashDeskManager.V2.Entity.Enums
{
    public enum FixedExpensePeriod
    {
        Daily,
        Weekly,
        Monthly,
        Yearly,
        CustomDays
    }

    public static class EnumStrings
    {
        public static string ToStringF(this FixedExpensePeriod fixedExpensePeriod)
        {
            switch (fixedExpensePeriod)
            {
                case FixedExpensePeriod.Daily:
                    return "Günlük";
                    break;
                case FixedExpensePeriod.Weekly:
                    return "Haftalık";
                    break;
                case FixedExpensePeriod.Monthly:
                    return "Aylık";
                    break;
                case FixedExpensePeriod.Yearly:
                    return "Yıllık";
                    break;
                case FixedExpensePeriod.CustomDays:
                    return "Seçimli Günlük";
                    break;
                default:
                    return String.Empty;
            }
        }

        public static string ToStringF(this ActionDirection actionDirection)
        {
            switch (actionDirection)
            {
                case ActionDirection.In:
                    return "Kasa Giriş";
                    break;
                case ActionDirection.Out:
                    return "Kasa Çıkış";
                    break;
                default:
                    return actionDirection.ToString();
            }
        }

        public static string ToStringF(this PaymentMethod actionDirection)
        {
            switch (actionDirection)
            {
                case PaymentMethod.Cash:
                    return "Nakit";
                    break;
                case PaymentMethod.CreditCard:
                    return "Kredi Kartı";
                    break;
                case PaymentMethod.Check:
                    return "Çek";
                    break;
                default:
                    return actionDirection.ToString();
            }
        }

        public static string ToStringF(this PaymentStatu actionDirection)
        {
            switch (actionDirection)
            {
                case PaymentStatu.Approve:
                    return "Onaylandı";
                    break;
                case PaymentStatu.PendingApprove:
                    return "Onay Bekliyor";
                    break;
                case PaymentStatu.Reject:
                    return "Reddedildi";
                    break;
                default:
                    return actionDirection.ToString();
            }
        }
    }
}