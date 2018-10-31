<%@ Page Title="Alunos" Language="C#" AutoEventWireup="true" CodeFile="Table.aspx.cs" Inherits="Table" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Content/bootstrap.css" rel="stylesheet">
    <style>
        div.ex1 {
            padding: 45px;
        }

        div.ex2 {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
        <div class="ex2">
            <center>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Refresh" class="btn btn-primary" type="button"/>      
           </center>
        </div>
        <div class="ex1">
            <center>       
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Groove" Direction="LeftToRight" Height="500px" Width="250px">

            <div>
            <form>
                <div class="form-group">
                    <label for="exampleFormControlInput1">NOME</label>
                    <textarea class="form-control" id="TextAreaNOME" cols="20" rows="2" runat="server" placeholder="NOME"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">IDADE</label>
                    <textarea class="form-control" id="TextAreaIDADE" cols="10" rows="1" type="text" runat="server" placeholder="IDADE"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">TELEFONE CONTATO</label>
                    <textarea class="form-control" id="TextAreaTELEFONE" cols="10" rows="1" type="text" runat="server" placeholder="TELEFONE CONTATO"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlTextarea1">ENDEREÇO</label>
                    <textarea class="form-control" id="TextAreaENDERECO" cols="20" rows="3" runat="server" placeholder="ENDEREÇO"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">DATA NASCIMENTO</label>
                    <textarea class="form-control" id="TextAreaDATA" cols="10" rows="1" type="text" runat="server" placeholder="DATA NASCIMENTO"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">CPF</label>
                    <textarea class="form-control" id="TextAreaCPF" cols="10" rows="1" type="text" runat="server" placeholder="CPF"></textarea>
                </div>                 
            </form>               
        </div>
        </asp:Panel>
                 <div class="ex2">           
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Salvar" class="btn btn-success" type="button"/>
        </div>
            </center>
        </div>
       
        <div class="ex1">
            <center>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">back default page</asp:HyperLink>
             </center>
        </div>
    </form>
</body>
</html>
