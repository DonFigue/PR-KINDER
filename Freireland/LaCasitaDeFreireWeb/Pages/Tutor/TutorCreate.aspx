﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorCreate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="form"  method="post">
    <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>New Tutor</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                    <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="txtFirstName" class="form-label">First Name</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                        <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="LastName" class="form-label">Last Name</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                        <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="SecondLastName" class="form-label">Second Last Name</label>
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
                                    <label for="Cellphone" class="form-label">Cellphone</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCellphone"  />
                                        <asp:Label ID="lblCellphone" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                              
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Address" class="form-label">Address</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress"  />
                                        <asp:Label ID="lblAddress" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                              
                                    </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="Email" class="form-label">Email</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"  />
                                        <asp:Label ID="lblEmail" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                               
                                    </div>
                            </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="WorkPlace" class="form-label">WorkPlace</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtWorkPlace"  />
                                        <asp:Label ID="lblWorkPlace" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                        
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="form-label">BirthDate</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBirthDate" TextMode="Date"  />
                                        <asp:Label ID="lblBirthdate" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Profession" class="form-label">Profession</label>
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
                                            <label for="PlaceBirth" class="form-label">Place of Birth</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtPlaceOfBirth"  />
                                        <asp:Label ID="lblPlaceBirth" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                     </div>
                                  <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="nit" class="form-label">NIT</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtNIT"  />
                                        <asp:Label ID="lblNit" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                      
                                            </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="txtBusinessName" class="form-label">Business name</label>
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

                  

                    <div class="card-footer bg-dark text-white">
                        <div class="d-grid gap-2">
                            <asp:Button runat="server" ID="btnRegister" Text="Register"  CssClass="btn btn-outline-success" OnClick="btnRegister_Click" />
                            <a class="btn btn-outline-secondary" href="#">Cancel</a>
                        </div>
              </div>

          </div>
</form>
    <hr />
</asp:Content>
