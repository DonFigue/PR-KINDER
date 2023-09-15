<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="form">
     <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>Edit Tutor </h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                       <div class="card-body">
                            <div class="row">
                                 <div class="col-md-6">
                                       <div class="form-group">
                                         <label for="FirstName" class="control-label">First Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                        </div>
                                  </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="LastName" class="control-label">Last Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="SecondLastName" class="control-label">Second Last Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Ci" class="control-label">CI</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtCI"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Cellphone" class="control-label">Cellphone</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtCellphone"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Address" class="control-label">Address</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Email" class="control-label">Email</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"  />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="WorkPlace" class="control-label">WorkPlace</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtWorkPlace"  />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="control-label">BirthDate</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBirthDate" TextMode="Date"  />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Profession" class="control-label">Profession</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtProfession"  />
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
                                        </div>
                                    </div>
                                 <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="PlaceBirth" class="control-label">Place of Birth</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtPlaceOfBirth"  />
                                        </div>
                                     </div>
                                  <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="nit" class="control-label">NIT</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtNIT"  />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="txtBusinessName" class="control-label">Business name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBusinessName"  />
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
                <a class="btn btn-outline-secondary" href="#">Cancel</a>
            </div>
        </div>
   </form>
</asp:Content>
