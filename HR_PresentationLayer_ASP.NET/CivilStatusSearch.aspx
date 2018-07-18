<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CivilStatusSearch.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CivilStatusSearch" %>

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
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css"/>
  
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js"></script>

    <script>
        $(function () {
            $("#gvcivilStatus").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>

    </head>
<body>
       <form id="form1" runat="server">
          <center><div style="width:80%">
 <asp:GridView ID="gvcivilStatus" runat="server" AutoGenerateColumns="False" DataKeyNames="StatusId" DataSourceID="SqlDataSource2">
     <Columns>
         <asp:BoundField DataField="StatusId" HeaderText="StatusId" InsertVisible="False" ReadOnly="True" SortExpression="StatusId" />
         <asp:BoundField DataField="StatusDescription" HeaderText="StatusDescription" SortExpression="StatusDescription" />
     </Columns>

 </asp:GridView>
    
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:myConnection %>" SelectCommand="SELECT StatusId, StatusDescription FROM balaji.CivilStatus_HR_Batch4"></asp:SqlDataSource>
              <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
    </div>
    </center>
        </form>
</body>
</html>
