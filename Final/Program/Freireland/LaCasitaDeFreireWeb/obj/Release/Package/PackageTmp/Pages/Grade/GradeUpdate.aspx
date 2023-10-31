<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Grade.GradeUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
         <form runat="server" id="form">
  <div class="card bg-dark text-white">
     <div class="card-header text-center bg-warning">
         <h3>Cursos</h3>
     </div>
     <div class="card-body">
         <div>
             <div>
                     <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                    <div class="card-body">
                         <div class="row">
                            
                              <div class="col-md-6">
                                    <div class="form-group">
                                      <label for="FirstName" class="control-label">Nombre</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                     <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                   
                                        </div>
                               </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="LastName" class="control-label">Nivel</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                     <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                     
                                     </div>
                                 </div
                                     <div class="form-group">
                                        <label for="Price" class="control-label">Costo</label>
                                       <asp:TextBox runat="server" CssClass="form-control" ID="txtPrice"  />
                                    <asp:Label ID="lblPrice" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
    
                                    </div>
                              <div class="col-md-6">
                                 <div class="form-group">
                                     <label for="LastName" class="control-label">Paralelo</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                 <asp:Label ID="Label1" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
     
                                 </div>
                             </div>
                                 
                             
                             </div>
                                 </div>
                                    
                            
                         </div>
                     </div>

                 </div>
      
     <div class="card-footer bg-dark text-white">
         <div class="d-grid gap-2">
             <asp:Button runat="server" ID="btnUpdate" Text="Guardar Cambios" CssClass="btn btn-outline-warning" OnClick="btnUpdate_Click" />
             <a class="btn btn-outline-secondary" href="GradesIndex.aspx">Volver a la Lista</a>
         </div>
     </div>
      </div>
</form>
</asp:Content>
