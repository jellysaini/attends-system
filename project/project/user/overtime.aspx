<%@ Page Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="overtime.aspx.cs" Inherits="project.user.WebForm4" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td style="width:100%">
                    <table width="100%">
                        <tr>
                            <td style="width:15%">&nbsp;</td>
                            <td style="width:70%">
                            <fieldset id="user_fieldset" style="height:auto">
                            <legend><b style="font-family:Arial;font-size:large">Overtime</b></legend>
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">User&nbsp;Name:</b></td>
                                                <td style="width:56%" align="right">
                                                   <asp:DropDownList ID="drp_user_name" runat="server" CssClass="drp" 
                                                        AutoPostBack="true" onselectedindexchanged="drp_user_name_SelectedIndexChanged"></asp:DropDownList>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Email&nbsp;Address:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_email" runat="server" CssClass="txt" ReadOnly></asp:TextBox>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Password:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_pssword" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Date:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_date" runat="server" CssClass="txt"></asp:TextBox>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">OvertTime:</b></td>
                                                <td style="width:56%" align="right">
                                                    <asp:DropDownList ID="drp_overtime" runat="server" CssClass="drp" 
                                                        AutoPostBack="True">
                                                        <asp:ListItem Value="0">Select No Of Day</asp:ListItem>
                                                        <asp:ListItem Value="1">Full Day</asp:ListItem>
                                                        <asp:ListItem Value="0.5">Half Day</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:44%" align="right">
                                                    <asp:Button ID="btn_save" runat="server" 
                                                        Text="Apply" CssClass="btn"/></td>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:8%">
                                                    <asp:Button ID="btn_refersh" Text="Refresh" runat="server" 
                                                    CssClass="btn" /></td>
                                                    <td style="width:2%">&nbsp;</td>
                                                <td style="width:44%">
                                                    <asp:Button ID="btn_View" Text="View" runat="server" CssClass="btn" 
                                                      />
                                                </td>
                                                
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr><td style="width:100%" align="center">
                                    <asp:Label ID="lbl" runat="server" ForeColor="red" style="font-weight:bold;font-size:15px"></asp:Label>
                                </td></tr>
                            </table>
                            </fieldset>
                        </td>
                        <td style="width:15%">&nbsp;</td>

                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        
</asp:Content>
