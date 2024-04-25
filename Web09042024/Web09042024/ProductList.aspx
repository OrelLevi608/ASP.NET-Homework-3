<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Web09042024.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="LtlUeser" runat="server" />  <br /> <br />
            Please select your product from the following lists: <br /> <br />
            Code <asp:DropDownList ID="DDLCodeProd" runat="server" /> <br /> <br />
            Name <asp:DropDownList ID="DDLNameProd" runat="server" /> <br /> <br />
            Price <asp:DropDownList ID="DDLPriceProd" runat="server" /> <br /> <br />
            Description <asp:DropDownList ID="DDLDescProd" runat="server" /> <br /> <br />
            Image <asp:DropDownList ID="NameImageProd" runat="server" /> <br /> <br />
            Code Category <asp:DropDownList ID="DDLCodeCatPord" runat="server" /> <br /> <br />
            Status <asp:DropDownList ID="DDLStatusProd" runat="server" /> <br /> <br />
            Date <asp:TextBox ID="DataPord" runat="server" TextMode="Date" /> <br /> <br />
        </div>
    </form>
</body>
</html>
