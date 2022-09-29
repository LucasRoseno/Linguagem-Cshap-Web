<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Quiz_AspX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        <center>  <h1> <asp:Label ID="Label1" runat="server" Text="BEM VINDO AO QUIZ DO LUKINHAS"></asp:Label>
         </h1></center> 
            <br /><br />
                                    <center>
            <asp:Label ID="Label2" runat="server" Text="Teremos C# DeskTop?"></asp:Label>
            <br /> <br />
            <asp:RadioButton ID="rdoOpc1" GroupName="opc" runat="server" Text="Pode ser"/> <br />
            <asp:RadioButton ID="rdoOpc2" GroupName="opc" runat="server" Text="Talvez" /> <br />
            <asp:RadioButton ID="rdoOpc3" GroupName="opc" runat="server" Text="Não sei"/> <br />
            <asp:RadioButton ID="rdoOpc4" GroupName="opc" runat="server" Text="SIM"/> <br />
            <asp:Button ID="btnProximi" runat="server" Text="Próximo" OnClick="btnProximi_Click" /><br />
                                    </center>
            
        </div>
    </form>
</body>
</html>
