<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questao8.aspx.cs" Inherits="Quiz_AspX.Questao8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>  <h1> <asp:Label ID="Label1" runat="server" Text="Programação"></asp:Label>
         </h1></center> 
            <br /><br />
                            <center>
            <asp:Label ID="Label2" runat="server" Text=" Na cabeça do Lucas qual é o mais leve?"></asp:Label>
            <br /> <br />
            <asp:RadioButton ID="rdoOpc1" GroupName="opc" runat="server" Text="Visual Studio"/> <br />
            <asp:RadioButton ID="rdoOpc2" GroupName="opc" runat="server" Text="Visual Code" /> <br />
            <asp:RadioButton ID="rdoOpc3" GroupName="opc" runat="server" Text="NotePad++"/> <br />
            <asp:RadioButton ID="rdoOpc4" GroupName="opc" runat="server" Text="Nenhum das anteriores"/> <br />
            <asp:Button ID="btnProximo" runat="server" Text="Próximo" OnClick="btnProximi_Click" />
                            </center>
        </div>
    </form>
</body>
</html>
