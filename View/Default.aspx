<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="View.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous" />
    <title>Inicio de Sesion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
                <div class="col"></div>
                <div class="col">
                    <div class="card text-center">
                        <div class="card-header">
                            Inicio de Sesion
                        </div>
                        <div class="card-body">
                            <h5 class="card-title">Mi Tienda</h5>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Usuario</label>
                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputPassword1">Contraseña</label>
                                <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>

                        </div>
                        <div class="card-footer text-muted">
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClick="btnIngresar_Click" />
                        </div>
                    </div>
                </div>
                <div class="col"></div>
            </div>
        </div>
    </form>
</body>
</html>
