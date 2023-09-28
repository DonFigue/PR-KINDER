<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorIndex.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Tutor.TutorIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <div class="row" style="padding-top: 20px;">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-header">
                        <h3 class="card-title">Lista de Padres</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class="card-body table-responsive p-0" style="height: 100%;">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="Ci" HeaderText="Ci" />
                                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button runat="server" Text="Editar" CommandName="EditRow" CommandArgument='<%# Eval("Codigo") %>' CssClass="btn btn-default btn-warning" />
                                        <asp:Button runat="server" Text="Eliminar" CommandName="DeleteRow" CommandArgument='<%# Eval("Codigo") %>' CssClass="btn btn-default btn-danger" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>
    </div>
</asp:Content>>
