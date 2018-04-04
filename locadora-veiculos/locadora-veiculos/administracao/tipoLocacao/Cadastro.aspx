<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="locadora_veiculos.administracao.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
     <link type="text/css" rel="stylesheet" href="../src/js/bootstrap.min.js" />
</head>
    <script src="../../scripts/js/jquery.min.js"> </script>
    <script src="../../scripts/js/bootstrap.min.js"> </script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
                <div class="row">
                    <h3 class="well"> Cadastro Tipo Locação</h3>
                    <br />
                    Tipo Locação: <br />
                    <asp:TextBox ID="txtNomeTipoLocacao" runat="server" Width="45%" CssClass="form-control" /> 
                    <asp:RequiredFieldValidator ID="requiredNomeTpLocacao" runat="server" ControlToValidate="txtNomeTipoLocacao" ErrorMessage="Campo Obrigatório" ForeColor="Red" />

                    Ativo: <br /> <!-- Corrigir depois -->
                    <asp:TextBox ID="TextBox1" runat="server" Width="45%" CssClass="form-control" /> 
                   
                    <br />

                    <p><asp:Label ID="lblMensagem" runat="server"/></p>

                     <asp:Button ID="btnCadastro" runat="server" Text="Gravar" CssClass="btn-primary btn-lg" OnClick="btnCadastrar" />

                     
    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
