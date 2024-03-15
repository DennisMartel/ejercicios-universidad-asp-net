<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio7.aspx.cs" Inherits="Ejercicios.Ejercicio7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de multiplicar con botones</title>
    <link rel="stylesheet" href="Content/Styles/ejercicio7.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="CrearTabla" runat="server"></asp:Table>
            <asp:Label ID="lbl_tablaSeleccionada" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
