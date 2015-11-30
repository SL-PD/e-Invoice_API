using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EasyCart.Models.OrderImport;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace EasyCartAdmin.TestCode
{
    public partial class GetInvoice : System.Web.UI.Page
    {
        //帳號
        private const string _USERNO = "XXX";
        //密碼
        private const string _PWD = "XX";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnJson_Click(object sender, EventArgs e)
        {
            wsInvoiceService.InvoiceService ws = new wsInvoiceService.InvoiceService();
            //使用Json字串輸入
            
            wsInvoiceService.MySoapHeader header = new wsInvoiceService.MySoapHeader();
            header.USERNO = _USERNO;//帳號
            header.PWD = _PWD;//密碼
            ws.MySoapHeaderValue = header;
            string jsonText = ws.GetInvoiceJson(null, null, null);
            this.lblMsg.Text = jsonText;
            
        }
        
        protected void btnObject_Click(object sender, EventArgs e)
        {
            wsInvoiceService.InvoiceService ws = new wsInvoiceService.InvoiceService();
            //使用Json字串輸入

            wsInvoiceService.MySoapHeader header = new wsInvoiceService.MySoapHeader();
            header.USERNO = _USERNO;//帳號
            header.PWD = _PWD;//密碼
            ws.MySoapHeaderValue = header;

            this.gvList.DataSource = ws.GetInvoiceList(null, null, null);
            this.gvList.DataBind();
        }
        private List<EasyCartAdmin.wsInvoiceService.InvoiceInfo> jsonToObject(string jsonText) 
        {
            var obj = Activator.CreateInstance<List<EasyCartAdmin.wsInvoiceService.InvoiceInfo>>();
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonText)))
            {
                var serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType());
                try
                {
                    obj = (List<EasyCartAdmin.wsInvoiceService.InvoiceInfo>)serializer.ReadObject(memoryStream);
                }
                catch (Exception)
                {

                    throw;
                }
                return obj;
            } 
        }
    }
}