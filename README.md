# e-Invoice_API
e首發票API <br />
測試區API連線網址：http://web.systemlead.com/EasyCartAdmin/api/invoiceService.asmx <br />
:exclamation::exclamation:**請先在測試區確認成功後再傳正式區**:exclamation::exclamation:<br />
:exclamation::exclamation:**請先在測試區確認成功後再傳正式區**:exclamation::exclamation:<br />
:exclamation::exclamation:**請先在測試區確認成功後再傳正式區**:exclamation::exclamation:<br />
正式區API連線網址：http://mis.youshop.com.tw/api/invoiceService.asmx <br />
可以選擇 <br />
方法1：透過WebService寫入訂單資料 [OrdersAppend] <br />
方法2：透過JOSN寫入訂單資料 [OrdersAppendFromJson] <br />

寫入發票可參考範例 .NET版本 [PHP版本](https://gist.github.com/SL-PD/1cc693c003cdc325c57aac2caac816f5) AppendInvoice.aspx <br />
讀取發票可參考範例 GetInvoice.aspx <br />

傳送欄位如下: <br />
**//訂單號碼(必填)<br />OrderID = "B20150519002";<br />**
**//訂單日期(必填:請轉為日期時間格式，JSON格式為/Date(1349301600000+0200)/<br />OrderDate = Convert.ToDateTime("2015-05-14");** <br />
**//發票類型(必填)<br />InvoiceFor = "C";** <br />
**開立給政府法人下面三個欄位必填但InvoiceFor請設定為C**<br />
//買受人名稱(若InvoiceFor=B則為必填) <br />BuyerName = "";<br />
//買受人發票抬頭(若InvoiceFor=B則為必填) <br />BuyerInvoiceTitle = "";<br />
//買受人統編(若InvoiceFor=B則為必填) <br />BuyerCompanyId = "";<br />
**//客戶電子郵件(必填;若要簡訊通知請填寫為[行動電話]@einv.com.tw:例如 0912345678@einv.com.tw)<br />BuyerEmail = "service@systemlead.com.tw";** <br />
//客戶行動電話 <br />BuyerCellPhone = "";<br />
**//訂單總額(未稅)(必填)<br />Amount = 3000;** <br />
//課稅類別(預設為應稅) <br />TaxType = "1";<br />
**//發票稅額(必填)<br />Tax = 150;** <br />
**//含稅總額(必填)<br />TotalAmount = 3150;** <br />
//產品代號 <br />ProductID = "";<br />
**//產品名稱(必填)<br />ProductName = "BENZ-W204-4D/前檔/副/台/膠";** <br />
**//購買數量(必填)<br />Quantity = 1;** <br />
**//產品單價(必填)<br />UnitPrice = 2625;** <br />
//信用卡號後四碼 <br />Card4No = "";<br />
//手機載具條碼 <br />BuyerCarrierId = "";<br />
//捐贈單位條碼 <br />DornateId = "";<br />
//客戶郵寄地址 <br />BuyerAddress = "";<br />
//索取紙本 <br />PrintYesOrNo = false;<br />
