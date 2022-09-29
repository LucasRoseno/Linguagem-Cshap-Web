<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fim.aspx.cs" Inherits="Quiz_Sor_Pergunta.Fim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                     <center>
            <asp:Label ID="Label1" runat="server" Text="ACABOOOOOOOU, ACABOOOOU!!!!"></asp:Label><br /> <br />
            <asp:Label ID="Label2" runat="server" Text="Voce acertou:"></asp:Label>
            <asp:Label ID="lblResposta" runat="server" Text=""></asp:Label>
                                </center>
            <br />
                    <center>
                        <asp:Image ID="Image1" runat="server" Height="243px" Width="408px" />
                        <asp:Image ID="Image2" runat="server" Height="243px" Width="408px" />
                    </center>
                     
            <br />

        </div>
    </form>
</body>
</html>
