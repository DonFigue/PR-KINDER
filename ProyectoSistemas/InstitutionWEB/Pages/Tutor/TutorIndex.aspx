<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorIndex.aspx.cs" Inherits="InstitutionWEB.Pages.Tutor.TutorIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
    .scrollable-grid {
        max-height: 400px; 
        overflow-y: scroll;
    }
    .white-table {
    background-color: #ffffff !important; 
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <br />
        <div class="mx-auto" style="width:300px">
            <h2>Lista de Tutores</h2>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col aling-self-end">
                    <asp:Button runat="server" ID="btnCreate" CssClass="btn btn-primary form-control" Text="Nuevo Tutor" Onclick="btnCreate_Click"/>
                </div>
            </div>
        </div>
        <br />
        <div class="container row">
            <div class="table small">
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
                <div class="scrollable-grid">
                <asp:GridView runat="server" ID="gvTutor" class="table table-head-fixed text-nowrap white-table" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="CODE" HeaderText="Codigo"/>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Ci" HeaderText="Ci" />
                        <asp:BoundField DataField="Dirección" HeaderText="Direccion" />
                        <asp:TemplateField HeaderText="Opciones">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="Info" CssClass="btn form-control-sm btn-info" ID="btnRead" OnClick="btnRead_Click" />
                                <asp:Button runat="server" Text="Editar" CssClass="btn form-control-sm btn-info" ID="btnUpdate" OnClick="btnUpdate_Click" />
                                <asp:Button runat="server" Text="Eliminar" CssClass="btn form-control-sm btn-info" ID="btnDelete" OnClick="btnDelete_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
