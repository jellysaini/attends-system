<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="userregister.aspx.cs" Inherits="project.admin.WebForm2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td style="width:100%">
                    <table width="100%">
                        <tr>
                            <td style="width:15%">&nbsp;</td>
                            <td style="width:70%">
                            <fieldset id="user_fieldset" style="height:auto">
                            <legend><b style="font-family:Arial;font-size:large">User Register</b></legend>
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">First&nbsp;Name:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_first_name" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Last&nbsp;Name:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_last_name" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_email_address" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Mobile&nbsp;No:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_mobile" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">DOB:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_DOB" runat="server" CssClass="txt"></asp:TextBox>
                                                
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                    <asp:UpdatePanel ID="upd" runat="server" UpdateMode="Conditional"><ContentTemplate>
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Designation:</b></td>
                                                <td style="width:56%" align="right"><asp:DropDownList ID="drp_designation" runat="server" CssClass="drp" AutoPostBack="true" ></asp:DropDownList>
                                                </td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                       </ContentTemplate></asp:UpdatePanel>
                                    </td>
                                </tr>
                               
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Address:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_address" runat="server" CssClass="txt_address" TextMode="MultiLine"></asp:TextBox></td>
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
                                                <td style="width:44%" align="right"><asp:Button ID="btn_save" runat="server" 
                                                        Text="Save" CssClass="btn" onclick="btn_save_Click" /></td>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:8%"><asp:Button ID="btn_refersh" Text="Refresh" runat="server" 
                                                        CssClass="btn" onclick="btn_refersh_Click" />
                                                </td>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:44%">
                                                    <asp:Button ID="btn_View" Text="View" runat="server" CssClass="btn" onclick="btn_View_Click" 
                                                        />
                                                </td>
                                                
                                                
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
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
