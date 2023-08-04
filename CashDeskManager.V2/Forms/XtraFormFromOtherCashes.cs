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
                CashDeskContext.DeskContext.Database.SqlQuery<ActionFromOtherCashes>("select ca .Id,\r\n       ca.CashDeskId,\r\n       ca1.Name SourceCash,\r\n       ca.CurrencyUnit,\r\n       ca.Amount,\r\n       ca.DateTime,\r\n       ca.Description,\r\n       ca.BankName,\r\n       ca.BankBranch,\r\n       ca.SignDateTime,\r\n       ca.ExpirtyDateTime,\r\n       ca.AccountNumber,\r\n       ca.CheckNumber,\r\n       ca.CheckOwner,\r\n       ca.PaymentStatu,\r\n       ca.PaymentMethod,\r\n       ca.ActionDirection,\r\n       ca.Deleted,\r\n       ca.DeleteTime,\r\n       ca.CustumerId,\r\n       cu.Name CustumerName,\r\n       ca.Discriminator,\r\n       ca.MoneyOutCashDeskId,\r\n       cmo.Name MoneyOutFrom,\r\n       ca.DebtPayCashDeskId,\r\n       cdp.Name DeptPayFrom,\r\n       ca.DebtId,\r\n       dc.TargetName DebtName,\r\n       ca.FixedExpensePayCeshDeskId,\r\n       cfe.Name FixedFrom,\r\n       ca.FixedExpenseId,\r\n       fe.Description FixedExpense,\r\n       ca.CustumerDibtId,\r\n       ca.GetCollectCashDeskActionId,\r\n       ccd.Name MoneyToDesk,\r\n       (case\r\n           when ca.MoneyOutCashDeskId is not null then 'Para Çıkışı'\r\n           when ca.DebtPayCashDeskId is not null then 'Borç Ödeme'\r\n           when  ca.FixedExpensePayCeshDeskId is not null then 'Sabit Gider Ödeme'\r\n           when ca.GetCollectCashDeskActionId is not null then 'Ödeme Alma'\r\n           else ''\r\n           end\r\n           ) as ActionDesc\r\nfrom cashdeskactions ca\r\n  left join cashdesks ca1 on ca1.Id = ca.CashDeskId\r\nleft join custumers cu on cu.Id = ca.CustumerId\r\nleft join cashdesks cmo on ca.MoneyOutCashDeskId = cmo.Id\r\nleft join cashdesks cdp on ca.DebtPayCashDeskId = cdp.Id\r\nleft join debtandcredits dc on ca.DebtId = dc.Id\r\nleft join cashdesks cfe on ca.FixedExpensePayCeshDeskId = cfe.Id\r\nleft join fixedexpenses fe on fe.Id = ca.FixedExpenseId\r\nleft join cashdesks ccd on ccd.Id = ca.GetCollectCashDeskActionId\r\nwhere ca.Deleted is null and (ca.MoneyOutCashDeskId = {0} or ca.DebtPayCashDeskId = {0} or ca.FixedExpensePayCeshDeskId =\r\n                                                                                       {0} or ca\r\n                                                                                         .GetCollectCashDeskActionId\r\n                                                                                              = {0})", GlobalVariables.CurrentCashDesk.Id).ToListAsync().Result;
        }
    }
}