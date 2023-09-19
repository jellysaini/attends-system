<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="leaverequst.aspx.cs" Inherits="project.admin.WebForm5" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
        <asp:ScriptManager ID="scr" runat="server"></asp:ScriptManager>
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 100%">
                <fieldset id="user_fieldset" style="height: auto">
                    <legend><b style="font-family: Arial; font-size: large">View Leave Request</b></legend>
                    <table border="0" cellpadding="0" width="100%">
                        <tr>
                            <td align="center">
                                <asp:UpdatePanel ID="upd" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                    
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    ForeColor="#333333" GridLines="None" AllowPaging="True"
                                    PageSize="8" DataKeyNames="Id" onrowdeleting="GridView1_RowDeleting" 
                                    onrowediting="GridView1_RowEditing">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Apply&amp;nbsp;Date">
                                            <ItemTemplate>
                                                <%#Eval("ApplyDate") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="User&amp;nbsp;Id">
                                            <ItemTemplate>
                                                <%#Eval("UserId") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="User&amp;nbsp;Name">
                                            <ItemTemplate>
                                                <%#Eval("UserName") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Designation">
                                            <ItemTemplate>
                                                <%#Eval("DesignationType") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Leave&amp;nbsp;From">
                                            <ItemTemplate>
                                                <%#Eval("LeaveFrom") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Leave&amp;nbsp;To">
                                            <ItemTemplate>
                                                <%#Eval("LeaveTo") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="No&amp;nbsp;Of&amp;nbsp;Day">
                                            <ItemTemplate>
                                                <%#Eval("NoOfDay") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Reason">
                                            <ItemTemplate>
                                                <%#Eval("Reason") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText="Confirm Leave">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnk" runat="server" CommandName="edit" Text="Confirm" CssClass="lnk" OnClientClick="return confirm('Are you sure?');"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Cancel Leave">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnk1" runat="server" CommandName="delete" Text="Cancel" CssClass="lnk" OnClientClick="return confirm('Are you sure?');"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <AlternatingRowStyle BackColor="White" />
                                </asp:GridView>
                                </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr style="height:250px">
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
