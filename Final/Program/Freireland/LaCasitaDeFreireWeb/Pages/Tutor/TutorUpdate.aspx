<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="form">
     <div class="card bg-dark text-white">
        <div class="card-header text-center bg-warning">
            <h3>Editar Tutor </h3>
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
                                            <label for="LastName" class="control-label">Apellido</label>
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
                                <hr />
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Cellphone" class="control-label">Celular</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtCellphone"  />
                                        <asp:Label ID="lblCellphone" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                        
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
                                            <label for="Email" class="control-label">Email</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"  />
                                        <asp:Label ID="lblEmail" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                     
                                            </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="WorkPlace" class="control-label">Lugar de Trabajo</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtWorkPlace"  />
                                        <asp:Label ID="lblWorkPlace" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="control-label">Fecha de Nacimiento</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBirthDate" TextMode="Date"  />
                                        <asp:Label ID="lblBirthdate" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                        
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Profession" class="control-label">Profesion</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtProfession"  />
                                        <asp:Label ID="lblProfession" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                      
                                            </div>
                                     </div>
                                        <p> </p>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            

                                            <asp:RadioButtonList ID="rdbGender" runat="server" CssClass="form-control">
                                                <asp:ListItem Text="Masculino" Value="M" />
                                                <asp:ListItem Text="Femenino" Value="F" />
                                                <asp:ListItem Text="Otro" Value="O" Selected="True" />
                                            </asp:RadioButtonList>
                                        <asp:Label ID="lblGenero" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                 <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="PlaceBirth" class="control-label">Ciudad</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtPlaceOfBirth"  />
                                        <asp:Label ID="lblPlaceBirth" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                      
                                            </div>
                                     </div>
                                <hr />
                                  <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="nit" class="control-label">NIT</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtNIT"  />
                                        <asp:Label ID="lblNit" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="txtBusinessName" class="control-label">Razon Social</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBusinessName"  />
                                        <asp:Label ID="lblBusinessName" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
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
                <asp:Button runat="server" ID="btnUpdate" Text="Guardar Cambios" CssClass="btn btn-outline-warning" OnClick="btnUpdate_Click" />
                <a class="btn btn-outline-secondary" href="TutorIndex.aspx">Volver a la Lista de Tutores</a>
            </div>
        </div>
         </div>
   </form>
</asp:Content>
