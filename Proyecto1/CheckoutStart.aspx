<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutStart.aspx.cs" Inherits="Proyecto1.CheckoutStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="https://sandbox.gateway.payulatam.com/ppp-web-gateway/">
        <div>
            <input name="merchantId" type="hidden" value="633287"/>
            <input name="accountId" type="hidden" value="635651"/>
            <input name="description" type="hidden" value=""/>
            <input name="referenceCode" type="hidden" value="<%#:Session["IdCarro"]%>"/>
            <input name="amount" type="hidden" value="<%#:Session["Total"] %>"/>
            <input name="tax" type="hidden" value="0"/>
            <input name="taxReturnBase" type="hidden" value="0"/>
            <input name="currency" type="hidden" value="COP"/>
            <input name="signature" type="hidden" value="<%#:checkoutstart_aspx.GetSHA1()%>"/>
            <input name="test" type="hidden" value="1"/>
            <input name="buyerFullName" type="hidden" value="<%#:Session["NombreP"] %>" />
            <input name="buyerEmail" type="hidden" value="<%#:Session["email"] %>"/>
            <input name="responseUrl" type="hidden" value="http://www.test.com/response"/>
            <input name="confirmationUrl" type="hidden" value="http://www.test.com/confirmation"/>
            <input name="telephone" type="hidden" value="<%#:Session["Total"] %>" />
            <input name="Submit" type="submit" value="Enviar"/>
        </div>
    </form>
</body>
</html>
