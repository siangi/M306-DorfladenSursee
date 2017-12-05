<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Storefront" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="StylesMain.css" />
    <title>Dorfladen Sursee</title>
</head>
<body>
    <form id="frmStorefront" runat="server">
        <div id="title">
            <h1>Dorfladen BBZW</h1>
            <!-- Warenkorb hinzufügen -->
        </div>
        <div id="products">
            <asp:BulletedList ID="productList" runat="server"></asp:BulletedList>
        </div>
    </form>
</body>
</html>
