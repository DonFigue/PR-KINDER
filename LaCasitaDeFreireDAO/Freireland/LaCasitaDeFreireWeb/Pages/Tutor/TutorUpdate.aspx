<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorUpdate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>Edit Tutor </h3>
        </div>
         <div class="card-body">
            <div>
                <div>
                    <form method="post">
                        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                       <div class="card-body">
                            <div class="row">
                                 <div class="col-md-6">
                                       <div class="form-group">
                                         <label for="FirstName" class="control-label">First Name</label>
                                         <input type="text" id="FirstName" name="FirstName" class="form-control" />
                                        </div>
                                  </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="LastName" class="control-label">Last Name</label>
                                            <input type="text" id="LastName" name="LastName" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="SecondLastName" class="control-label">Second Last Name</label>
                                            <input type="text" id="SecondLastName" name="SecondLastName" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Ci" class="control-label">CI</label>
                                            <input type="text" id="Ci" name="Ci" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Cellphone" class="control-label">Cellphone</label>
                                            <input type="text" id="Cellphone" name="Cellphone" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Address" class="control-label">Address</label>
                                            <input type="text" id="Address" name="Address" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Email" class="control-label">Email</label>
                                            <input type="text" id="Email" name="Email" class="form-control" />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="WorkPlace" class="control-label">WorkPlace</label>
                                            <input type="text" id="WorkPlace" name="WorkPlace" class="form-control" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="control-label">BirthDate</label>
                                            <input type="Date" id="BirthDate" name="EmaBirthDate" class="form-control" />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Profession" class="control-label">Profession</label>
                                            <input type="text" id="Profession" name="Profession" class="form-control" />
                                        </div>
                                     </div>
                                        <p> </p>
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
                                            <input type="text" id="PlaceBirth" name="PlaceBirth" class="form-control" />
                                        </div>
                                     </div>
                                  <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="nit" class="control-label">NIT</label>
                                            <input type="text" id="nit" name="nit" class="form-control" />
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="businessname" class="control-label">Business name</label>
                                            <input type="text" id="businessname" name="businessname" class="form-control" />
                                        </div>
                                     </div>
                                </div>
                                    </div>
                                        <div class="d-grid gap-2">
                                        </div>
                               </form>
                            </div>
                        </div>

                    </div>
        </div>
        <div class="card-footer bg-dark text-white">
            <div class="d-grid gap-2">
                <button class="btn btn-outline-warning" type="button">Save Changes</button>
                <a class="btn btn-outline-secondary" href="#">Cancel</a>
            </div>
        </div>
   
</asp:Content>
