<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cUsuarios.aspx.cs" Inherits="Form_HechoEnClases.Consultas.cUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Css/estilos.css" rel="stylesheet" />
</head>
<body>
    <div class="container" runat="server">
		<div class="form__top" runat="server">
			<h2>Consulta de <span>Usuarios</span></h2>
		</div>		
		<form class="form__reg" runat="server">
			<asp:Button ID="ButtonBuscar" runat="server" Text="BUSCAR" Width="63px" OnClick="ButtonBuscar_Click"/>
            
            <asp:TextBox  class="input" ID="FiltroTextBox" placeholder="¿ID o Descripcion?" runat="server" Width="154px"></asp:TextBox>
            <asp:TextBox class="input" ID="CriterioTextBox" placeholder="Metodo de busqueda" runat="server" Height="16px" Width="282px"></asp:TextBox>
           
            <asp:GridView ID="GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
		</form>
	</div>
</body>
</html>
