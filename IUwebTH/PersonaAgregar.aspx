<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonaAgregar.aspx.cs" Inherits="IUwebTH.PersonaAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INGRESO DE PERSONAS</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 371px;
            height: 126px;
        }
        .auto-style3 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style4 {
            color: #FF3300;
        }
        .auto-style5 {
            width: 371px;
            height: 26px;
            font-weight: bold;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 371px;
            font-weight: bold;
        }
        .auto-style8 {
            height: 126px;
        }
    </style>
</head>
<body style="height: 304px">
    <form id="form1" runat="server">
        <div class="auto-style3">
            <h2 class="auto-style4"><strong>INGRESO DE PERSONAS</strong></h2>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">&nbsp;Cédula</td>
                <td>
                    <asp:TextBox ID="txtCedula" runat="server" MaxLength="10" Width="279px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Apellidos</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtApellidos" runat="server" MaxLength="30" Width="278px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Nombres</td>
                <td>
                    <asp:TextBox ID="txtNombres" runat="server" MaxLength="30" Width="277px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Fecha de Nacimiento</td>
                <td>
                    <asp:TextBox ID="txtFechNacimiento" runat="server" MaxLength="10" Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Peso</td>
                <td>
                    <asp:TextBox ID="txtPeso" runat="server" MaxLength="7" Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblMensaje" runat="server" style="color: #3333CC"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR" />
                    <asp:LinkButton ID="LinkListarPersonas" runat="server" PostBackUrl="~/frmPersonas.aspx">Listar Personas</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
