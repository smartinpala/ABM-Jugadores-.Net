<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="MostrarJugadores.aspx.cs" Inherits="Practica.MostrarJugadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Jugadores de la liga nacional</h1>
    <hr />
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (dominio.Jugador j in ListaJugadores)
            {%>
            <div class="col">
                <div class="card">
                    <img src="<%:j.Imagen %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%:j.Nombre %> (<%:j.Equipo %>)</h5>
                        <p class="card-text"><%:j.Descripcion %></p>
                    </div>
                </div>
            </div>
        <%} %>
    </div>
</asp:Content>
