<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 117px;
        }
        .auto-style3 {
            width: 116px;
        }
        .auto-style4 {
            width: 89px;
        }
        .auto-style5 {
            width: 423px;
        }
        .auto-style6 {
            width: 247px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label1" runat="server" Text="Investigation"></asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:DropDownList ID="InvestigationDropDownList" runat="server">
                                        <asp:ListItem Value="-1">Select</asp:ListItem>
                                        <asp:ListItem Value="1">Utkarsh</asp:ListItem>
                                        <asp:ListItem Value="2">Kaustubh</asp:ListItem>
                                        <asp:ListItem Value="3">Lokesh</asp:ListItem>
                                        <asp:ListItem Value="4">Somesh</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style4">
                                    <asp:Label ID="Label2" runat="server" Text="Marks"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="MarksTextBox" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>
                                    <asp:Button ID="AddToGridButton" runat="server" OnClick="AddToGridButton_Click" Text="Add To Grid" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td>
                                    <%--<asp:GridView ID="GridView1" runat="server">
                                    </asp:GridView>--%>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
                                        <Columns>
                                            <asp:BoundField DataField="S_No" HeaderText="S. No" />
                                            <asp:BoundField DataField="Investigation" HeaderText="Investigation" />
                                            <asp:BoundField DataField="Marks" HeaderText="Marks" />
                                            <asp:TemplateField HeaderText="Actions">
                                                <%--<ItemTemplate>
                                                    <asp:Button runat="server" CommandName="Edit" Text="Edit" CssClass="btn btn-primary" />
                                                    <asp:Button runat="server" CommandName="Delete" Text="Delete" CssClass="btn btn-danger" />
                                                </ItemTemplate>--%>
                                            </asp:TemplateField>
    </Columns>
</asp:GridView>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
