<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Login.PasswordChange" %>

<!doctype html>
<html lang="es">
    <head>
        <meta charset="utf-8">

        <title> Formulario de Acceso </title> 

        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="author" content="Videojuegos & Desarrollo">
        <meta name="description" content="Muestra de un formulario de acceso en HTML y CSS">
        <meta name="keywords" content="Formulario Acceso, Formulario de LogIn">
        
        <link href="https://fonts.googleapis.com/css?family=Nunito&display=swap" rel="stylesheet"> 
        <link href="https://fonts.googleapis.com/css?family=Overpass&display=swap" rel="stylesheet">
        <link href="../../dist/css/login.css" rel="stylesheet" />
    </head>
    <body>
        
        <div id="contenedor">
            <div id="central">
                <div id="login">
                    <div class="titulo">
                        Cambio de Contraseña
                    </div>
                    <form id="form1" runat="server">

                        <asp:TextBox runat="server" Placeholder="Ingrese su Usuario" ID="txtUser" CssClass="custom-textbox"></asp:TextBox>

                        <asp:TextBox runat="server" Placeholder="Ingresar Antigua Contraseña" TextMode="Password" ID="txtOldPassword" CssClass="custom-textbox"></asp:TextBox>

                        <asp:TextBox runat="server" Placeholder="Ingresar Nueva Contraseña" TextMode="Password" ID="txtPassword" CssClass="custom-textbox"></asp:TextBox>

                        <asp:TextBox runat="server" Placeholder="Confirmar Nueva Contraseña" TextMode="Password" ID="txtPasswordConfirm" CssClass="custom-textbox"></asp:TextBox>

                        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

                        <asp:Button Text="Cambiar Contraseña" ID="btnChange" runat="server" CssClass="button" OnClick="btnChange_Click" />

                    </form>
                </div>
            </div>
        </div>
            
    </body>
</html>
