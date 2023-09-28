<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="LaCasitaDeFreireWeb.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card text-black">
    <div class="card-header">
        <h3>Students</h3>
    </div>
       <%-- <form runat="server">
        <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="input-group">
                                <asp:TextBox runat="server" ID="txtSearch" CssClass="form-control" placeholder="Buscar tutor por nombre" />
                                <span class="input-group-btn">
                                    <asp:Button runat="server" ID="btnSearch" Text="Buscar" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </form>--%>
    <div ID="divTable" runat="server" class="card-body">
        
    </div>
</div>
</asp:Content>
