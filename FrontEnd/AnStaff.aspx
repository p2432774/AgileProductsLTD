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
        StaffID<asp:TextBox ID="intStaffID" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffFirstnameAndLastname<asp:TextBox ID="txtStaffFirstnameAndLastname" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffDateOfBirth<asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffAddress<asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffPhoneNumber<asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffDepartment<asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        </p>
    <p>
        StaffPermissionToChangeOrAdd<asp:CheckBox ID="txtPermissionToCorAdd" runat="server" />
        </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Button" />
        </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
