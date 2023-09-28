<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttorneyUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Attorney.AttorneyUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <form runat="server" id="form">
  <div class="card bg-dark text-white">
     <div class="card-header">
         <h3>Attorneys</h3>
     </div>
     <div class="card-body">
         <div>
             <div>
                     <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                    <div class="card-body">
                         <div class="row">
                              <div class="col-md-6">
                                    <div class="form-group">
                                      <label for="FirstName" class="control-label">Nombres</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                     <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    
                                        </div>
                               </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="LastName" class="control-label">Primer Apellido</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                     <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                     
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="SecondLastName" class="control-label">Segundo Apellido</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                     <asp:Label ID="lblSegError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                     
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Ci" class="control-label">CI</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtCI"  />
                                     <asp:Label ID="lblCiError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    
                                         </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Address" class="control-label">Direccion</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress"  />
                                     <asp:Label ID="lblAddress" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    
                                         </div>
                                 </div>
                             <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Occupation" class="control-label">Ocupacion</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtOccupation"  />
                                     <asp:Label ID="lblOccupation" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                         
                                     </div>
                                 </div>

                                 <div class="col-md-6">
                                     <div class="form-group">
                                         
                                         <label for="Gender" class="control-label">Genero</label>

                                         <asp:RadioButtonList ID="rdbGender" runat="server" CssClass="form-control">
                                             <asp:ListItem Text="Masculino" Value="M" />
                                             <asp:ListItem Text="Femenino" Value="F" />
                                             <asp:ListItem Text="Otro" Value="O" Selected="True" />
                                         </asp:RadioButtonList>
                                     <asp:Label ID="lblGenero" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    
                                         </div>
                                 </div>
                             </div>
                                 </div>
                                     <div class="d-grid gap-2">
                                     </div>
                            
                         </div>
                     </div>

                 </div>
      
     <div class="card-footer bg-dark text-white">
         <div class="d-grid gap-2">
             <asp:Button runat="server" ID="btnUpdate" Text="Save Changes" CssClass="btn btn-outline-warning" OnClick="btnUpdate_Click" />
             <a class="btn btn-outline-secondary" href="AttorneyIndex.aspx">Cancel</a>
         </div>
     </div>
</form>
</asp:Content>
