<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrjForcaAspx_Lucas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
           


            <asp:Image ID="Img1" runat="server" Height="80px" Width="93px" /> <br />
            <asp:Image ID="Img2" runat="server" Height="80px" Width="93px"/> <br />
            <asp:Image ID="Img3" runat="server" Height="80px" Width="93px"/> <br />

            &nbsp &nbsp &nbsp
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
            
            <br /> <br />

            &nbsp &nbsp &nbsp &nbsp
            <asp:TextBox ID="txtBox1" runat="server" Width="30px"></asp:TextBox>
            <asp:TextBox ID="txtBox2" runat="server" Width="30px"></asp:TextBox>
            <asp:TextBox ID="txtBox3" runat="server" Width="30px"></asp:TextBox>
            <br />
            &nbsp  &nbsp
            <asp:Button ID="btnAvaliar" runat="server" Text="Avaliar" OnClick="btnAvaliar_Click" /><br />&nbsp &nbsp
            <asp:Label ID="Label1" runat="server" Text="A PALAVRA É 'ana'"></asp:Label>
        </div>
    </form>
</body>
</html>
