<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcData.aspx.cs" Inherits="CalcDiasData.CalcData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dia que você nasceu"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar><br />
            <asp:TextBox ID="txtCalen1" runat="server"></asp:TextBox> <br />

            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br /><br /><br />
            <asp:Label ID="lblMostrar" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:button runat="server" text="MOSTRAR dias vividos" OnClick="Unnamed1_Click" />
            <br /><br /><br />


            <asp:Label ID="lblAnos" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Mostrar quantos anos vc tem" OnClick="Button1_Click" />




        </div>
    </form>
</body>
</html>

