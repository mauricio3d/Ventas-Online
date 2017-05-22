<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPresentacion.aspx.cs" Inherits="Servicios.WebFormPresentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="AccesoDatos.DOCENTE" InsertMethod="ingresarDocente" SelectMethod="seleccionarDocente" TypeName="WcfService1.Service1" UpdateMethod="actualizarDocente"></asp:ObjectDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="CODIGODOCENTE" HeaderText="CODIGODOCENTE" SortExpression="CODIGODOCENTE" />
                <asp:BoundField DataField="NOMBRESDOCENTE" HeaderText="NOMBRESDOCENTE" SortExpression="NOMBRESDOCENTE" />
                <asp:BoundField DataField="APELLIDOSDOCENTE" HeaderText="APELLIDOSDOCENTE" SortExpression="APELLIDOSDOCENTE" />
                <asp:BoundField DataField="CEDULADOCENTE" HeaderText="CEDULADOCENTE" SortExpression="CEDULADOCENTE" />
                <asp:BoundField DataField="TITULODOCENTE" HeaderText="TITULODOCENTE" SortExpression="TITULODOCENTE" />
            </Columns>
        </asp:GridView>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" OnPageIndexChanging="FormView1_PageIndexChanging">
            <EditItemTemplate>
                CODIGODOCENTE:
                <asp:TextBox ID="CODIGODOCENTETextBox" runat="server" Text='<%# Bind("CODIGODOCENTE") %>' />
                <br />
                NOMBRESDOCENTE:
                <asp:TextBox ID="NOMBRESDOCENTETextBox" runat="server" Text='<%# Bind("NOMBRESDOCENTE") %>' />
                <br />
                APELLIDOSDOCENTE:
                <asp:TextBox ID="APELLIDOSDOCENTETextBox" runat="server" Text='<%# Bind("APELLIDOSDOCENTE") %>' />
                <br />
                CEDULADOCENTE:
                <asp:TextBox ID="CEDULADOCENTETextBox" runat="server" Text='<%# Bind("CEDULADOCENTE") %>' />
                <br />
                TITULODOCENTE:
                <asp:TextBox ID="TITULODOCENTETextBox" runat="server" Text='<%# Bind("TITULODOCENTE") %>' />
                <br />
                
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                CODIGODOCENTE:
                <asp:TextBox ID="CODIGODOCENTETextBox" runat="server" Text='<%# Bind("CODIGODOCENTE") %>' />
                <br />
                NOMBRESDOCENTE:
                <asp:TextBox ID="NOMBRESDOCENTETextBox" runat="server" Text='<%# Bind("NOMBRESDOCENTE") %>' />
                <br />
                APELLIDOSDOCENTE:
                <asp:TextBox ID="APELLIDOSDOCENTETextBox" runat="server" Text='<%# Bind("APELLIDOSDOCENTE") %>' />
                <br />
                CEDULADOCENTE:
                <asp:TextBox ID="CEDULADOCENTETextBox" runat="server" Text='<%# Bind("CEDULADOCENTE") %>' />
                <br />
                TITULODOCENTE:
                <asp:TextBox ID="TITULODOCENTETextBox" runat="server" Text='<%# Bind("TITULODOCENTE") %>' />
                <br />
                
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                CODIGODOCENTE:
                <asp:Label ID="CODIGODOCENTELabel" runat="server" Text='<%# Bind("CODIGODOCENTE") %>' />
                <br />
                NOMBRESDOCENTE:
                <asp:Label ID="NOMBRESDOCENTELabel" runat="server" Text='<%# Bind("NOMBRESDOCENTE") %>' />
                <br />
                APELLIDOSDOCENTE:
                <asp:Label ID="APELLIDOSDOCENTELabel" runat="server" Text='<%# Bind("APELLIDOSDOCENTE") %>' />
                <br />
                CEDULADOCENTE:
                <asp:Label ID="CEDULADOCENTELabel" runat="server" Text='<%# Bind("CEDULADOCENTE") %>' />
                <br />
                TITULODOCENTE:
                <asp:Label ID="TITULODOCENTELabel" runat="server" Text='<%# Bind("TITULODOCENTE") %>' />
                <br />
                
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Buscar por Nombre de Docente<br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="BuscarDocente" TypeName="WcfService1.Service1">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox2" Name="codigoNombre" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="CODIGODOCENTE" HeaderText="CODIGODOCENTE" SortExpression="CODIGODOCENTE" />
                <asp:BoundField DataField="NOMBRESDOCENTE" HeaderText="NOMBRESDOCENTE" SortExpression="NOMBRESDOCENTE" />
                <asp:BoundField DataField="APELLIDOSDOCENTE" HeaderText="APELLIDOSDOCENTE" SortExpression="APELLIDOSDOCENTE" />
                <asp:BoundField DataField="CEDULADOCENTE" HeaderText="CEDULADOCENTE" SortExpression="CEDULADOCENTE" />
                <asp:BoundField DataField="TITULODOCENTE" HeaderText="TITULODOCENTE" SortExpression="TITULODOCENTE" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
