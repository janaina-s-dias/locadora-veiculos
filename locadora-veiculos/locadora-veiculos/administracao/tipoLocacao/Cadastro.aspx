<%@ Page Language="C#"  MasterPageFile="~/Cabecalho.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="locadora_veiculos.administracao.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server"> 
    <title>Cadastro</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
      
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
                <div class="row">
                    <h3 class="well"> Cadastro Tipo Locação</h3>
                    <br />
                    Nome: <br />
                    <asp:TextBox ID="txtNomeTipoLocacao" runat="server" Width="45%" CssClass="form-control" /> 
                    <%--<asp:RequiredFieldValidator ID="requiredNomeTpLocacao" runat="server" ControlToValidate="txtNomeTipoLocacao" ErrorMessage="Campo Obrigatório" ForeColor="Red" />--%>
                     
             
                  <%--  Ativo: <br /> <!-- Corrigir depois -->
                    <asp:TextBox ID="TextBox1" runat="server" Width="45%" CssClass="form-control" /> --%>
                   
                    <br />

                    <p><asp:Label ID="lblMensagem" runat="server"/></p>

                     <asp:Button ID="btnCadastro" runat="server" Text="Gravar" CssClass="btn-primary btn-lg" OnClick="btnCadastrar" />

                     
    
                </div>
            </div>
        </div>
    </form>
   </asp:Content>
