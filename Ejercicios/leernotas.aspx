<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leernotas.aspx.cs" Inherits="Ejercicios.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="display: grid; place-items: center; height: 100vh">
        <form id="form1" runat="server">
            <div>
                <table cellpadding="3" cellspacing="3" border="1">
                    <tr>
                        <td>
                            <label>Alumnno: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_alumno" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>E1: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_e1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>E2: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_e2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>E3: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_e3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>E4: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_e4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>E5: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_e5" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btn_calcularNota" runat="server" Text="Calcular" OnClick="btn_calcularNota_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </div>
</body>
</html>
