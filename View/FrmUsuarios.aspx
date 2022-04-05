<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUsuarios.aspx.cs" Inherits="View.FrmUsurios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous" />
    <title>Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
                <div class="col">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Usuario</label>
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Contraseña</label>
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Tipo de Usuario</label>
                        <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="form-control">
                            <asp:ListItem Value="0">Seleccione</asp:ListItem>
                            <asp:ListItem Value="Administrador">Administrador</asp:ListItem>
                            <asp:ListItem Value="Invitado">Invitado</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                </div>
                <div class="col">
                </div>
                <div class="col">
                </div>
            </div>

        </div>
    </form>
</body>
</html>
