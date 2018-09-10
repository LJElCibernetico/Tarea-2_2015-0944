<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="Form_HechoEnClases.Registros.rUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Css/estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="container" runat="server">
		<div class="form__top" runat="server">
			<h2>Registro de <span>Usuarios</span></h2>
		</div>		
		<form class="form__reg" runat="server">
			<asp:Button ID="ButtonBuscar" runat="server" Text="BUSCAR" Width="63px" OnClick="ButtonBuscar_Click1"/>
            
            <asp:TextBox  class="input" ID="TextBoxID" placeholder="ID" runat="server" Width="30px"></asp:TextBox>
            
            <asp:TextBox class="input" ID="TextBoxUsername" placeholder="Username" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxPassword" placeholder="Password" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxConfirmacion" placeholder="Confirmacion" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxFecha" placeholder="Fecha" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxComentario" placeholder="Comentario" runat="server"></asp:TextBox>
            <div class="btn__form" runat="server">
                <asp:Button ID="ButtonNuevo" type="submit" runat="server" Text="NUEVO" OnClick="ButtonNuevo_Click"/>
                <asp:Button ID="ButtonGuardar" type="submit" runat="server" Text="GUARDAR" OnClick="ButtonGuardar_Click"/>
                <asp:Button ID="ButtonEliminar" type="submit" runat="server" Text="ELIMINAR" OnClick="ButtonEliminar_Click"/>
            </div>
		</form>
	</div>
</body>
</html>
