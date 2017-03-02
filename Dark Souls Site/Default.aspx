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

    <table cellspacing="33%">
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
                <asp:TextBox ID="Name" runat="server" Width="30%" MaxLength="16"></asp:TextBox>
                <br /><br />
                <!-- Character Gender-->
                Gender:
                <asp:DropDownList ID="Gender" runat="server" Width="30%" >
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                <!-- Character Class -->Class: 
                <asp:DropDownList ID="Class" runat="server" DataSourceID="SqlDataSource1" DataTextField="Class_Name" DataValueField="Class_Name"></asp:DropDownList>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString %>" SelectCommand="SELECT [Class_Name] FROM [Class] ORDER BY [Class_Name]"></asp:SqlDataSource>

                <br /><br />
                <!-- Character Covenant -->Covenant:
                <asp:DropDownList ID="Covenant" runat="server">
                <asp:ListItem Selected="True">Warriors of Sunlight</asp:ListItem>
                <asp:ListItem>Way of Blue</asp:ListItem>
                <asp:ListItem>Blue Sentinels</asp:ListItem>
                <asp:ListItem>Blades of the Darkmoon</asp:ListItem>
                <asp:ListItem>Rosaria&#39;s Fingers</asp:ListItem>
                <asp:ListItem>Mound-Makers</asp:ListItem>
                <asp:ListItem>Watchdogs of Farron</asp:ListItem>
                <asp:ListItem>Aldrich Faithful</asp:ListItem>
                </asp:DropDownList>

                <br /><br /><br /><br />
                <hr />
                Additional Notes/Requirements:
                <asp:TextBox ID="Notes" runat="server" Width="70%" ReadOnly="true" Rows="5" Height="100px"></asp:TextBox>
            </td> 


            <td>
                <!-- second cell, here gear selection will be contained -->
                Head:       <asp:DropDownList ID="Head" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString2 %>" SelectCommand="SELECT [Name] FROM [Head] ORDER BY [Name]"></asp:SqlDataSource>
                <br /><br />
                Chest:      <asp:DropDownList ID="Chest" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString3 %>" SelectCommand="SELECT [Name] FROM [Chest] ORDER BY [Name]"></asp:SqlDataSource>
                <br /><br />
                Hands:      <asp:DropDownList ID="Hands" runat="server" DataSourceID="SqlDataSource8" DataTextField="Name" DataValueField="Name" OnTextChanged="Page_Load"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString8 %>" SelectCommand="SELECT [Name] FROM [Hands] ORDER BY [Name]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString4 %>" SelectCommand="SELECT [Name] FROM [Chest] ORDER BY [Name]"></asp:SqlDataSource>
                <br /><br />
                Legs:       <asp:DropDownList ID="Legs" runat="server" DataSourceID="SqlDataSource9" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString9 %>" SelectCommand="SELECT [Name] FROM [Legs] ORDER BY [Name]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString5 %>" SelectCommand="SELECT [Name] FROM [Chest] ORDER BY [Name]"></asp:SqlDataSource>
                <br />

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

                <br />
                <hr />
                Ring 1:     <asp:DropDownList ID="Ring1" runat="server" DataSourceID="SqlDataSource6" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString6 %>" SelectCommand="SELECT [Name] FROM [Rings] ORDER BY [Name]"></asp:SqlDataSource>
                <br /><br />
                Ring 2:     <asp:DropDownList ID="Ring2" runat="server" DataSourceID="SqlDataSource6" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br />
                Ring 3:     <asp:DropDownList ID="Ring3" runat="server" DataSourceID="SqlDataSource6" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br />
                Ring 4:     <asp:DropDownList ID="Ring4" runat="server" DataSourceID="SqlDataSource6" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br />
                <br /><hr /><br />
                <table>
                    <tr>
                <td>LH1: <asp:DropDownList ID="LH1" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString7 %>" SelectCommand="SELECT [Name] FROM [Weapons] ORDER BY [Name]"></asp:SqlDataSource>
                    <br /><br /></td>
                <td>LH2: <asp:DropDownList ID="LH2" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
               <td> LH3: <asp:DropDownList ID="LH3" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                        </tr>
                <tr>
                <td>RH1: <asp:DropDownList ID="RH1" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
               <td> RH2: <asp:DropDownList ID="RH2" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                <td>RH3: <asp:DropDownList ID="RH3" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                    </tr>
                </table>
            </td>


            <td>
                <!-- third cell, has all stats-->
                Defenses:<br /><br /><br />
                Physical: <asp:Literal ID="PhysicalDef" runat="server" Text="0" ></asp:Literal>
                <br /><br />
                VS Strike <asp:Literal ID="StrikeDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                VS Slash: <asp:Literal ID="SlashDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                VS Thrust: <asp:Literal ID="ThrustDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Magic: <asp:Literal ID="MagicDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Fire: <asp:Literal ID="FireDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Lightning: <asp:Literal ID="LightningDef" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Dark: <asp:Literal ID="DarkDef" runat="server" Text="0"></asp:Literal>
                <br /><br />

                <hr />
                Resistances:<br /><br /><br />
                Bleed: <asp:Literal ID="BleedRes" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Poison: <asp:Literal ID="PoisonRes" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Frost: <asp:Literal ID="FrostRes" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Curse: <asp:Literal ID="CurseRes" runat="server" Text="0"></asp:Literal>
                <br /><br />
            </td>
        </tr>


    </table>
    </form>
</body>
</html>