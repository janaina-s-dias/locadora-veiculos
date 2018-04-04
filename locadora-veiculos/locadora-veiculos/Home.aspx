<%@ Page Language="C#" MasterPageFile="~/Cabecalho.Master"  AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="locadora_veiculos.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server"> 
    <title>Página Inicial</title>
</asp:Content>
 

 <asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
       <form id="form1" runat="server">
        <div class="jumbotrom">
           <%-- <h2>Locadora de Veículos</h2>--%>

        
             Escolha a opção desejada: 
             <asp:DropDownList ID="ddlMenu" runat="server">
                 <asp:ListItem Value="0" Text="Escolha uma opção" />
                 <asp:ListItem Value="1" Text="Cadastrar Tipo Locação" />
                 <asp:ListItem Value="2" Text="Consultar Tipo Locação" />

             </asp:DropDownList>

            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn-primary btn-sm" OnClick="btnAcessar" />

           <p><asp:Label ID="lblMensagem" runat="server"/></p>
    
        </div>
        </form>
    
    </asp:Content>