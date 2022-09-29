
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="PrjCalculadora.Pagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="dig0" runat="server" Text="Calculadora"></asp:Label><br /><br />

        <asp:Label ID="dig1" runat="server" Text="Digite o 1° Valor"></asp:Label><br />
        <asp:TextBox ID="txtVal1" runat="server"></asp:TextBox><br /><br />

        <asp:Label ID="dig2" runat="server" Text="Digite o 2° Valor"></asp:Label><br />
        <asp:TextBox ID="txtVal2" runat="server"></asp:TextBox><br /><br />

        <asp:Label ID="dig3" runat="server" Text="Total"></asp:Label>&nbsp
        <asp:Label ID="lblTotal" runat="server" Text="#"></asp:Label><br />

        <asp:Button ID="btnSoma" runat="server" Text="Soma" Height="28px" Width="54px" OnClick="btnSoma_Click" />&nbsp

        <asp:Button ID="btnSub" runat="server" Text="Subtracao" Height="28px" Width="65px" OnClick="btnSub_Click" /><br />

        <br />

        <asp:Button ID="btnMult" runat="server" Text="Multiplicacao" Height="28px" Width="79px" OnClick="btnMult_Click" />&nbsp

        <asp:Button ID="btnDiv" runat="server" Text="Divisao" Height="28px" Width="65px" OnClick="btnDiv_Click" />
        <br />
        <br />
        <br />

        <asp:Label ID="dig4" runat="server" Text="Insira um valor para Seno abaixo:"></asp:Label><br />
        <asp:TextBox ID="txtSeno" runat="server"></asp:TextBox><br /> <br />
        <asp:Button ID="btnSeno" runat="server" Text="Seno" OnClick="btnSeno_Click" /> &nbsp
        <asp:Label ID="totSeno" runat="server" Text="#"></asp:Label>
        <br />

    </div>
    </form>
</body>
</html>
