<%@ Page Title="Alunos" Language="C#" AutoEventWireup="true" CodeFile="Table.aspx.cs" Inherits="Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Content/bootstrap.css" rel="stylesheet">
    <style>
        div.ex1 {
            padding: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>

        <div class="ex1">
            <center>       
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Groove" Direction="LeftToRight" Height="500px" Width="250px">

            <div>
            <form>
                <div class="form-group">
                    <label for="exampleFormControlInput1">NOME</label>
                    <textarea class="form-control" id="exampleFormControlInput1" placeholder="NOME"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">IDADE</label>
                    <input class="form-control form-control-sm" id="IDADEinput" type="text" placeholder="IDADE">
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">TELEFONE CONTATO</label>
                    <input class="form-control form-control-sm" id="TELEFONEinput" type="text" placeholder="TELEFONE CONTATO">
                </div>
                <div class="form-group">
                    <label for="exampleFormControlTextarea1">ENDEREÇO</label>
                    <textarea class="form-control" id="ENDERECOtextarea" rows="3" placeholder="ENDEREÇO"></textarea>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">DATA NASCIMENTO</label>
                    <input class="form-control form-control-sm" id="DATAinput" type="text" placeholder="DATA NASCIMENTO">
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">CPF</label>
                    <input class="form-control form-control-sm" id="CPFinput" type="text" placeholder="CPF">
                </div>
                 <div class="form-group">
                    <button type="button" class="btn btn-success" id="BOTAOSuccess">Salvar</button>
                </div>
            </form>
        </div>



        </asp:Panel>
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
