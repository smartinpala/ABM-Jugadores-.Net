<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .oculto{
            display:none;
        }
    </style>


    <h4>Lista de jugadores</h4>
    <br />
    <div class="row">
        <div class="col">
            <asp:GridView DataKeyNames="Id" OnSelectedIndexChanged="dgvJudaores_SelectedIndexChanged" ID="dgvJugadores" runat="server" CssClass="table table-dark table-hover table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <%--<asp:BoundField HeaderText="ID de jugador" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>--%>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Equipo" DataField="Equipo" />
                    <asp:CheckBoxField HeaderText="Lesionado" DataField="Lesionado" />
                    <asp:CheckBoxField HeaderText="Nacional" DataField="Nacional" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion"/>
                </Columns>
            </asp:GridView>
            <a Class="btn btn-secondary btn-sm" href="CargaJugador.aspx">Cargar jugador</a>
        </div>
    </div>

</asp:Content>
