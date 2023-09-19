<%@ Page Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="leaverequest.aspx.cs" Inherits="project.user.WebForm2" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                            <legend><b style="font-family:Arial;font-size:large">Apply&nbsp;Leaves</b></legend>
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Leave&nbsp;From:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_leave_form" runat="server" CssClass="txt"></asp:TextBox>
                                                    <cc1:CalendarExtender ID="txt_leave_form_CalendarExtender" runat="server" 
                                                        Enabled="True" TargetControlID="txt_leave_form">
                                                    </cc1:CalendarExtender>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Leave&nbsp;To:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_leave_to" runat="server" CssClass="txt"></asp:TextBox>
                                                    <cc1:CalendarExtender ID="txt_leave_to_CalendarExtender" runat="server" 
                                                        Enabled="True" TargetControlID="txt_leave_to">
                                                    </cc1:CalendarExtender>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Reason:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_reason" runat="server" CssClass="txt_leave" TextMode="MultiLine"></asp:TextBox></td>
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
                                                        Text="Apply" CssClass="btn" onclick="btn_save_Click"/></td>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:8%">
                                                    <asp:Button ID="btn_refersh" Text="Refresh" runat="server" 
                                                    CssClass="btn" onclick="btn_refersh_Click"/></td>
                                                    <td style="width:2%">&nbsp;</td>
                                                <td style="width:44%">
                                                    <asp:Button ID="btn_View" Text="View" runat="server" CssClass="btn" 
                                                        onclick="btn_View_Click" />
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
