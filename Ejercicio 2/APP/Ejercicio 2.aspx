<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 2.aspx.cs" Inherits="Ejercicio_2.APP.Ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="txtcomando" runat="server" style="width: 400px; height: 100px; margin-left: 500px; margin-top: 100px; margin-bottom: 50px" placeholder="Digite el query..." />
            <asp:Button ID="btnEjecutar" Style="background-color: cadetblue; width: 100px; height: 40px;" runat="server" Text="Ejecutar" OnClick="btnEjecutar_Click" />
            <div style="display: block">
                <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
