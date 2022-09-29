<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="PrjCalendar.Calendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar id="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged">
   <DayStyle BackColor="#FC2080" 
      BorderWidth="3"
      BorderStyle="Groove">
   </DayStyle>
                

               
</asp:Calendar>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />



            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged">
                <DayStyle BackColor="#AC9080" 
      BorderWidth="3"
      BorderStyle="Groove">
   </DayStyle>
            </asp:Calendar>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btnConvCompa" runat="server" Text="Converter e Comparar" Height="45px" OnClick="btnConvCompa_Click" Width="205px" />
            
            <br /><br />
                    <asp:Label ID="lblMostrar" runat="server" Text="#"></asp:Label>

        </div>

    </form>
</body>
</html>
