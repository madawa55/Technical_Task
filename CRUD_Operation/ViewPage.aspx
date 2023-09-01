<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPage.aspx.cs" Inherits="CRUD_Operation.ViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblfname" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbllname" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
<br /><br />
        </div>
    </form>
</body>
</html>
