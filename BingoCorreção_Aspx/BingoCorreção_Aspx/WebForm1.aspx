<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BingoCorreção_Aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             &nbsp  <asp:Button ID="btnMostrar" runat="server" Text="MOSTRAR" Height="45px" Width="112px" OnClick="btnMostrar_Click" /> <br /> <br />
            <asp:ListBox ID="ListMostrar" runat="server" Height="139px" Width="198px"></asp:ListBox>&nbsp &nbsp <br /> <br />
         
            <asp:Button ID="btnUni" runat="server" Text="Sorteadar unidade" OnClick="btnUni_Click" /> <br /> <br />
         
            <asp:Label ID="lblUni" runat="server" Text="*" Height="100px" Width="100px"></asp:Label> <br /> <br />
             <br /> <br />
         <asp:Label ID="lblSeq" runat="server" Text="" Height="30px" Width="800px"></asp:Label>


        </div>
    </form>
</body>
</html>
