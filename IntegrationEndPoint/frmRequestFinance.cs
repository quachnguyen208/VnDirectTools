using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationEndPoint
{
    public partial class frmRequestFinance : Form
    {
        public frmRequestFinance()
        {
            InitializeComponent();
            Init();
        }

        public void FinanceInfor(string URL,string symbol,string postdata)
        {
            try
            {
                Object.FinanceInfor_Response response = new Object.FinanceInfor_Response();                    
                    string url = URL;
                    string result = string.Empty;
                    result = Business.FinanceInfor.API.PostUrlVietStock(url, postdata);
                if (ckhWrite.Checked == true)
                {
                    DataAccess.FinanceInforResult.Create(txtSymbol.Text.ToUpper(), result);
                    lbStatus.Text = "Insert Success! Check Your Data";
                }
                else
                {
                    txtResult.Text = result;
                    lbStatus.Text = "Insert To Log File!";
                }
                
                FileLog.WriteFileLog(result);

            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-FinanceInfor]" + ex.Message.ToString());
            }
        }
        public void FinanceInforGrid(string symbol)
        {
            try
            {                             
                dataGridView1.DataSource = DataAccess.FinanceInforResultGrid.Get(symbol);
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-FinanceInforGrid]" + ex.Message.ToString());
            }
        }
        private void Init()
        {
            txtURL.Text = "https://finance.vietstock.vn/data/financeinfo";
            txtSymbol.Text = "";
            txtYear.Text = "1";
            txtToken.Text = "aSECC8KYhwscu4wZ301Y2drwR60CgpszHYiEERRUvpyopDRNhqbV5kYL1v1GhTN1D4eAOD3DiMIyfaStY1OUFjT-D2wloeyzwDJjMwVQ6iXtmO4Yt9qgOd8c4kLPNZ52raoSqYF3H9VLu_ycvtseOg2";
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtURL.Text) || string.IsNullOrEmpty(txtSymbol.Text) || txtSymbol.TextLength > 3 || txtSymbol.TextLength < 3 || string.IsNullOrEmpty(txtSymbol.Text) || string.IsNullOrEmpty(txtSymbol.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtToken.Text))
            {
                lbStatus.Text = "Please check your request!";
            }
            else
            {
                FinanceInfor(txtURL.Text,txtSymbol.Text.ToUpper(), string.Format("Code={0}&ReportType={1}&ReportTermType=2&Unit=1000000&Page={2}&PageSize=4&__RequestVerificationToken={3}", txtSymbol.Text, "BCTQ", txtYear.Text,txtToken.Text));
                
            }

            //FinanceInfor(txtSymbol.Text, string.Format("Code={0}&ReportType={1}&ReportTermType=2&Unit=1000000&Page=1&PageSize=4&__RequestVerificationToken=aSECC8KYhwscu4wZ301Y2drwR60CgpszHYiEERRUvpyopDRNhqbV5kYL1v1GhTN1D4eAOD3DiMIyfaStY1OUFjT-D2wloeyzwDJjMwVQ6iXtmO4Yt9qgOd8c4kLPNZ52raoSqYF3H9VLu_ycvtseOg2", txtURL.Text, "BCTC"));

        }

        private void bntGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSymbolGrid.Text))
            {
                lbStatus.Text = "Please Check Your Input!";

            }
            else
            {
                FinanceInforGrid(txtSymbolGrid.Text.ToUpper());
            }
        }
    }
}
