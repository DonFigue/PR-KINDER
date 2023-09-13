<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorIndex.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card  text-black">
    <div class="card-header">
        <h3>Tutors</h3>
    </div>
    <div class="card-body">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>CI</th>
                    <th>FullName</th>
                    <th>Cellphone</th>
                    <th>Address</th>
                    <th>Nit</th>
                    <th>Bussines Name</th>
                    <th><a href="/Pages/Tutor/TutorCreate.aspx" class="btn btn-outline-success">Add Tutor</a></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>8545633</td>
                    <td>Bradd Pitt</td>
                    <td>65498711</td>
                    <td>Av. Villazon</td>
                    <td>36271168</td>
                    <td>Pitt</td>
                    <td>
                        <div class="btn-group" role="group" aria-label="Basic outlined example">
                            <a class="btn btn-outline-success" href="/Pages/Student/StudentCreate.aspx">New Student</a>&nbsp;

                            <a class="btn btn-outline-warning" href="/Pages/Tutor/TutorUpdate.aspx">Edit</a>&nbsp;
                            <a class="btn btn-outline-danger" asp-page="Delete">Delete</a>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>

    </div>
</div>
</asp:Content>
