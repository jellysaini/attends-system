<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="viewuserdetail.aspx.cs" Inherits="project.admin.WebForm8" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
 <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 100%">
                <fieldset id="user_fieldset" style="height: auto">
                    <legend><b style="font-family: Arial; font-size: large">View Salary Detail</b></legend>
                    <table border="0" cellpadding="0" width="100%">
                        <tr>
                            <td align="center" style="width:100%">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    ForeColor="#333333" GridLines="None" DataKeyNames="UserId" 
                                    AllowPaging="True" PageSize="8"
                                    onpageindexchanging="GridView1_PageIndexChanging" 
                                    onrowediting="GridView1_RowEditing" >
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="User&amp;nbsp;Id">
                                            <ItemTemplate>
                                                <%#Eval("UserId") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="First&amp;nbsp;Name">
                                            <ItemTemplate>
                                                <%#Eval("UserFirstName") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email&amp;nbsp;Address">
                                            <ItemTemplate>
                                                <%#Eval("UserEmailAddress") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Mobile&amp;nbsp;No.">
                                            <ItemTemplate>
                                                <%#Eval("UserMobile") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="User&amp;nbsp;DOB">
                                            <ItemTemplate>
                                                <%#Eval("DOB") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Salary">
                                            <ItemTemplate>
                                                <%#Eval("UserSalary") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Adress">
                                            <ItemTemplate>
                                                <%#Eval("UserAddress") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Designation">
                                            <ItemTemplate>
                                                <%#Eval("DesignationType") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status">
                                            <ItemTemplate>
                                                <%#Eval("StatusType") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Edit">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnk" runat="server" CommandName="edit" Text="Edit" CssClass="lnk"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnk1" runat="server" CommandName="delete" Text="Delete" CssClass="lnk"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <AlternatingRowStyle BackColor="White" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>
