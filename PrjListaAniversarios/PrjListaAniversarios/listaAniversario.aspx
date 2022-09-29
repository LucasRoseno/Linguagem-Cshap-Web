<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listaAniversario.aspx.cs" Inherits="PrjListaAniversarios.listaAniversario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Insira a data de nascimento do seu amado"></asp:Label><br /><br />

            <asp:Label ID="Label2" runat="server" Text="NOME: "></asp:Label>
            <asp:TextBox ID="txtInsNome" runat="server" Height="16px" Width="128px"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label3" runat="server" Text="Data: "></asp:Label>
            <asp:TextBox ID="txtInsData" runat="server" Height="16px" Width="128px"></asp:TextBox>

            <br /><br />

            <asp:Button ID="btnInserir" runat="server" Text="INSERIR" Height="23px" Width="192px" OnClick="btnInserir_Click" />

            <br /><br /><br /><br />

            <asp:Button ID="btnNomeIdade" runat="server" Text="Nome e idade futura" Width="185px" OnClick="btnNomeIdade_Click" /><br />
            <asp:Label ID="lblMostrar" runat="server" Text="####" Width="500px" Height="200px" BackColor="WhiteSmoke"></asp:Label>


        </div>
    </form>
</body>
</html>
