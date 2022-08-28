<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Store_procedure.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Empno:</strong>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <strong>Ename:</strong>&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <strong>Eadd:&nbsp;&nbsp;&nbsp; </strong>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <strong>Esal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-weight: 700" Text="SAVE" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-weight: 700" Text="UPDATE" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="font-weight: 700" Text="DELETE" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-weight: 700" Text="DISPLAY" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="433px"></asp:ListBox>
    </form>
</body>
</html>
