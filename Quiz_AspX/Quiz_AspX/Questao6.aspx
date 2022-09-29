<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questao6.aspx.cs" Inherits="Quiz_AspX.Questao6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>  <h1> <asp:Label ID="Label1" runat="server" Text="Cotidiano"></asp:Label>
         </h1></center> 
            <br /><br />
                                            <center>
            <asp:Label ID="Label2" runat="server" Text="Quando está sol, falamos que está:"></asp:Label>
            <br /> <br />
            <asp:RadioButton ID="rdoOpc1" GroupName="opc" runat="server" Text="Ensolarado"/> <br />
            <asp:RadioButton ID="rdoOpc2" GroupName="opc" runat="server" Text="Ensolado" /> <br />
            <asp:RadioButton ID="rdoOpc3" GroupName="opc" runat="server" Text="Solado"/> <br />
            <asp:RadioButton ID="rdoOpc4" GroupName="opc" runat="server" Text="Solado malukooo"/> <br />
            <asp:Button ID="btnProximo" runat="server" Text="Próximo" OnClick="btnProximi_Click" />
                                           </center>
        </div>
    </form>
</body>
</html>
