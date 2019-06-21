<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SGUIApplication.WebForm1" %>

<%@ Register assembly="SGWebControls" namespace="SGWebControls" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <cc1:CrTextBox ID="CrTextBox1" runat="server" Model="Order" Property="Code"></cc1:CrTextBox>
        <br />
        <cc1:CrTextBox ID="CrTextBox2" runat="server" Model="Order" Property="Price"></cc1:CrTextBox>
        <br />
        <cc1:CrButton ID="CrButton1" runat="server" Action="Save" Controller="OrderBusiness.OrderOps" AssemblyName="OrderBusiness" />
    </form>
</body>
</html>
