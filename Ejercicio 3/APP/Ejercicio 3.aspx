<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 3.aspx.cs" Inherits="Ejercicio_3.APP.Ejercicio_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p>Pulse para guardar los datos de esta tabla en otra base de datos</p>
                <asp:Button ID="btnGuardarTabla" runat="server" Text="Guardar" OnClick="btnGuardarTabla_Click" />
            </div>
            <div style="margin-top: 50px;">
                <asp:Label ID="lblTabla1" runat="server" Text=""></asp:Label>
                <br />
                <asp:GridView ID="GridViewTabla1" runat="server" Width="1229px"></asp:GridView>
            </div>
            <div style="margin-top: 40px;">
                <asp:Label ID="lblTabla2" runat="server" Text=""></asp:Label>
                <br />
                <asp:GridView ID="GridViewTabla2" runat="server" Width="1229px"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
