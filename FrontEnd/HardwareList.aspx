<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HardwareList.aspx.cs" Inherits="HardwareList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstHardwareList" runat="server" Height="526px" OnSelectedIndexChanged="lstHardwareList_SelectedIndexChanged" Width="436px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
