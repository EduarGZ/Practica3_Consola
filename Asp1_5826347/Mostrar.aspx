<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="Asp1_5826347.Mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">Category</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
            <asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem>Footwear - Women´s</asp:ListItem>
                <asp:ListItem>New Element</asp:ListItem>
            </asp:DropDownList>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server">Supplier</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:DropDownList ID="ddlSupplier" runat="server">
                <asp:ListItem>Nike</asp:ListItem>
                <asp:ListItem>Vans</asp:ListItem>
            </asp:DropDownList>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblProduct">Product</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtProduct" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server">Description</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="3" Columns="50"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblImage">Image</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtImage" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblPrice">Price</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtPrice" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblNumberInStock">Number in Stock</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtNumberInStock" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblNumberOnOrder" >Number on Order</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtNumberOnOrder" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lblReorderLevel">Reorder Level</asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox runat="server" ID="txtReorderLevel" ></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button runat="server" ID="btn_save" OnClick="btn_save_Click" Text ="Save" />
        </asp:TableCell>
        <asp:TableCell>
            <asp:Button runat="server" ID="btn_back" OnClick="btn_back_Click" Text ="Back" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
        </div>
    </form>
</body>
</html>
