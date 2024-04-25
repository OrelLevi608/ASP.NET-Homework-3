<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web09042024.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>

      <!-- Bootstrap -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
      <!-- Bootstrap and -->
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Bootstrap -->
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Navbar</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavDropdown">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="#">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Features</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Pricing</a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">Dropdown link
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <li><a class="dropdown-item" href="#">Action</a></li>
                                <li><a class="dropdown-item" href="#">Another action</a></li>
                                <li><a class="dropdown-item" href="#">Something else here</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
         <!-- Bootstrap and -->

            First Name <asp:TextBox ID="TextRegisFName" runat="server" required="required" />
            Last Name <asp:TextBox ID="TextRegisLName" runat="server" required="required" /> <br />
            Password <asp:TextBox ID="TextRegisPass" TextMode="Password" runat="server" required="required" /> <br />
            Email <asp:TextBox ID="TextRegisEmail" TextMode="Email" runat="server" required="required" /> <br /><br />
            City <asp:DropDownList ID="DDLRegisCity" runat="server" /> <br /><br />
            Code City <asp:DropDownList ID="DDLRegisCodeCity" runat="server" /> <br /><br />
                <asp:Button ID="BtnRegis" Text="Register" OnClick="BtnRegis_Click" runat="server" /> <br /><br />
                <asp:Literal ID="LtlMsg" runat="server" />
    </div>
</form>

</body>
</html>
