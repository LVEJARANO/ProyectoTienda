<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultDatos.aspx.cs" Inherits="View.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous" />
    <title>Mi Tienda</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Mi Tienda</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavDropdown">
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link" href="Index.aspx">Inicio <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Default.aspx">Productos</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="FrmCategorias.aspx">Categorias</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="FrmUsuarios.aspx">Usuarios</a>
                    </li>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="row">
                <asp:TextBox ID="txtId" runat="server" Visible="false"></asp:TextBox>
                <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label><br />
                <div class="col-sm">
                    <asp:Label ID="Label4" runat="server" Text="Descripcion del Producto"></asp:Label>
                    <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox><br />
                </div>
                <div class="col-sm">
                    <asp:Label ID="Label5" runat="server" Text="Precio"></asp:Label>
                    <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox><br />
                </div>
                <div class="col-sm">
                    <asp:Label ID="Label6" runat="server" Text="Codigo"></asp:Label>
                    <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server"></asp:TextBox><br />
                </div>
                <div class="col-sm">
                    <asp:Label ID="Label3" runat="server" Text="Categorias"></asp:Label><br />
                    <asp:DropDownList ID="ddlCategoria" CssClass="form-control" runat="server"></asp:DropDownList><br />
                    <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm">
                    <asp:Label ID="Label1" runat="server" Text="Lista de Productos de Mi Tienda"></asp:Label><br />
                    <asp:GridView ID="gvProductos" CssClass="table table-hover" runat="server" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged" OnRowDeleting="gvProductos_RowDeleting" DataKeyNames="IdProducto">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" Text="Eliminar" OnClientClick="return confirm('¿Estas seguro de que quieres ELIMINAR el producto?');"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
