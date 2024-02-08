<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="Quiz.Quiz1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://cdn.simplecss.org/simple.min.css">

    <title>Quiz</title>

    <style>
        body, html {
            height: 100%;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: start;
        }
        .centered {
            width: auto; /* adjust width as needed */
            min-width: 300px;
            text-align: center;
            margin-top: 10%;
            background-color: #f8f8f8;
            padding: 30px;
            box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;
        }
        td:hover {
            background-color: #ecf0f1;
            box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;
        }
    </style>
</head>
<body>
    <div class="centered">
     <form id="form1" runat="server">
        <div style="background-color: #f8f8f8;">
            <asp:Label ID="lblPergunta" runat="server" Text="Aqui vai a pergunta"></asp:Label><br />
            <asp:RadioButtonList style="width: 100%;" ID="rblAlternativas" runat="server"></asp:RadioButtonList>
            <asp:Button ID="btnProximo" runat="server" Text="Próximo" OnClick="btnProximo_Click" />
            <asp:Button ID="btnStartOver" runat="server" Visible="false" Text="Reiniciar" OnClick="btnStartOver_Click" />
            <asp:Label ID="lblResultado" runat="server" Visible="false"></asp:Label>
        </div>
    </form>
        </div>
</body>
</html>
