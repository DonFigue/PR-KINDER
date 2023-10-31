<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payments.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Student.Payments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div class="card text-black">
    <div class="card-header text-center bg-success">
        <div class="d-grid gap-2">
      <button id="mostrarBoton" class="btn btn-outline-light btn-lg fs-2">Pagos</button>

        </div>
    </div>
    <div ID="divTable" runat="server" class="card-body bg-dark">
      <!-- Tu contenido generado en el servidor aquí -->
      <%-- Este puede ser contenido dinámico generado por ASP.NET --%>
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
          ventana.document.write("<html><head><title>Proforma de Pagos</title><style>@media print{ table { border-collapse: collapse; width: 100%; } th, td { border: 1px solid black; padding: 8px; }</style></head><body>" + contenido + "</body></html>");
          ventana.document.close();

          // Imprimir la ventana emergente
          ventana.print();
      });
  </script>
</asp:Content>
