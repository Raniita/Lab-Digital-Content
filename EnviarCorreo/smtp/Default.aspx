<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="smtp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SMTP - Email sending!</title>
    <style type="text/css">
        .auto-style1 {
            width: 441px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" style="width:100%;">
            <tr>
                <td colspan="2" style="padding-left: 10px; padding-top:10px;">
                    <asp:Label ID="Label5" runat="server" Text="Checking send status."></asp:Label>
                    <br />
                    <asp:TextBox ID="status" runat="server" OnTextChanged="status_TextChanged" Width="808px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2" style="padding-left: 10px; padding-top:10px;">
                    <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
                    <br />
                    <asp:TextBox ID="password" TextMode="Password" runat="server" BackColor="#C0FFFF" Width="168px"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td style="padding-left: 10px; padding-top:10px;" class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="To " ForeColor="Black"></asp:Label>
                    <br />
                    <asp:TextBox ID="T1" runat="server" BackColor="#C0FFFF" Width="240px"></asp:TextBox>
                    <br /> <br />
                </td>

                <td style="padding-left: 10px;">
                    <asp:Label ID="Label2" runat="server" Text="From " ForeColor="Black"></asp:Label>
                    <br />
                    <asp:TextBox ID="T2" runat="server" BackColor="#C0FFFF" Width="293px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2" style="padding-left: 10px; padding-top: 10px;">
                    <asp:Label ID="Label3" runat="server" Text="Subject: " ForeColor="Black"></asp:Label>
                    <br />
                    <asp:TextBox ID="T3" runat="server" BackColor="#C0FFFF" Width="755px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="2" style="padding-left: 10px; padding-top: 10px;">
                    <asp:Label ID="Label4" runat="server" Text="Body: " ForeColor="Black"></asp:Label>
                    <br />
                    <asp:TextBox ID="T4" runat="server" BackColor="#C0FFFF" Height="210px" Width="761px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="2" style="padding-left: 10px; padding-top: 10px;">
                    <asp:Label ID="Label6" runat="server" Text="Attatch -> " ForeColor="Black"></asp:Label>
                    <asp:FileUpload ID="fileAttach" runat="server" Width="578px" />
                </td>
            </tr>

            <tr>
                <th colspan="2" style="padding-top: 10px;">
                    <asp:Button ID="send" runat="server" Text="Send" OnClick="Send_Click" BackColor="#C0C000" ForeColor="Navy" />
                </th>
            </tr>
            
        </table>
    </div>
    </form>
</body>
</html>
