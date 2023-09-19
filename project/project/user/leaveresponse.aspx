<%@ Page Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="leaveresponse.aspx.cs" Inherits="project.user.WebForm3" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="scr" runat="server"></asp:ScriptManager>
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 100%">
                <fieldset id="user_fieldset" style="height: auto">
                    <legend><b style="font-family: Arial; font-size: large">View Leave Response</b></legend>
                    <table border="0" cellpadding="0" width="100%">
                        <tr>
                            <td align="center">
                            <asp:UpdatePanel ID="upd" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    ForeColor="#333333" GridLines="None" DataKeyNames="Id" AllowPaging="True" 
                                    PageSize="8"  Width="90%" onrowdeleting="GridView1_RowDeleting">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Confirm&amp;nbsp;Or&amp;nbsp;Not">
                                            <ItemTemplate>
                                                <%#Eval("NotConfrimReason") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Leave&amp;nbsp;From">
                                            <ItemTemplate>
                                                <%#Eval("LeaveFrom") %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Leave&amp;nbsp;To">
                                            <ItemTemplate>
                                                <%#Eval("LeaveTo")%>
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
