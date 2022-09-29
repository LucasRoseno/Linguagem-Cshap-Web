<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrjAnosFuturo.aspx.cs" Inherits="PrjAnosFuturo.PrjAnosFuturo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /> <br /><br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar><br />
            <asp:TextBox ID="txtCalen1" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar><br />
            <asp:TextBox ID="txtCalen2" runat="server"></asp:TextBox>

            <br /><br /><br /><br />

            <asp:Button ID="btnCalc" runat="server" Text="Calcular Anos e dias" Height="38px" Width="154px" OnClick="btnCalc_Click" /><br />
            <asp:Label ID="lblMostrar" runat="server" Text="####"></asp:Label>
        </div>
        
    </form>
</body>
</html>
