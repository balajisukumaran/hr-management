<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta name = "viewport" content = "width = device-width, initial-scale = 1"/>      
      <link rel = "stylesheet"
         href = "https://fonts.googleapis.com/icon?family=Material+Icons"/>
      <link rel = "stylesheet"
         href = "https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.3/css/materialize.min.css"/>
      <script type = "text/javascript"
         src = "https://code.jquery.com/jquery-2.1.1.min.js"></script>           
      <script src = "https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.3/js/materialize.min.js">
      </script>
    <script>
        $('.button-collapse').sideNav({
            menuWidth: 300,
            closeOnClick: true,
            edge: 'right', // <--- CHECK THIS OUT
        }
          );
        $('.collapsible').collapsible();
</script>   
</head>
<body>
    <form id="form1" runat="server">
   
   <div>
            <nav>
    <div class="nav-wrapper indigo darken-4">
      <a href="#" class="brand-logo"> Stark Industries</a>
      <ul id="nav-mobile" class="right hide-on-med-and-down">
       
      <li> 
          <asp:HyperLink ID="btnAdmin" runat="server" Text="Admin" NavigateUrl="~/AdminLogin.aspx" ></asp:HyperLink>

      </li>
      <li>
          <asp:HyperLink ID="btnHrClerk" runat="server" Text="HRClerk" NavigateUrl="~/HRClerkLogin.aspx" ></asp:HyperLink>
      </li>
              
      </ul>
    </div>
  </nav>
   </div>
    
        
    </form>
</body>
</html>
