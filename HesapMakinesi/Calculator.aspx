<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="HesapMakinesi.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hesap Makinesi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div ><asp:TextBox ID="TextBox" runat="server" Width="192px" Height="40px"  Font-Bold="true" Font-Size="20px" AutoPostBack="True"></asp:TextBox>
            <br/>
            <asp:Button ID="Button1" Height="60px" Width="50px" Font-Size="Large" Text-size="100px" runat="server" Text="7" OnClick="Button_Click" /><asp:Button ID="Button2"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="8" OnClick="Button_Click" /><asp:Button ID="Button3"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="9" OnClick="Button_Click" /><asp:Button ID="Button4"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="/" OnClick="Button_Click" />
            <br/>
            <asp:Button ID="Button5"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="4" OnClick="Button_Click" /><asp:Button ID="Button6"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="5" OnClick="Button_Click" /><asp:Button ID="Button7"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="6" OnClick="Button_Click" /><asp:Button ID="Button8"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="*" OnClick="Button_Click" />
            <br/>
            <asp:Button ID="Button9"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="1" OnClick="Button_Click" /><asp:Button ID="Button10"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="2" OnClick="Button_Click" /><asp:Button ID="Button11"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="3" OnClick="Button_Click" /><asp:Button ID="Button12"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="-" OnClick="Button_Click" />
            <br/>
            <asp:Button ID="Button13"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="0" OnClick="Button_Click" /><asp:Button ID="Button14"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="+" OnClick="Button_Click" /><asp:Button ID="Button15" Height="60px" Width="50px" Font-Size="Large" runat="server" Text="CLC" OnClick="Button_Click" /><asp:Button ID="Button16"  Height="60px" Width="50px" Font-Size="Large" runat="server" Text="=" OnClick="Button_Click" />
        </div>
    </form>
</body>
</html>
