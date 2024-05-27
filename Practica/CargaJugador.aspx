<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="CargaJugador.aspx.cs" Inherits="Practica.CargaJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Ocupado { get; set; }
        public bool Nacional { get; set; }--%>
    <style>
        .oculto {
            display: none;
        }
    </style>

    <div class="row">
        <h2><%=H2%></h2>
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id: </label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre completo: </label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion: </label>
                <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlEquipo" class="form-label">Equipo: </label>
                <asp:DropDownList CssClass="form-select " ID="ddlEquipo" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha: </label>
                <asp:TextBox ID="txtFecha" TextMode="Date" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtImagen" class="form-label">URL de imagen: </label>
                <asp:TextBox ID="txtImagen" TextMode="MultiLine" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <%--<label for="" class="form-label">Situacion: </label>--%>
                <asp:RadioButton CssClass="form-check-label" ID="rdbLesionado" Text="Lesionado" runat="server" GroupName="situacion" />
                <asp:RadioButton Checked="true" value="2024-05-20" CssClass="form-check-label" ID="rdbEnCondicion" Text="En condiciones" runat="server" GroupName="situacion" />
            </div>
            <div class="mb-3">
                <%--<label for="" class="form-label">Origen: </label>--%>
                <asp:RadioButton CssClass="form-check-label" ID="rdbNacional" Text="Nacional" runat="server" GroupName="origen" />
                <asp:RadioButton CssClass="form-check-label" Checked="true" ID="rdbExtrangero" Text="Extrangero" runat="server" GroupName="origen" />
            </div>
            <div class="mb-3">
                <a class="btn btn-secondary btn-lg" href="default.aspx">Cancelar</a>
                <asp:Button ID="btnCargar" CssClass="btn btn-secondary btn-lg" runat="server" Text="Agregar" OnClick="btnCargar_Click" />
                <asp:Button ID="btnModificar" CssClass="btn btn-secondary btn-lg" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" CssClass="btn btn-secondary btn-lg" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

            </div>

        </div>
        <div class="col-1">
        </div>
        <div class="col">
            <img src="https://images.vexels.com/media/users/3/135388/isolated/preview/06aa0409fcec1917923eb7f47de85a88-dibujos-animados-de-jugador-de-baloncesto.png" alt="Alternate Text" />
        </div>
    </div>

</asp:Content>
