<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questao9.aspx.cs" Inherits="Quiz_AspX.Questao9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>  <h1> <asp:Label ID="Label1" runat="server" Text="Bairros"></asp:Label>
         </h1></center> 
            <br /><br />
                                <center>
            <asp:Label ID="Label2" runat="server" Text=" Qual o pior Municipio do estado de São Paulo"></asp:Label>
            <br /> <br />
            <asp:RadioButton ID="rdoOpc1" GroupName="opc" runat="server" Text="Ribeirão Preto"/> <br />
            <asp:RadioButton ID="rdoOpc2" GroupName="opc" runat="server" Text="Ribeirão Pires " /> <br />
            <asp:RadioButton ID="rdoOpc3" GroupName="opc" runat="server" Text="Guarulhos"/> <br />
            <asp:RadioButton ID="rdoOpc4" GroupName="opc" runat="server" Text="Barueri"/> <br />
            <asp:Button ID="btnProximo" runat="server" Text="Próximo" OnClick="btnProximi_Click" />
                                  </center>
        </div>
        
    </form>
</body>
</html>
