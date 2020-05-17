<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" Height="607px" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" Width="693px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
