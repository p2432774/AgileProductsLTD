<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStaff.aspx.cs" Inherits="AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        AnStaff</p>
    <p>
        StaffID<asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click1" />
        </p>
    <p>
        StaffFirstnameAndLastname<asp:TextBox ID="txtStaffFirstnameAndLastname" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffDateOfBirth<asp:TextBox ID="txtStaffDateOfBirth" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffAddress<asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffPhoneNumber<asp:TextBox ID="txtStaffPhoneNumber" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffDepartment<asp:TextBox ID="txtStaffDepartment" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffPermissionToChangeOrAdd<asp:CheckBox ID="txtStaffPermissionToCorAdd" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Error Message"></asp:Label>
        </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
