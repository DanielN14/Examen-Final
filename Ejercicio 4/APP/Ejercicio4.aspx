<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="Ejercicio_4.APP.Ejercicio4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <select id="selectBaseDatos" runat="server" style="width: 20rem;">
                <option disabled="disabled" selected="selected">Seleccione una base de datos</option>
                <option value="Reservar">Reservar</option>
                <option value="Libreria">Libreria</option>
            </select>
            <asp:Button ID="btnCambioBaseDatos" runat="server" Text="Cambiar de base de datos y mostrar tabla" OnClick="btnCambioBaseDatos_Click" />
        </div>
        <div style="margin-top: 50px;">
            <asp:GridView ID="GridView" runat="server" Width="1229px"></asp:GridView>
        </div>
    </form>
</body>
</html>
