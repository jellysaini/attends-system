<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="project._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>interNET</title>

<link href="css/styles.css" rel="stylesheet" type="text/css" />
<link href="css/mainstyle.css" rel="stylesheet" type="text/css" />
</head>

<body>

<div id="container">

<div id="header">

<a href="#"></a>&nbsp;

<ul class="menu">
<li class="home"><a href="#" title="home page">home page</a></li>
<li class="about"><a href="#" title="about us">about us</a></li>
<li class="contacts"><a href="#" title="contacts">contacts</a></li>
</ul>

</div>



<div id="content">
    <form id="main_form" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                    <td style="width:25%">&nbsp;</td>
                    <td style="width:50%">
                        <fieldset id="login_fieldset" style="height:210px">
                            <legend><b style="font-family:Arial;font-size:large">Login</b></legend>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="width:1%">&nbsp;</td>
                                                    <td style="width:40%" align="left"><b style="font-family:Arial;font-size:medium">User&nbsp;Name:</b></td>
                                                    <td style="width:57%" align="right"><asp:TextBox ID="txt_user_name" runat="server" CssClass="txt"></asp:TextBox></td>
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
                                                    <td style="width:40%" align="left"><b style="font-family:Arial;font-size:medium">Password:</b></td>
                                                    <td style="width:57%" align="right"><asp:TextBox ID="txt_password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></td>
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
                                                        <asp:Button ID="btn_login" runat="server" Text="Login" CssClass="btn" 
                                                            onclick="btn_login_Click"/>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                    <tr>
                                        <td style="width:100%">
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="width:2%">&nbsp;</td>
                                                    <td style="width:98%" align="center">
                                                        <asp:LinkButton ID="lnk_forget_password" runat="server" 
                                                            onclick="lnk_forget_password_Click"><b style="font-family:Arial;font-size:medium">Forget&nbsp;Password[?]</b></asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td>&nbsp;</td></tr>
                                     <tr><td align="center">
                                        <asp:Label ID="lbl_err" runat="server" ForeColor="Red" Style="font-weight:bold;font-size:14px"></asp:Label>
                                     </td></tr>
                                    
                                </table>
                        </fieldset>
                    </td>
                    <td style="width:25%">&nbsp;</td>
            </tr>
           
            </table>
            <table width="100%">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
           </table>
    </form>
</div>
</div>
<div id="footer"><p><a href="#">HOME</a> | <a href="#">ABOUT US</a> | <a href="#">SERVICES</a> | <a href="#">SOLUTIONS</a> | <a href="#">SUPPORT</a> | <a href="#">NEWS</a> | <a href="#">CONTACTS</a><br/>Copyright &copy; Your Company Name. Designed by <a href="http://www.freecsstemplates.com" target="_blank">FreeCSSTemplates.com</a></p>
</div>
</body>
</html>
