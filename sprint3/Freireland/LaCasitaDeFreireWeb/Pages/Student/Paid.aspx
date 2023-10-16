<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paid.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Student.Paid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="min-height: 100vh;">
      <div class="card" style="width: 18rem;">
          <div class="card-header bg-success text-white">
              <h1>Pago Realizado</h1>
          </div>
        <div class="card-body">
          <h6 class="card-subtitle mb-2 text-muted">El Pago se realizo con exito</h6>
          <p class="card-text">El pago ya fue registrado sera redirigido a la ventana de pagos</p>
        </div>
          <div class="card-footer">
              <div class="d-grid gap-2">
                    <p class="btn btn-outline-secondary">Espere un momento porfavor...</p>
              </div>
          </div>
      </div>
    </div>
</asp:Content>
