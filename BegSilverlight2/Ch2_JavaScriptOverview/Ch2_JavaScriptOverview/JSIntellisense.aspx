<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JSIntellisense.aspx.cs" Inherits="Ch2_JavaScriptOverview.JSIntellisense" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script src="HelloWorld.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        function load() {
            var message = HelloWorld("Bob", "Lair");
            alert(message);
        }
    </script>

</head>
<body onload="load()">
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
