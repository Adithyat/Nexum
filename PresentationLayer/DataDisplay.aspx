<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataDisplay.aspx.cs" Inherits="PresentationLayer.DataDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" CssClass="ViewGrid" ForeColor="Black" CellPadding="3" GridLines="Both">
                <asp:TableRow>
                    <asp:TableCell>ID </asp:TableCell>
                    <asp:TableCell ID="IdCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Name </asp:TableCell>
                    <asp:TableCell ID="NameCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Phone </asp:TableCell>
                    <asp:TableCell ID="PhoneCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Region </asp:TableCell>
                    <asp:TableCell ID="RegionCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Country </asp:TableCell>
                    <asp:TableCell ID="CountryCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>State </asp:TableCell>
                    <asp:TableCell ID="StateCell"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>City </asp:TableCell>
                    <asp:TableCell ID="CityCell"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
