<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tradutor_AspX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="TRADUTOR"></asp:Label><br />
            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox> <br />
            <asp:Label ID="lblMostrar" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnTraduzir" runat="server" Text="Traduzir" OnClick="btnTraduzir_Click" />

        </div>
    </form>
</body>
</html>
