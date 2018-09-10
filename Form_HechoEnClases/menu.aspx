<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Form_HechoEnClases.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet"/> 
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css"/>
    <link rel="stylesheet" href="../../Css/estilos.css"/>
</head>
<body>
    <div class="menu">
        <div class="container-execute">
            <iframe src="#" name="execute"></iframe>
        </div>
    
        <div class="contenedor-menu">
            <a href="#" class="btn-menu"> Menu <i class="icono fa fa-bars"></i></a>
            
            <div class="slogan">
                <img src="../images/POKEMONEDA.png" class="imagen"/>
                <h2>LJ & Asociados</h2>
                <h3>Sistema de Almacen</h3>
            </div>
            
            <ul class = "menu"> 
                <li><a href="#"><i class="icono izquierda fas fa-file-signature"></i>Registros<i class="icono derecha fa fa-chevron-down"></i></a>
                    <ul>
                        <li><a href="Registros/rUsuarios.aspx">Usuarios</a></li>
                    </ul>
                </li>
                <li><a href="#"><i class="icono izquierda fas fa-file-export"></i>Consultas<i class="icono derecha fa fa-chevron-down"></i></a>
                     <ul>
                        <li><a href="Consultas/cUsuarios.aspx">Usuarios</a></li>
                    </ul>
                </li>
                <li><a href="#"><i class="icono izquierda fas fa-wrench"></i>Opciones<i class="icono derecha fa fa-chevron-down"></i></a>
                    <ul>
                        <li><a href="#">Cerrar Sesion</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
    

    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="../js/main.js"> </script>
</body>
</html>
