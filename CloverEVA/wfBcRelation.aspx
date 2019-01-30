<%@ Page Title="BC - VA Relation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfBcRelation.aspx.cs" Inherits="CloverEVA.wfBcRelation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %></h2>
<div class="jumbotron">
    <div>
        <h3>Relation between BC - VA</h3>
        <table class="table"><tr>
            <td style="text-align:right"><asp:Label ID="Label1" runat="server" Text="BC :"></asp:Label></td>
            <td style="align-items:center"><asp:DropDownList ID="ddLine" runat="server" Width="150px" CssClass="dropdownlist dropdownlist-default" ></asp:DropDownList></td>
            <td><asp:Button ID="btLoad" runat="server" Text="Search" CssClass="btn btn-primary btn-md" OnClick="btLoad_Click" /></td>
            </tr>
        </table>
    </div>
</div>
<div class="row">
    <div class="container">
        <asp:GridView ID="gwData" runat="server" CssClass="Grid" Width="90%" HorizontalAlign="center" AutoGenerateColumns="False" DataKeyNames="modelo" AutoGenerateEditButton="True" OnDataBound="gwData_DataBound" OnRowCancelingEdit="gwData_RowCancelingEdit" OnRowDataBound="gwData_RowDataBound" OnRowEditing="gwData_RowEditing" OnRowUpdating="gwData_RowUpdating">
            <Columns>
                <asp:BoundField DataField="modelo" HeaderText="LayOut - Modelo" />
                <asp:BoundField DataField="descrip" HeaderText="Descripción" />
                <asp:BoundField DataField="tipo" HeaderText="CORE" />
                <asp:BoundField DataField="crc_conv" HeaderText="Estandar" />
                <asp:BoundField DataField="va_folder" HeaderText="Ubicación de Ayuda Visual" />
            </Columns>
        </asp:GridView>
    </div>
</div>
</asp:Content>
