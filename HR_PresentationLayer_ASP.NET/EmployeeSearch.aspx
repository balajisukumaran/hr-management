<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.EmployeeSearch" %>

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
            $("#gvEmployee").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>

    </head>
<body>
       <form id="form1" runat="server">
          <center><div style="width:80%">
 <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource2">
     <Columns>
         <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
         <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
         <asp:BoundField DataField="MiddleName" HeaderText="MiddleName" SortExpression="MiddleName" />
         <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
         <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
         <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
         <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
         <asp:BoundField DataField="CivilStatusId" HeaderText="CivilStatusId" SortExpression="CivilStatusId" />
         <asp:BoundField DataField="Religion" HeaderText="Religion" SortExpression="Religion" />
         <asp:BoundField DataField="Citizenship" HeaderText="Citizenship" SortExpression="Citizenship" />
         <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
         <asp:BoundField DataField="HomePhoneNo" HeaderText="HomePhoneNo" SortExpression="HomePhoneNo" />
         <asp:BoundField DataField="Street1" HeaderText="Street1" SortExpression="Street1" />
         <asp:BoundField DataField="Street2" HeaderText="Street2" SortExpression="Street2" />
         <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
         <asp:BoundField DataField="UserState" HeaderText="UserState" SortExpression="UserState" />
         <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
         <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
         <asp:BoundField DataField="ProjectId" HeaderText="ProjectId" SortExpression="ProjectId" />
         <asp:BoundField DataField="SkillId" HeaderText="SkillId" SortExpression="SkillId" />
         <asp:BoundField DataField="EducationalBackground" HeaderText="EducationalBackground" SortExpression="EducationalBackground" />
     </Columns>

 </asp:GridView>
    
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:myConnection %>" SelectCommand="SELECT EmployeeID, FirstName, MiddleName, LastName, BirthDate, Age, Gender, CivilStatusId, Religion, Citizenship, MobileNo, HomePhoneNo, Street1, Street2, City, UserState, Zip, Country, ProjectId, SkillId, EducationalBackground FROM balaji.Employee_HR_Batch4"></asp:SqlDataSource>
              <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
    </div>
    </center>
        </form>
</body>
</html>
