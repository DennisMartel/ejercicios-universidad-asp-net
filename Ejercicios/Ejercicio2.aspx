<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Ejercicios.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculo de salario</title>
    <link rel="stylesheet" href="Content/Styles/ejercicio2.css" />
</head>
<body>
    <div class="page">
        <form id="form1" runat="server" class="form">
            <div>
                <label class="form-label" id="lbl_sueldo">Sueldo</label>
                <asp:TextBox ID="txt_sueldo" runat="server" Placeholder="Ingresa el sueldo del empleado" CssClass="form-input"></asp:TextBox>
                <asp:Button ID="btn_calcular" runat="server" Text="Calcular salario" CssClass="btn-calcular" OnClick="btn_calcular_Click" />
                <asp:Label ID="lbl_resultado" runat="server" CssClass="result" Visible="false"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
