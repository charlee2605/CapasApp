<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CapasApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        Prueba Ecuacion
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        y = (a)x^2 + b(x) + c
                    </td>
                </tr>
                <tr>
                    <td colspan=2>
                        Para resolver la ecuacion, indique solo el valor de x
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        Los valores de a, b y c provienen de la base de datos.
                    </td>
                </tr>
                <tr>
                    <td>
                        x =
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_x" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Bt_calcular" runat="server" Text="Calcular" OnClick="Bt_calcular_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        y =
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_y" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
