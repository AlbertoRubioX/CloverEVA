<%@ Page Title="CloverEVA - LineStation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CloverEVA.WebForm1" %>
    
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
<div class="jumbotron">
    <div>
        <h3>Configuración de Estaciones por Linea</h3>
        <table class="table"><tr>
            <td style="text-align:right"><asp:Label ID="Label1" runat="server" Text="Linea :"></asp:Label></td>
            <td style="align-items:center"><asp:DropDownList ID="ddLine" runat="server" Width="150px" CssClass="dropdownlist dropdownlist-default" OnSelectedIndexChanged="ddLine_SelectedIndexChanged" TabIndex="-1"></asp:DropDownList></td>
            <td><asp:Button ID="btLoad" runat="server" Text="Search" CssClass="btn btn-primary btn-md" OnClick="btLoad_Click" /></td>
            </tr>
        </table>
    </div>
</div>
<div class="container">
    <div>
        <asp:GridView ID="gvData" runat="server" Width="80%" HorizontalAlign="center" AutoGenerateColumns="False" CssClass="Grid" >
            <Columns>
                <asp:BoundField DataField="estacion" HeaderText="Estación" />
                <asp:BoundField DataField="area" HeaderText="Operación" />
                <asp:BoundField DataField="va_timelap" HeaderText="Duración" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <%--<a href="WinPopUp" onclick='openWindow("<%# Eval("estacion") %>");'>Editar</a>--%>
                        <a href="javascript:Openpopup('WinPopUp.aspx?Codigo=<%# Eval("estacion") %>')">Edit</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle CssClass="HeaderStyle" />

        </asp:GridView>
    </div>
</div>
<script type="text/javascript">
    function Openpopup(popurl)
    {
        winpops = window.open(popurl,"","width=500,height=500,menubar=no,directories=no")
    }
    function openWindow(code) {
        window.open('WinPopUp.aspx?Codigo='+code, 'popup_window', 'width=650', 'left=0', 'top=0');
    }
</script>
</asp:Content>
