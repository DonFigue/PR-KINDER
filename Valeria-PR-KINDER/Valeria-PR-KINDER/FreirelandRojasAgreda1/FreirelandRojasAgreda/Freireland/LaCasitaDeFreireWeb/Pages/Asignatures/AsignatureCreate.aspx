﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsignatureCreate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Asignatures.AsignatureCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form runat="server" id="form"  method="post">
    <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>Materias</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                    <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                        <div class="row">
                             <div class="col-md-6">
                                <div class="form-group">
                                    <label for="txtCodeAsignature" class="form-label">Codigo Materia:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCodeAsignature"></asp:TextBox>
                                        <asp:Label ID="lblCodeAsignature" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="" class="form-label">Nombre Materia:</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNameAsignature"  />
                                        <asp:Label ID="lblNameAsignature" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                   
                                    </div>
                            </div>


                              <div class="col-12 col-sm-6">
                                        <asp:Label runat="server" CssClass="col-form-label">Area:</asp:Label>
                                        <asp:DropDownList ID="cmbArea" runat="server" CssClass="form-control"  AppendDataBoundItems="true">
                                           <asp:ListItem Text="" Value=""></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblAreaError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    </div>

                             <div class="col-12 col-sm-6">
                                        <asp:Label runat="server" CssClass="col-form-label">Curso:</asp:Label>
                                        <asp:DropDownList ID="cmbGrade" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                             <asp:ListItem Text="" Value=""></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblGrade" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    </div>
                                </div>
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
