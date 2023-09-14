<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentCreate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Student.StudentCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class=" card bg-dark text-white">
        <div class="card-header">
            <h3>New Student</h3>
        </div>
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
                                         <label for="Course" class="control-label">Course</label>
                                        <p></p>
                                        
                                        <select name="Course" id="Course">
                                            <option value="nidito">Nidito</option>
                                            <option value="preKindeA">Pre Kinder A</option>
                                            <option value="preKindeB">Pre Kinder B</option>

                                            <option value="kinderA">Kinder A</option>
                                            <option value="kinderB">Kinder B</option>

                                        </select>
                                            

                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Discapacity" class="control-label">Discapacity</label>
                                            <input type="text" id="Discapacity" name="Discapacity" class="form-control" />
                                        </div>
                                    </div>

                                      <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="control-label">BirthDate</label>
                                            <input type="Date" id="BirthDate" name="BirthDate" class="form-control" />
                                        </div>
                                    </div>

                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="codStudent" class="control-label">codStudent</label>
                                            <input type="text" id="codStudent" name="codStudent" class="form-control" />
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
                                
                                 
                                </div>
                                    </div>

        </div>
        <div class="card-footer bg-dark text-white">
            <div class="d-grid gap-2">
                <button class="btn btn-outline-success" type="button">Register</button>
                <a class="btn btn-outline-secondary" href="Index.aspx">Cancel</a>
            </div>
        </div>
   
    <hr />
</asp:Content>

