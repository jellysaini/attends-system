<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="project.admin.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                    <td style="width:21%">&nbsp;</td>
                    <td style="width:58%">
                        <fieldset id="login_fieldset" style="height:235px">
                            <legend><b style="font-family:Arial;font-size:large">Change&nbsp;Password</b></legend>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                   
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="width:1%">&nbsp;</td>
                                                    <td style="width:40%" align="left"><b style="font-family:Arial;font-size:medium">
                                                        Old&nbsp;Password:</b></td>
                                                    <td style="width:57%" align="right"><asp:TextBox ID="txt_old_password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></td>
                                                    <td style="width:2%">&nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="width:1%">&nbsp;</td>
                                                    <td style="width:40%" align="left"><b style="font-family:Arial;font-size:medium">
                                                        New&nbsp;Password:</b></td>
                                                    <td style="width:57%" align="right"><asp:TextBox ID="txt_new_password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></td>
                                                    <td style="width:2%">&nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="width:1%">&nbsp;</td>
                                                    <td style="width:40%" align="left"><b style="font-family:Arial;font-size:medium">
                                                        Confirm&nbsp;Password:</b></td>
                                                    <td style="width:57%" align="right"><asp:TextBox ID="txt_confirm_password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></td>
                                                    <td style="width:2%">&nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    
                                                    <td style="width:100%" align="center">
                                                        <asp:Button ID="btn_change_password" runat="server" Text="Change" 
                                                            CssClass="btn" onclick="btn_change_password_Click"/>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr><td align="center">
                                        <asp:Label ID="lblerr" runat="server" ForeColor="Red" style="font-weight:600;font-size:14px"></asp:Label>
                                    </td></tr>
                                    
                                </table>
                        </fieldset>
                    </td>
                    <td style="width:21%">&nbsp;</td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td>&nbsp;</td>
            </tr>
            
        </table>
</asp:Content>
