using System;
using System.Data.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Migrations;

namespace CashDeskManager.V2.Entity
{
    public class CashDeskContext : DbContext
    {
        private static CashDeskContext cashDeskContext;

        public static CashDeskContext DeskContext => cashDeskContext ?? (cashDeskContext = new CashDeskContext());
        public CashDeskContext()
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<CashDeskContext, Configuration>());
        }
        
        public DbSet<Custumer> Custumers { get; set; }
        public DbSet<CashDesk> CashDesks { get; set; }
        public DbSet<CustumerDebt> CustumerDebts { get; set; }
        public DbSet<FixedExpense> FixedExpenses { get; set; }
        public DbSet<DebtAndCredit> DebtAndCredits { get; set; }
        public DbSet<CashDeskAction> CashDeskActions { get; set; }
        public DbSet<MoneyOut> MoneyOuts { get; set; }
        public DbSet<CustumerDibtCollect> CustumerDibtCollects { get; set; }
        public DbSet<FixedExpensePay> FixedExpensePays { get; set; }
        public DbSet<DebtPay> DebtPays { get; set; }

        public Tuple<bool, string> SaveChanges()
        {
            try
            {
                base.SaveChanges();
                return new Tuple<bool, string>(true, String.Empty);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"{ex.Message}{(ex.InnerException != null ? ($"\n{ex.InnerException.Message}") : String.Empty)}");
            }
        }
    }
}