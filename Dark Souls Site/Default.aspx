<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="MyStyle.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h6> Dark Souls III   Character Builder </h6>
    <br /><br /><br /><br /><br /><br />

    <table cellspacing: 33%;>
        <tr>
            <!-- Top Row containing essentially headers for the three columns, will break down the columns to sections-->
            <th>Character Personal Details</th>
            <th>Character Equipment</th>
            <th>Character Stats</th>
            <!-- maybe replace "characters" with name from textbox?-->
        </tr>
        <tr>
            <td>
                <!-- first cell, will contain name, covenat, class -->
                <!-- character name -->Character Name: 
                <asp:TextBox ID="TextBox1" runat="server" Width="30%" MaxLength="16"></asp:TextBox>
                <br /><br />
                <!-- Character Gender-->
                Gender:
                <asp:DropDownList ID="DropDownList1" runat="server" Width="30%" >
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td> 
            <td>
                <!-- second cell, here gear selection will be contained -->
            </td>
            <td>
                <!-- first cell, will contain name, covenat, class -->
            </td>
        </tr>


    </table>
    </form>
</body>
</html>