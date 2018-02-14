<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        b {
            text-align:center;
        }
        .auto-style1 {
        width: 100%;
    }
        .auto-style3 {
        width: 280px;
        text-align: left;
    }
        td {
            color:white;
        }
    .auto-style2 {
        width: 76px;
    }
    .auto-style4 {
        width: 280px;
        height: 19px;
    }
    .auto-style5 {
        width: 76px;
        height: 19px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b style="color:red">&nbsp;&nbsp;<b style="background-color:white">Your Electricity Bill</b><table class="auto-style1" border="1px" style ="width:58%">
    <tr>
        <td class="auto-style3">Actual Current Consumption Charges</td>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Label" BackColor="Black"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Electricity Tax</td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Actual Fixed Charges</td>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Gross Amount</td>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Govt.Subsidy for Fixed Charges</td>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Govt.Subsidy for Consumption Charges</td>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Net Amount</td>
        <td class="auto-style2">
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4"></td>
        <td class="auto-style5"></td>
    </tr>
</table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/Default.aspx"><b style="background-color:white">Thank You :)</b></asp:HyperLink>
</asp:Content>

