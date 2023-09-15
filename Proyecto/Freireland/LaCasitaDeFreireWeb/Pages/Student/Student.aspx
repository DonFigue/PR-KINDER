<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="LaCasitaDeFreireWeb.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card text-black">
    <div class="card-header">
        <h3>Students</h3>
    </div>
    <div class="card-body">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>CI</th>
                    <th>FullName</th>
                    <th>Cod Student</th>
                    <th>Course</th>
                    <th><a href="/Pages/Student/StudentCreate.aspx" class="btn btn-outline-success">Add Student</a></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>8545633</td>
                    <td>Bradd Pitt</td>
                    <td>bpt8837261</td>
                    <td>Kinder A</td>
                    <td>
                        <div class="btn-group" role="group" aria-label="Basic outlined example">
                            <a class="btn btn-outline-success" href="#">Payments</a>&nbsp;
                            <a class="btn btn-outline-warning" href="/Pages/Student/StudentUpdate.aspx">Edit</a>&nbsp;
                            <a class="btn btn-outline-danger" asp-page="Delete">Delete</a>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>

    </div>
</div>
</asp:Content>
