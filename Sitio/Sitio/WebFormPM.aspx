<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="WebFormPM.aspx.cs" Inherits="Sitio.WebFormPM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!-- --------------- AQUI EMPIEZA MI CODIGO ---------   -->
    <asp:Panel ID="Panel1" Width ="100% " runat="server" GroupingText="Mantenimiento Tabla Proveedor">
        <table style="margin-left:10% ">
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay resultados"
                        PageSize="20" AutoGenerateSelectButton="true" DataKeyNames="Suc_ID" OnSelectedIndexChanged="Grid_View1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField ="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField ="Apellido1" HeaderText="Apellido1" />
                            <asp:BoundField DataField ="Apellido2" HeaderText="Apellido2" />

                        </Columns>
                        <SelectedRowStyle CssClass="GridViewSelectedRowStyle" BackColor="#CFEEFF" Font-Bold="true" />
                    </asp:GridView> 
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Seleccione una accion"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Text="Seleccione" Value="Seleccione"></asp:ListItem>
                        <asp:ListItem Text="InsertarTrabajador" Value="Insertar"></asp:ListItem>
                        <asp:ListItem Text="ModificarTrabajador" Value="Modificar"></asp:ListItem>
                        <asp:ListItem Text="EliminarTrabajador" Value="Eliminar"></asp:ListItem>
                        <asp:ListItem Text="SeleccioneProveedor" Value="Seleccione"></asp:ListItem>
                        <asp:ListItem Text="InsertarProveedor" Value="Insertar"></asp:ListItem>
                        <asp:ListItem Text="ModificarProveedor" Value="Modificar"></asp:ListItem>
                        <asp:ListItem Text="EliminarProveedor" Value="Eliminar"></asp:ListItem>
                     </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Apellido1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txApellido1" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Apellido2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txApellido2" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Cedula"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txcedula" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Telefono"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="Ejecutar" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Label ID="lbExito" runat="server" Text =" " ForeColor="Green" Visible="false"></asp:Label>
                    <asp:Label ID="lbError" runat="server" Text =" " ForeColor="Red" Visible="false"></asp:Label>
                </td>
            </tr> 
        </table>

</asp:Panel>
   </asp:Content>
 
