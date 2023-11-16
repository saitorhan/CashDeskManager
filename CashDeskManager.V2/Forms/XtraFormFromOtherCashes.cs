using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.AppModel;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Extensions;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormFromOtherCashes : DevExpress.XtraEditors.XtraForm
    {
        private List<ActionFromOtherCashes> actionFromOtherCasheses;
        public XtraFormFromOtherCashes()
        {
            InitializeComponent();
            GetDatas();
            actionFromOtherCashesBindingSource.DataSource = actionFromOtherCasheses;

            gridView1.BestFitColumns();
        }

        private void GetDatas()
        {
            actionFromOtherCasheses =
                CashDeskContext.DeskContext.Database.SqlQuery<ActionFromOtherCashes>("select ca .Id, ca.CashDeskId, ca1.Name SourceCash, ca.CurrencyUnit, ca.Amount, ca.DateTime, ca.Description, ca.BankName, ca.BankBranch, ca.SignDateTime, ca.ExpirtyDateTime, ca.AccountNumber, ca.CheckNumber, ca.CheckOwner, ca.PaymentStatu, ca.PaymentMethod, ca.ActionDirection, ca.Deleted, ca.DeleteTime, ca.CustumerId, cu.Name CustumerName, ca.Discriminator, ca.MoneyOutCashDeskId, cmo.Name MoneyOutFrom, ca.DebtPayCashDeskId, cdp.Name DeptPayFrom, ca.DebtId, dc.TargetName DebtName, ca.FixedExpensePayCeshDeskId, cfe.Name FixedFrom, ca.FixedExpenseId, fe.Description FixedExpense, ca.CustumerDibtId, ca.GetCollectCashDeskActionId, ccd.Name MoneyToDesk, (case when ca.MoneyOutCashDeskId is not null then 'Para Çıkışı' when ca.DebtPayCashDeskId is not null then 'Borç Ödeme' when ca.FixedExpensePayCeshDeskId is not null then 'Sabit Gider Ödeme' when ca.GetCollectCashDeskActionId is not null then 'Ödeme Alma' else '' end ) as ActionDesc  from cashdeskactions ca    left join cashdesks ca1 on ca1.Id = ca.CashDeskId  left join custumers cu on cu.Id = ca.CustumerId  left join cashdesks cmo on ca.MoneyOutCashDeskId = cmo.Id  left join cashdesks cdp on ca.DebtPayCashDeskId = cdp.Id  left join debtandcredits dc on ca.DebtId = dc.Id  left join cashdesks cfe on ca.FixedExpensePayCeshDeskId = cfe.Id  left join fixedexpenses fe on fe.Id = ca.FixedExpenseId  left join cashdesks ccd on ccd.Id = ca.GetCollectCashDeskActionId  where ca.Deleted is null and (ca.MoneyOutCashDeskId = {0} or ca.DebtPayCashDeskId = {0} or ca.FixedExpensePayCeshDeskId = {0} or ca .GetCollectCashDeskActionId = {0})", GlobalVariables.CurrentCashDesk.Id).ToListAsync().Result;
        }
    }
}