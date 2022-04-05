<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="View.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous" />
    <title>Inicio</title>
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
        <div class="container-fluid">
            <div class="row">
                <img src="Imagenes/productos.jpeg" class="img-fluid" />
            </div>
            <div class="row">
                <div class="card">
                    <div class="card-header">
                        Lista de Productos
                    </div>
                    <div class="card-body">
                        <asp:GridView ID="gvProductos" CssClass="table table-hover" runat="server" DataKeyNames="IdProducto">
                    </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
