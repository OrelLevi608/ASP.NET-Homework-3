<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web09042024.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
     <!-- Bootstrap and -->
</head>
<body>
    <form id="form1" runat="server">
        <div>

            E-mail <asp:TextBox ID="TextEmail" runat="server" /> <br />
            Password <asp:TextBox ID="TextPass" TextMode="Password" runat="server" /> <br /><br />
                    <asp:Button ID="BtnLogin" runat="server" Text="Connect" OnClick="BtnLogin_Click" />
            <div>
                <asp:Literal ID="LtlMsg" runat="server" /> <!-- Email or password error -->  <!-- מאפשר להזריק אליו קוד מהשרת Literal -->
            </div>

        </div>
    </form>
</body>
</html>
