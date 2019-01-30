<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfConfig.aspx.cs" Inherits="CloverEVA.wfConfig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CloverEVA - Settings</title>
</head>
<body>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <div class="container">
    <h4>Visual Aids Setting</h4>
        <form id="form1" runat="server" class="form-horizontal">
            <div class="form-group">
                <label class="control-label col-sm-2">VA Host path:</label>
                <div class="col-sm-10">
                    <input id="txtDirect" type="text" class="form-control" runat="server" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <div class="checkbox">
                        <label><input id="chbLineUp" type="checkbox" runat="server" />Load VA from LineUp</label>
                    </div>
                </div>
            </div>
            <div class="form-group">        
                <div class="col-sm-offset-2 col-sm-10">                    
                    <asp:Button ID="Update" runat="server" Text="Save" CssClass="btn btn-primary btn-md" OnClick="Update_Click"/>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
