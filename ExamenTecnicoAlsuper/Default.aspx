<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="background-color:blueviolet; font-size:xx-large; color:white"  align="center">
        Employees
    </div>
    <br />
    <div align="center" style-="padding:15px">
        <br />
        <table  >
            <tr>
                <td>&nbsp;<asp:Label runat="server" Text="Employee Id" ID="Label2"></asp:Label></td>
                <td>&nbsp;<asp:TextBox runat="server" ID="Text_Id"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;<asp:Label runat="server" Text="Name" ID="ctl02"></asp:Label></td>
                <td>&nbsp;<asp:TextBox runat="server" ID="Text_Name"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;<asp:Label runat="server" Text="LastName P" ID="ctl03"></asp:Label></td>
                <td>&nbsp;<asp:TextBox runat="server" ID="Text_LastP"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;<asp:Label runat="server" Text="LastName M" ID="Label1"></asp:Label></td>
                <td>&nbsp;<asp:TextBox runat="server" ID="Text_LastM"></asp:TextBox></td>
            </tr>
        </table>
        <div align="center">
            <asp:Button runat="server" Text="Add" Width="75px" ID="Btn_Add"></asp:Button>
            <asp:Button runat="server" Text="Update" Width="75px" ID="Btn_Update"></asp:Button>
            <asp:Button runat="server" Text="Delete" Width="75px" ID="Btn_Delete"></asp:Button>
        </div>
        <br />
        
        <div align="center">
            <hr />
            <asp:GridView runat="server" ID="GridView1" Width="80%"></asp:GridView>
        </div>
        <br />

        <div align="center">
            <hr />
            <asp:GridView runat="server" ID="Gridview2" Width="80%"></asp:GridView>
            
        </div>
<br />

    </div>
</asp:Content>
