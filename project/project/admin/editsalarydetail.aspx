<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="editsalarydetail.aspx.cs" Inherits="project.admin.WebForm7" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td style="width:100%">
                    <table width="100%">
                        <tr>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:90%">
                            <fieldset id="user_fieldset" style="height:auto">
                            <legend><b style="font-family:Arial;font-size:large">Salary Detail</b></legend>
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Select&nbsp;Users:</b></td>
                                                <td style="width:56%" align="right">
                                                    <asp:TextBox ID="txt_user_name" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Basic&nbsp;Salary:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_basic" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">HRA:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_HRA" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">TA:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_TA" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">DA:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_DA" runat="server" CssClass="txt"></asp:TextBox></td>
                                                <td style="width:4%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                                <tr>
                                    <td style="width:100%">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%" 
                                            style="height: 19px">
                                            <tr>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Daily&nbsp;Rate:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_daily_rate" runat="server" CssClass="txt"></asp:TextBox>
                                                
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">
                                                    Daily&nbsp;Overtime&nbsp;Rate:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_daily_overtime" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:39%"><b style="font-family:Arial;font-size:medium">
                                                    Daily&nbsp;Reduction&nbsp;Rate:</b></td>
                                                <td style="width:55%" align="right"><asp:TextBox ID="txt_reduction_rate" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:38%"><b style="font-family:Arial;font-size:medium">Total&nbsp;Salary:</b></td>
                                                <td style="width:56%" align="right"><asp:TextBox ID="txt_total_salary" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                <td style="width:50%" align="right">
                                                    <asp:Button ID="btn_save" runat="server" Text="Update" CssClass="btn" 
                                                        onclick="btn_save_Click"/></td>
                                                <td style="width:2%">&nbsp;</td>
                                                <td style="width:8%">
                                                    <asp:Button ID="btn_refersh" Text="Cancel" runat="server" 
                                                        CssClass="btn" onclick="btn_refersh_Click" /></td>
                                                <td style="width:40%; height: 19px;">&nbsp;</td>
                                                
                                                
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td style="width:100%">&nbsp;</td></tr>
                            </table>
                            </fieldset>
                        </td>
                        <td style="width:5%">&nbsp;</td>

                        </tr>
                    </table>
                </td>
            </tr>
        </table>  
</asp:Content>
