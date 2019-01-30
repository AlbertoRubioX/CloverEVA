<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CloverEVA._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Clover Manufacturing Viewer</h1>
        <p class="lead">Electronic VIsual Aids solution. Load the VA you need in each one stations of Lines.</p>
        <p><a href="WebForm1" class="btn btn-primary btn-lg">Visual Aids &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>VA Settings</h2>
            <p>
                You can easily configurate the visual aid parameters.
            </p>
            <p>
                <a class="btn btn-default" href="javascript:Openpopup('wfConfig.aspx')">Settings &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>BC - VA Relation</h2>
            <p>
                Relate between models and visual aids.
            </p>
            <p>
                <a class="btn btn-default" href="wfBcRelation">Relation &raquo;</a>
            </p>
        </div>
        <%--<div class="col-md-4">
            <h2>CDMS Documents</h2>
            <p>
                Access to VA documents.
            </p>
            <p>
                <a class="btn btn-default" href="http://cloverconnect.clovertech.com/cdms1/Pages/VAMfgEng.aspx">CDMS &raquo;</a>
            </p>
        </div>--%>
    </div>

<script type="text/javascript">
    function Openpopup(popurl)
    {
        winpops = window.open(popurl,"","width=500,height=300,menubar=no,directories=no")
    }
    function openNewWindows() {
        window.open("");
    }
</script>
</asp:Content>
