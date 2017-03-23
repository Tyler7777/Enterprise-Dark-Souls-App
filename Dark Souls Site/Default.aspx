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
            <th><asp:Literal ID= "topname1" runat="server" value="Character"></asp:Literal>'s Personal Details</th>
            <th><asp:Literal ID= "topname2" runat="server" value="Character"></asp:Literal>'s Equipment</th>
            <th><asp:Literal ID= "topname3" runat="server" value="Character"></asp:Literal>'s Stats</th>
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
                <hr />
                <br /><br /><br /><br />
                Level: <asp:Literal ID="Level" runat="server" Text="0" ></asp:Literal>
                <br /><br />
                Vigor: <asp:Literal ID="Vigor" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="+" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="-" />
                <br /><br />
                Attunement: <asp:Literal ID="Attunement" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="+" />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="-" />
                <br /><br />
                Endurance: <asp:Literal ID="Endurance" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="+" />
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="-" />
                <br /><br />
                Vitality: <asp:Literal ID="Vitality" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="+" />
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="-" />
                <br /><br />
                Strength: <asp:Literal ID="Strength" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="+" />
                <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="-" />
                <br /><br />
                Dexterity: <asp:Literal ID="Dexterity" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="+" />
                <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="-" />
                <br /><br />
                Intelligence: <asp:Literal ID="Intelligence" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="+" />
                <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="-" />
                <br /><br />
                Faith: <asp:Literal ID="Faith" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="+" />
                <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="-" />
                <br /><br />
                Luck: <asp:Literal ID="Luck" runat="server" Text="0"></asp:Literal>
                <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="+" />
                <asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="-" />
                <br /><br />


                <br /><br /><br /><br />
                <hr />
                Additional Notes/Requirements:
                <asp:TextBox ID="Notes" runat="server" Width="100%" ReadOnly="true" Rows="5" Height="172px" TextMode="MultiLine"></asp:TextBox>
                <br /><br /><br /><br /><br /><br /><br /><br />
                <center><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate Stats" Height="52px" Width="201px" Font-Size="X-Large" /></center>

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
                <td>LH1: 
                    <br />
                    <asp:DropDownList ID="LH1" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:Dark_SoulsConnectionString7 %>" SelectCommand="SELECT [Name] FROM [Weapons] ORDER BY [Name]"></asp:SqlDataSource>
                    <br /><br /></td>
                <td>LH2:<br />
&nbsp;<asp:DropDownList ID="LH2" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
               <td> LH3:<br />
&nbsp;<asp:DropDownList ID="LH3" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                        </tr>
                <tr>
                <td>RH1: 
                    <br />
                    <asp:DropDownList ID="RH1" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
               <td> RH2:<br />
&nbsp;<asp:DropDownList ID="RH2" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                <td>RH3:<br />
&nbsp;<asp:DropDownList ID="RH3" runat="server" DataSourceID="SqlDataSource7" DataTextField="Name" DataValueField="Name"></asp:DropDownList><br /><br /></td>
                    </tr>
                    </table>
                <hr />
                <table>
                    <tr>
                        <td>
                            <asp:DropDownList ID="spell1" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell2" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell3" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell4" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell5" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell6" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell7" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell8" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell9" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="spell10" runat="server">
                                <asp:ListItem>Great Heal (Req. Int 0, Faith 25)</asp:ListItem>
                                <asp:ListItem>Lifehunt Scythe (Req. Int 0, Faith 22)</asp:ListItem>
                                <asp:ListItem>Darkmoon Blade (Req. Int 0, Faith 30)</asp:ListItem>
                                <asp:ListItem>Dead Again (Req. Int 15, Faith 23)</asp:ListItem>
                                <asp:ListItem>Divine Pillars of Light (Req. Int 0, Faith 30)</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>


            <td>
                <!-- third cell, has all stats-->
                Defenses:<br /><br /><br />
                Physical: <asp:Literal ID="PhysicalDef" runat="server" Text="0" ></asp:Literal>
                <br /><br />
                VS Strike: <asp:Literal ID="StrikeDef" runat="server" Text="0"></asp:Literal>
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

                <hr />
                Poise: <asp:Literal ID="Poise" runat="server" Text="0"></asp:Literal>
                <br /><br />
                Carry Weight: <asp:Literal ID="CWeight" runat="server" Text="0"></asp:Literal>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <center>
                    <asp:Button ID="SAVE" runat="server" Font-Size="X-Large" Height="52px" OnClick="SaveButton" Text="Save" Width="201px" />
                </center>
            </td>
        </tr>


    </table>
    </form>
</body>
</html>