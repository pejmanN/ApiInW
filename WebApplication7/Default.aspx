<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="Scripts/Services/GetPersons.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <input type="button" value="Get Person List" onclick="PersonList()" style="margin-top: 25px; margin-left: 40px" />

            <div style="width: 100%; text-align: center; margin-left: 300px; visibility: hidden">
                <table id="persons" border='1'>
                    <tr style="width: 200px">
                        <td style="width: 200px"><b>Id</b></td>
                        <td style="width: 200px"><b>Name</b></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

