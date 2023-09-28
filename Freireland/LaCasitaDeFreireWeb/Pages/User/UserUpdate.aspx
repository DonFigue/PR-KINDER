<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.User.UserUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <form runat="server" id="form"  method="post">
    <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>Actualizar Usuario</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                    <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                        <div class="row">
                             <div class="col-md-6">
                                <div class="form-group">
                                    <label for="txtNameUser" class="form-label">Nombre de usuario:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNameUser"  />
                                        <asp:Label ID="lblNameUser" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Password" class="form-label">Contraseña:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="Password"  />
                                        <asp:Label ID="lblPassword" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="txtFirstName" class="form-label">Nombres:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                        <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="LastName" class="form-label">Primer Apellido: </label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                        <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="SecondLastName" class="form-label">Segundo Apellido:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                        <asp:Label ID="lblSegError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Ci" class="form-label">CI</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCI"  />
                                        <asp:Label ID="lblCiError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Cellphone" class="form-label">Telefono</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCellphone"  />
                                        <asp:Label ID="lblCellphone" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                              
                                    </div>
                            </div>
                          
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Email" class="form-label">Email</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"  />
                                        <asp:Label ID="lblEmail" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                                        <p> </p>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                    <label for="gender" class="form-label">Genero: </label>

                                            <asp:RadioButtonList ID="rdbGender" runat="server" CssClass="form-control">
                                                <asp:ListItem Text="Masculino" Value="M" />
                                                <asp:ListItem Text="Femenino" Value="F" />
                                                <asp:ListItem Text="Otro" Value="O" Selected="True" />
                                            </asp:RadioButtonList>
                                        <asp:Label ID="lblGenero" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>

                              <div class="col-12 col-sm-4">
                                        <asp:Label runat="server" CssClass="col-form-label">Rol:</asp:Label>
                                        <asp:DropDownList ID="cmbGenero" runat="server" CssClass="form-control" placeholder="Rol">
                                            <asp:ListItem Text="Seleccione Rol" Value=""></asp:ListItem>
                                            <asp:ListItem Text="Administrador" Value="Administrador"></asp:ListItem>
                                            <asp:ListItem Text="Secretaria" Value="Secretaria"></asp:ListItem>
                                            <asp:ListItem Text="Director" Value="Director"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblGeneroError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    </div>
                                </div>
                                    </div>
                                        <div class="d-grid gap-2">
                                        </div>
                               
                            </div>
                        </div>

                  

                    <div class="card-footer bg-dark text-white">
                        <div class="d-grid gap-2">
                            <asp:Button runat="server" ID="btnRegister" Text="Modificar"  CssClass="btn btn-outline-success"  />
                            <a class="btn btn-outline-secondary" href="#">Cancel</a>
                        </div>
              </div>

          </div>
</form>
    <hr />
</asp:Content>
