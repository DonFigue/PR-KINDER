<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeacherUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Teacher.TeacherUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <form runat="server" id="form"  method="post">
    <div class="card bg-dark text-white">
        <div class="card-header text-center bg-warning">
            <h3>Editar Profesor</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                    <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="txtFirstName" class="form-label">Nombre(s)</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                        <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="LastName" class="form-label">Primer Apellido</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                        <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="SecondLastName" class="form-label">Segundo Apellido</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                        <asp:Label ID="lblSegError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Ci" class="form-label">Carnet de Identidad</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCI"  />
                                        <asp:Label ID="lblCiError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Cellphone" class="form-label">Celular</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCellphone"  />
                                        <asp:Label ID="lblCellphone" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                              
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Address" class="form-label">Dirección</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress"  />
                                        <asp:Label ID="lblAddress" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                              
                                    </div>
                            </div>
                            

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="form-label">Fecah de Nacimiento</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBirthDate" TextMode="Date"  />
                                        <asp:Label ID="lblBirthdate" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
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
                                            <label for="PlaceBirth" class="form-label">Ciudad</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtPlaceOfBirth"  />
                                        <asp:Label ID="lblPlaceBirth" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                     </div>

                                </div>
                                    </div>
                                        <div class="d-grid gap-2">
                                        </div>
                               
                            </div>
                        </div>

                  

                    <div class="card-footer bg-dark text-white">
                        <div class="d-grid gap-2">
                            <asp:Button runat="server" ID="btnRegister" Text="Guardar Cambios"  CssClass="btn btn-outline-warning" OnClick="btnRegister_Click"/>
                            <a class="btn btn-outline-secondary" href="TeacherIndex.aspx">Volver a la Lista de Profesores</a>
                        </div>
              </div>

          </div>
</form>
</asp:Content>
