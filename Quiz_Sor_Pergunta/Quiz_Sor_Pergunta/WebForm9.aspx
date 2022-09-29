<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="Quiz_Sor_Pergunta.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>  <h1> <asp:Label ID="Label1" runat="server" Text="BEM VINDO AO QUIZ DO LUKINHAS"></asp:Label> </center>
         </h1>
            <br /><br />
                                    
            <asp:Label ID="lblMostrar" runat="server" Text=""></asp:Label>
            <br /> <br />
            <asp:RadioButton ID="rdoOpc1" GroupName="opc" runat="server" Text=""/> <br />
            <asp:RadioButton ID="rdoOpc2" GroupName="opc" runat="server" Text="" /> <br />
            <asp:RadioButton ID="rdoOpc3" GroupName="opc" runat="server" Text=""/> <br />
        
            <br />
            <asp:Button ID="btnProx" runat="server" Text="Próximo" OnClick="btnProx_Click" />
        </div>
    </form>
</body>
</html>
