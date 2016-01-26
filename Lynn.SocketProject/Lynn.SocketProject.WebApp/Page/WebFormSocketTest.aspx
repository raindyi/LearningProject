<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSocketTest.aspx.cs" Inherits="Lynn.SocketProject.WebApp.Page.WebFormSocketTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="LabelServerIP" runat="server" Text="ServerIP"></asp:Label>
                <asp:TextBox ID="TextBoxServerIP" runat="server" Height="21px"></asp:TextBox>
                <br />
                <asp:Label ID="LabelServerPort" runat="server" Text="ServerPort"></asp:Label>
                <asp:TextBox ID="TextBoxServerPort" runat="server" Height="21px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonStartServer" runat="server" Text="Server Start" OnClick="ButtonStartServer_Click" />

                <br />
                <asp:Label ID="LabelServerMessage" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="ButtonClientConnect" runat="server" OnClick="ButtonClientConnect_Click" Text="Client Connect" />
                <br />
                <asp:Label ID="LabelClientMessage" runat="server" Text="Label"></asp:Label>

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
