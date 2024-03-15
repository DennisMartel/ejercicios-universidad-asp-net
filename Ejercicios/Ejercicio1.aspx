<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Ejercicios.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de descuento</title>
    <link rel="stylesheet" href="Content/Styles/ejercicio1.css" />
</head>
<body>
    <div class="page">
        <form id="form1" runat="server" class="form">
            <div>
                <label class="form-label" id="lbl_totalcompra">Total de la compra</label>
                <asp:TextBox ID="txt_totalcompra" runat="server" Placeholder="Ingresa el monto de la compra" CssClass="form-input"></asp:TextBox>
                <asp:Button ID="btn_calcular" runat="server" Text="Calcular descuento" CssClass="btn-calcular" OnClick="btn_calcular_Click" />
                <asp:Label ID="lbl_resultado" runat="server" CssClass="result" Visible="false"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
