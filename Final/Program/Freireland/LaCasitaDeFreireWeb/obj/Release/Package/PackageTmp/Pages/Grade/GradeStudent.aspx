<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeStudent.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Grade.GradeStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
                    <div class="card  text-black">
    <div class="card-header text-center bg-info">
          <div class="d-grid gap-2">
<button id="mostrarBoton" class="btn btn-outline-light btn-lg fs-2">Alumnos</button>

  </div>
        <form runat="server" id="search">
    <asp:TextBox runat="server" ID="txtSearch" CssClass="form-control" style="display: inline-block; width: auto;" />
    <asp:Button runat="server" ID="btnSearch" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" style="display: inline-block; margin-left: 10px;" />
</form>
    </div>
    <div ID="divTable" runat="server" class="card-body">
        
    </div>
    <div runat="server" ID="divPrint" hidden>

    </div>
</div>
    <script>
    var divElement = document.getElementById("<%= divPrint.ClientID %>");
    var mostrarBoton = document.getElementById("mostrarBoton");

    mostrarBoton.addEventListener("click", function () {
        // Obtener el contenido del divTable
        var contenido = divElement.innerHTML;

        // Crear una ventana emergente para mostrar el contenido
        var ventana = window.open("", "Ventana de impresión");
        ventana.document.open();
        // Agregar una hoja de estilos específica para la impresión
        //ventana.document.write("<html><head><title>Lista de Estudiantes</title><style>@media print{ table { border-collapse: collapse; width: 100%; } th, td { border: 1px solid black; padding: 8px; }</style></head><body>" + contenido + "</body></html>");
        ventana.document.write("<html><head><title>Lista de Estudiantes</title><link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'><style>@media print{ table { border-collapse: collapse; width: 100%; } th, td { border: 1px solid black; padding: 8px; }</style></head><body class='container'>" + contenido + "</body></html>");
ventana.document.close();

        // Imprimir la ventana emergente
        ventana.print();
    });
    </script>
</asp:Content>
