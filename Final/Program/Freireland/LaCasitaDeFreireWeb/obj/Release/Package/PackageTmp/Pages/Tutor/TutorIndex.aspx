<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorIndex.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card  text-black">
    <div class="card-header text-center bg-info">
        <h3>Tutores</h3>
        <form runat="server" id="search">
            <asp:TextBox runat="server" ID="txtSearch" CssClass="form-control" style="display: inline-block; width: auto;" />
            <asp:Button runat="server" ID="btnSearch" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" style="display: inline-block; margin-left: 10px;" />
        </form>
    </div>
    <div ID="divTable" runat="server" class="card-body">
        
    </div>
</div>



</asp:Content>
