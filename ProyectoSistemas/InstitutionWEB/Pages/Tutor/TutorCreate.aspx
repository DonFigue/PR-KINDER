<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorCreate.aspx.cs" Inherits="InstitutionWEB.Pages.Tutor.TutorCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="card bg-dark text-white">
     <div class="card-header">
         <h3>New Tutor</h3>
     </div>
     <div class="card-body">
         <div>
             <div>
                 <form runat="server">
                    <div class="card-body">
                         <div class="row">
                              <div class="col-md-6">
                                    <div class="form-group">
                                      <label for="FirstName" class="control-label">First Name</label>
                                      <asp:TextBox runat="server" CssClass="form" ID="txtNombre"></asp:TextBox>
                                     </div>
                               </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="LastName" class="control-label">Last Name</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtPrimerApellido"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="SecondLastName" class="control-label">Second Last Name</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtSegundoApellido"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Ci" class="control-label">CI</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtCi"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Cellphone" class="control-label">Cellphone</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtCelular"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Address" class="control-label">Address</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtCiudad"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Email" class="control-label">Email</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtEmail"></asp:TextBox>
                                     </div>
                                 </div>
                                  <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="WorkPlace" class="control-label">WorkPlace</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtLugarTrabajo"></asp:TextBox>
                                     </div>
                                 </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="BirthDate" class="control-label">BirthDate</label>
                                         <asp:TextBox runat="server" CssClass="form" TextMode="Date" ID="txtFechaNacimiento"></asp:TextBox>
                                     </div>
                                 </div>
                                  <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="Profession" class="control-label">Profession</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtProfesion"></asp:TextBox>
                                     </div>
                                  </div>
                                 <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="gender">Gender:</label>
                                        
                                         <input type="radio" id="male" name="gender" value="male">
                                         <label for="male">Male</label>
                                         <input type="radio" id="female" name="gender" value="female">
                                         <label for="female">Female</label>
                                         <input type="radio" id="other" name="gender" value="other">
                                         <label for="other">Other</label>
                                     </div>
                                 </div>
                              <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="PlaceBirth" class="control-label">Place of Birth</label>
                                         <input type="text" id="txtLugarNacimiento" name="PlaceBirth" class="form-control" />
                                     </div>
                                  </div>
                               <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="nit" class="control-label">NIT</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtNit"></asp:TextBox>
                                     </div>
                                 </div>
                                  <div class="col-md-6">
                                     <div class="form-group">
                                         <label for="businessname" class="control-label">Business name</label>
                                         <asp:TextBox runat="server" CssClass="form" ID="txtTrabajo"></asp:TextBox>
                                     </div>
                                  </div>
                             </div>
                                 </div>
                                     <div class="d-grid gap-2">
                                     </div>

                                 <div class="card-footer bg-dark text-white">
                                     <div class="d-grid gap-2">
                                         <asp:Button runat="server" Text="Registrar" CssClass="btn form-control btn-success" ID="btnRegistrar" />
                                         <asp:Button runat="server" Text="Cancelar" CssClass="btn form-control btn-danger" ID="btnCancelar" />
                                 </div>
                             </div>
                            </form>
                         </div>
                     </div>

                 </div>
       </div>
</asp:Content>
