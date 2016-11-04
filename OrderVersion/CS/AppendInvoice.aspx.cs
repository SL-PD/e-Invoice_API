using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EasyCart.Models.OrderImport;

namespace EasyCartAdmin.TestCode
{
    public partial class AppendInvoice : System.Web.UI.Page
    {
        //帳號
        private const string _USERNO = "XXX";
        //密碼
        private const string _PWD = "XXX";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 取得訂單資料
        /// </summary>
        /// <returns></returns>
        private List<wsInvoiceService.OrderImporterParm> GetData() 
        {
            List<wsInvoiceService.OrderImporterParm> oList = new List<wsInvoiceService.OrderImporterParm>();
            wsInvoiceService.OrderImporterParm item1 = new wsInvoiceService.OrderImporterParm();
            wsInvoiceService.OrderImporterParm item2 = new wsInvoiceService.OrderImporterParm();
            item1.OrderID = "B20150519002";//訂單號碼(必填)
            item1.OrderDate = Convert.ToDateTime("2015-05-14");//訂單日期(必填:請轉為日期時間格式，JSON格式為/Date(1349301600000+0200)/
            item1.InvoiceFor = "C";//發票類型(必填)
            item1.BuyerName = "";//買受人名稱
            item1.BuyerInvoiceTitle = "";//買受人發票抬頭
            item1.BuyerCompanyId = "";//買受人統編
            item1.BuyerEmail = "service@systemlead.com.tw";//客戶電子郵件(必填)
            item1.BuyerCellPhone = "";//客戶行動電話
            item1.Amount = 3000;//訂單總額(未稅)(必填)
            item1.TaxType = "1";//課稅類別
            item1.Tax = 150;//發票稅額(必填)
            item1.TotalAmount = 3150;//含稅總額(必填)
            item1.ProductID = "";//產品代號
            item1.ProductName = "BENZ-W204-4D/前檔/副/台/膠";//產品名稱(必填)
            item1.Quantity = 1;//購買數量(必填)
            item1.UnitPrice = 2625;//產品單價(必填)
            item1.Card4No = "";//信用卡號後四碼
            item1.BuyerCarrierId = "";//手機載具條碼
            item1.DornateId = "";//捐贈單位條碼
            item1.BuyerAddress = "";//客戶郵寄地址
            item1.PrintYesOrNo = false;//索取紙本
            //
            item2.OrderID = "B20150519002";//訂單號碼
            item2.OrderDate = Convert.ToDateTime("2015-05-14");//訂單日期
            item2.InvoiceFor = "C";//發票類型
            item2.BuyerName = "";//買受人名稱
            item2.BuyerInvoiceTitle = "";//買受人發票抬頭
            item2.BuyerCompanyId = "";//買受人統編
            item2.BuyerEmail = "service@systemlead.com.tw";//客戶電子郵件
            item2.BuyerCellPhone = "";//客戶行動電話
            item2.Amount = 3000;//訂單總額(未稅)
            item2.TaxType = "1";//課稅類別
            item2.Tax = 150;//發票稅額
            item2.TotalAmount = 3150;//含稅總額
            item2.ProductID = "";//產品代號
            item2.ProductName = "安裝費";//產品名稱
            item2.Quantity = 1;//購買數量
            item2.UnitPrice = 525;//產品單價
            item2.Card4No = "";//信用卡號後四碼
            item2.BuyerCarrierId = "";//手機載具條碼
            item2.DornateId = "";//捐贈單位條碼
            item2.BuyerAddress = "";//客戶郵寄地址
            item2.PrintYesOrNo = false;//索取紙本
            oList.Add(item1);
            oList.Add(item2);
            return oList;
        }

        protected void btnJson_Click(object sender, EventArgs e)
        {
            wsInvoiceService.InvoiceService ws = new wsInvoiceService.InvoiceService();
            //使用Json字串輸入
            string JsonString = "[{\"Amount\":3000,\"BuyerAddress\":null,\"BuyerCarrierId\":null,\"BuyerCellPhone\":null,\"BuyerCompanyId\":\"87654321\",\"BuyerEmail\":\"service@systemlead.com.tw\",\"BuyerInvoiceTitle\":\"我家保養廠\",\"BuyerName\":\"我家保養廠\",\"Card4No\":null,\"DetailWithTax\":\"Y\",\"DornateId\":null,\"InvoiceDate\":null,\"InvoiceFor\":\"C\",\"InvoiceID\":null,\"InvoiceUrl\":null,\"OrderDate\":\"\\/Date(1431532800000+0800)\\/\",\"OrderID\":\"J20150519001\",\"OrderSource\":null,\"PayKind\":null,\"PrintYesOrNo\":false,\"ProductID\":\"100102058\",\"ProductName\":\"BENZ-W204-4D\\/前檔\\/副\\/台\\/膠\",\"Quantity\":1,\"SiteID\":null,\"Tax\":150,\"TaxRate\":0.05,\"TaxType\":\"1\",\"TotalAmount\":3150,\"UnitPrice\":2625},{\"Amount\":3000,\"BuyerAddress\":null,\"BuyerCarrierId\":null,\"BuyerCellPhone\":null,\"BuyerCompanyId\":\"87654321\",\"BuyerEmail\":\"service@systemlead.com.tw\",\"BuyerInvoiceTitle\":\"我家保養廠\",\"BuyerName\":\"我家保養廠\",\"Card4No\":null,\"DetailWithTax\":\"Y\",\"DornateId\":null,\"InvoiceDate\":null,\"InvoiceFor\":\"C\",\"InvoiceID\":null,\"InvoiceUrl\":null,\"OrderDate\":\"\\/Date(1431532800000+0800)\\/\",\"OrderID\":\"J20150519001\",\"OrderSource\":null,\"PayKind\":null,\"PrintYesOrNo\":false,\"ProductID\":\"FEE001\",\"ProductName\":\"安裝費\",\"Quantity\":1,\"SiteID\":null,\"Tax\":150,\"TaxRate\":0.05,\"TaxType\":\"1\",\"TotalAmount\":3150,\"UnitPrice\":525}]";
          
            

            wsInvoiceService.MySoapHeader header = new wsInvoiceService.MySoapHeader();
            header.USERNO = _USERNO;//帳號
            header.PWD = _PWD;//密碼
            ws.MySoapHeaderValue = header;
            this.lblMsg.Text = ws.OrdersAppendFromJson(JsonString);
        }

        protected void btnObject_Click(object sender, EventArgs e)
        {
            wsInvoiceService.InvoiceService ws = new wsInvoiceService.InvoiceService();
           

            wsInvoiceService.MySoapHeader header = new wsInvoiceService.MySoapHeader();
            header.USERNO = _USERNO;//帳號
            header.PWD = _PWD;//密碼
            ws.MySoapHeaderValue = header;
            this.lblMsg.Text = ws.OrdersAppend(this.GetData().ToArray());
        }
    }
}
