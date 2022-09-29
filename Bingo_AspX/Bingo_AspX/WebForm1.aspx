<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bingo_AspX.WebForm1" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="BINGO"></asp:Label><br /> &nbsp &nbsp &nbsp
            <asp:ListBox ID="listMostrar" runat="server"></asp:ListBox>
            <asp:Label ID="lblExibir" runat="server" Text="#"></asp:Label><br /> <br /> <br />
            <asp:Button ID="btnExibir" runat="server" Text="MOSTRAR" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
