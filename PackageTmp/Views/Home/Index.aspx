<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Fábio Santos</title>
    <script src="../../Scripts/jquery-1.5.1.min.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {
            $("#btnCheck").click(function () {
                $.ajax({
                    url: "Home/CheckString",
                    method: "POST",
                    data: { str: $("#str").val() },
                    success: function (data) {
                        $("#result").html(data);
                    }
                });
            });
        });
    </script>
</head>
<body>
    <div>
        <h1>Digite a String:<input type="text" id="str" name="str"/><input type="button" id="btnCheck" /></h1>
    </div>
    <div id="result"></div>
</body>
</html>
