<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WinPopUp.aspx.cs" Inherits="CloverEVA.WinPopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Line Station Config</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
<h4>Editar Estación</h4>
<div class="jumbotron" width="80%">
    <form id="form1" runat="server" class="form-horizontal">
         <div class="form-group">
            <label class="control-label col-sm-2">Planta: </label>
            <input runat="server" class="form-control" type="text" name="planta" id="planta" readonly="true"/>
        </div>
        <div class="form-group">
            <label class="control-label col-sm-2">Linea: </label>
            <input runat="server" class="form-control" type="text" name="txtLinea" id="linea" readonly="true"/>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Estación :" Width="65px" CssClass="control-label col-sm-2"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtName" runat="server" Width="250px" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Operación :" Width="100px" CssClass="control-label col-sm-2"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCant1" runat="server" Width="100px" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Label ID="Label4" runat="server" Text="Duración :" Width="80px" CssClass="control-label col-sm-2"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCant2" runat="server" Width="100px" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">        
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="Update" runat="server" Text="Save" CssClass="btn btn-primary btn-md" OnClick="Update_Click"/>
            </div>
        </div>
    </form>
</div>
</div>
</body>
</html>
