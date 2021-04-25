<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 1.aspx.cs" Inherits="Ejercicio_1.APP.Ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <input id="txtNombreTabla" type="text" runat="server" style="width: 150px; height: 20px; margin-top: 10px" placeholder="Nombre de la tabla.." />
                <asp:Button ID="btnCrearTabla" runat="server" Style="margin-left: 5px" Text="Crear tabla" OnClick="btnCrearTabla_Click" />
            </div>
            <div class="row">
                <label>No se puede repetir el nombre de las tablas</label>
            </div>
            <div class="row">
                <input id="txtColumna" type="text" runat="server" style="width: 150px; height: 20px; margin-top: 10px" placeholder="Nombre de la columna.." />
                <asp:Button ID="btnagregarcolumna" runat="server" Style="margin-left: 5px" Text="Añadir Columna" OnClick="btnAgregarColumna_Click" />
            </div>
            <div class="row">
                <label>Para agregar una columna debe tener el nombre de la tabla en la caja de texto arriba</label>
            </div>
            <div class="row" style="margin-top:60px">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>        
        </div>
    </form>
</body>
</html>
