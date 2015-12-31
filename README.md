# e-Invoice_API
e首發票API <br />
API連線網址：http://mis.youshop.com.tw/api/invoiceService.asmx <br />
可以選擇 <br />
方法1：透過WebService寫入訂單資料 [OrdersAppend] <br />
方法2：透過JOSN寫入訂單資料 [OrdersAppendFromJson] <br />

寫入發票可參考範例 AppendInvoice.aspx <br />
讀取發票可參考範例 GetInvoice.aspx <br />

傳送欄位如下:
*OrderID = "B20150519002";//訂單號碼(必填)* <br />
*OrderDate = Convert.ToDateTime("2015-05-14");//訂單日期(必填:請轉為日期時間格式，JSON格式為/Date(1349301600000+0200)/* <br />
*InvoiceFor = "C";//發票類型(必填)* <br />
BuyerName = "";//買受人名稱 <br />
BuyerInvoiceTitle = "";//買受人發票抬頭 <br />
BuyerCompanyId = "";//買受人統編 <br />
*BuyerEmail = "service@systemlead.com.tw";//客戶電子郵件(必填)* <br />
BuyerCellPhone = "";//客戶行動電話 <br />
*Amount = 3000;//訂單總額(未稅)(必填)* <br />
TaxType = "1";//課稅類別 <br />
*Tax = 150;//發票稅額(必填)* <br />
*TotalAmount = 3150;//含稅總額(必填)* <br />
ProductID = "";//產品代號 <br />
*ProductName = "BENZ-W204-4D/前檔/副/台/膠";//產品名稱(必填)* <br />
*Quantity = 1;//購買數量(必填)* <br />
*UnitPrice = 2625;//產品單價(必填)* <br />
Card4No = "";//信用卡號後四碼 <br />
BuyerCarrierId = "";//手機載具條碼 <br />
DornateId = "";//捐贈單位條碼 <br />
BuyerAddress = "";//客戶郵寄地址 <br />
PrintYesOrNo = false;//索取紙本 <br />
