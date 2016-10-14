<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TypeInference.aspx.cs" Inherits="TypeInference" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript" >

        function TypeInference() 
        {
            var x;
            x = document.getElementById("fieldName");
            // x is now an HTML element 
            alert(x.tagName);
            x = 10;
            // x is now an integer
            alert(x.toFixed());
            x = new Date();
            // x is now a date
            alert(x.getDay());
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
