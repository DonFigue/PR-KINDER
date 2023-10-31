<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insert_grade.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Grade.insert_grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="form">
     <div class="card bg-dark text-white">
        <div class="card-header text-center bg-success">
            <h3>Insertar Cursos</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                       <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="NameGrade" class="control-label">Nombre del curso:</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtGrade"  />
                                        <asp:Label ID="lblGradeError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                            
                                        </div>
                                    <div class="form-group">
                                        <label for="Price" class="control-label">Costo</label>
                                       <asp:TextBox runat="server" CssClass="form-control" ID="txtPrice"  />
                                    <asp:Label ID="lblPrice" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
    
                                    </div>

                                    </div>

                                 <div class="col-12 col-sm-4">
                                        <asp:Label runat="server" CssClass="col-form-label">Paralelo:</asp:Label>
                                        <asp:DropDownList ID="cmbParallel" runat="server" CssClass="form-control" placeholder="Paralelo">
                                            <asp:ListItem Text="Seleccione Paralelo" Value=""></asp:ListItem>
                                            <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                            <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                            <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblParallelError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                    </div>

                                 <div class="col-12 col-sm-4">
                                        <asp:Label runat="server" CssClass="col-form-label">Nivel:</asp:Label>
                                        <asp:DropDownList ID="cmbLevel" runat="server" CssClass="form-control" placeholder="Nivel">
                                            <asp:ListItem Text="Seleccione un Nivel" Value=""></asp:ListItem>
                                            <asp:ListItem Text="Inicial" Value="Inicial"></asp:ListItem>
                                            <asp:ListItem Text="Primaria" Value="Primaria"></asp:ListItem>
                                            <asp:ListItem Text="Secundaria" Value="Secundaria"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblLevelError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
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
                <asp:Button runat="server" ID="btnSave" Text="Registrar Curso" CssClass="btn btn-outline-success" OnClick="btnInsert_Click" />
                <a class="btn btn-outline-secondary" href="GradesIndex.aspx">Volver a la Lista</a>
            </div>
        </div>
   </form>
</asp:Content>
