<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notas.aspx.cs" Inherits="Ejercicios.notas" %>

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
                    <thead>
                        <tr>
                            <td>Evaluación</td>
                            <td>Nota</td>
                            <td>Porcentaje</td>
                            <td>Puntos Ganados</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>E1</td>
                            <td><%= Session["nota1"]%></td>
                            <td><%= Session["porcentaje"]%></td>
                            <td><%= Session["puntosE1"]%></td>
                        </tr>
                        <tr>
                            <td>E2</td>
                            <td><%= Session["nota2"]%></td>
                            <td><%= Session["porcentaje"]%></td>
                            <td><%= Session["puntosE2"]%></td>
                        </tr>
                        <tr>
                            <td>E3</td>
                            <td><%= Session["nota3"]%></td>
                            <td><%= Session["porcentaje"]%></td>
                            <td><%= Session["puntosE3"]%></td>
                        </tr>
                        <tr>
                            <td>E4</td>
                            <td><%= Session["nota4"]%></td>
                            <td><%= Session["porcentaje"]%></td>
                            <td><%= Session["puntosE4"]%></td>
                        </tr>
                        <tr>
                            <td>E5</td>
                            <td><%= Session["nota5"]%></td>
                            <td><%= Session["porcentaje"]%></td>
                            <td><%= Session["puntosE5"]%></td>
                        </tr>
                        <tr>
                            <td colspan="3">Nota final <%= Session["notaFinal"] %></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </form>
    </div>
</body>
</html>
