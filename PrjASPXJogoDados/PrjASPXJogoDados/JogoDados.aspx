<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JogoDados.aspx.cs" Inherits="PrjASPXJogoDados.JogoDados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="color">
            <center>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagens/x_png.png" Height="404px" Width="493px" /><br />
            <asp:Button ID="Button1" runat="server" Text="Sortear" Height="142px" OnClick="Button1_Click" Width="185px" />
            </center>
        </div>
        <style>
           
        </style>
    </form>
</body>
</html>
