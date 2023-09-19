<%@ Page Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true"
    CodeBehind="viewsalarydetail.aspx.cs" Inherits="project.admin.WebForm6" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Admin_ContentPlaceHolder" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 100%">
                <fieldset id="user_fieldset" style="height: auto">
                    <legend><b style="font-family: Arial; font-size: large">View Salary Detail</b></legend>
                    <table border="0" cellpadding="0" width="100%">
                        <tr>
                            <td align="center">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    ForeColor="#333333" GridLines="None" DataKeyNames="SalaryId" OnRowEditing="GridView1_RowEditing"
                                    OnRowDeleting="GridView1_RowDeleting" AllowPaging="True"
                                    PageSize="8" onpageindexchanging="GridView1_PageIndexChanging">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Salary&amp;nbsp;Id">
                                            <ItemTemplate>
                                                <%#Eval("SalaryId") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="User&amp;nbsp;Name">
                                            <ItemTemplate>
                                                <%#Eval("UserFirstName") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Basic&amp;nbsp;Salary">
                                            <ItemTemplate>
                                                <%#Eval("Basic") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="HRA">
                                            <ItemTemplate>
                                                <%#Eval("HRA") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="TA">
                                            <ItemTemplate>
                                                <%#Eval("TA") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="DA">
                                            <ItemTemplate>
                                                <%#Eval("DA") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Daily&amp;nbsp;Rate">
                                            <ItemTemplate>
                                                <%#Eval("DailyRate") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Overtime&amp;nbsp;Rate">
                                            <ItemTemplate>
                                                <%#Eval("DailyOvertimeRate") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Reduction&amp;nbsp;Rate">
                                            <ItemTemplate>
                                                <%#Eval("DailyReductionRate") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Total&amp;nbsp;Salary">
                                            <ItemTemplate>
                                                <%#Eval("TotalSalary") %>
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
