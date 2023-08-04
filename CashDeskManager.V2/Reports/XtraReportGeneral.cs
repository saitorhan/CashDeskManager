using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using DevExpress.XtraReports.UI;

namespace CashDeskManager.V2.Reports
{
    public partial class XtraReportGeneral : DevExpress.XtraReports.UI.XtraReport
    {
        private List<CashDeskAction> deskActions;
        private List<CustumerDibtCollect> custumerDibtCollects;
        private List<DebtPay> debtPays;
        private List<FixedExpensePay> fixedExpensePays;
        private List<MoneyOut> moneyOuts;
        private List<CashDeskAction> otherCashDeskActions;
        private List<int> ids;
        public XtraReportGeneral()
        {
            InitializeComponent();
            ids = new List<int>();
            deskActions = CashDeskContext.DeskContext.CashDeskActions
                .Where(c => c.CashDeskId == GlobalVariables.CurrentCashDesk.Id).ToList();

            debtPays = deskActions.Where(c => (c is DebtPay)).Cast<DebtPay>().ToList();
            ids.AddRange(debtPays.Select(d => d.Id));

            fixedExpensePays = deskActions.Where(c => (c is FixedExpensePay)).Cast<FixedExpensePay>().ToList();
            ids.AddRange(fixedExpensePays.Select(d => d.Id));

            moneyOuts = deskActions.Where(c => (c is MoneyOut)).Cast<MoneyOut>().ToList();
            ids.AddRange(moneyOuts.Select(d => d.Id));

            custumerDibtCollects = deskActions.Where(c => (c is CustumerDibtCollect)).Cast<CustumerDibtCollect>().ToList();
            ids.AddRange(custumerDibtCollects.Select(d => d.Id));

            otherCashDeskActions = deskActions.Where(d => !ids.Contains(d.Id)).ToList();
        }

    }
}
