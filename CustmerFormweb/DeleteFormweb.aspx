<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteFormweb.aspx.cs" Inherits="CustmerFormweb.DeleteFormweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbCustName" runat="server" Text="Custmer Name"></asp:Label>
            :-&nbsp;
            <asp:TextBox ID="txtDltNameData" runat="server" Height="29px" OnTextChanged="TextBox1_TextChanged" Width="241px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbCustId" runat="server" Text="Custmer ID"></asp:Label>
            :-&nbsp;&nbsp;
            <asp:TextBox ID="txtDltIDData" runat="server" Height="29px" Width="233px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnDelete" runat="server" Height="55px" OnClick="BtnDelete_Click" Text="Delete" Width="121px" />
&nbsp;<br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
