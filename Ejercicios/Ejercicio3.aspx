<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="Ejercicios.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>calculo de descuento basado en cantidad de articulos</title>
    <link rel="stylesheet" href="Content/Styles/ejercicio3.css" />
</head>
<body>
    <div class="page">
        <form id="form1" runat="server" class="form">
            <div>
                <p>El precio de cada articulo es de $10.00</p>
                <br />
                <label class="form-label" id="lbl_cantidad">Ingresa la cantidad de articulos</label>
                <asp:TextBox ID="txt_cantidad" runat="server" Placeholder="Ingresa la cantidad de articulos" CssClass="form-input"></asp:TextBox>
                <asp:Button ID="btn_calcular" runat="server" Text="Calcular descuento" CssClass="btn-calcular" OnClick="btn_calcular_Click" />
                <asp:Label ID="lbl_resultado" runat="server" CssClass="result" Visible="false"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
