<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignRolesSearch.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.AssignRolesSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <table>
       <tr>
           <td style="width:10%">

           </td>
           <td style="width:80%">
               <br />
               <table>
                   <tr>
                       <td style="width: auto">
                           <asp:Label runat="server">Search UserId: </asp:Label> 
               
                       </td>
                        <td style="width: auto">
                            <asp:DropDownList runat="server" OnSelectedIndexChanged="ddUserid_SelectedIndexChanged" ID="ddUserid" CssClass="browser-default" Width="200px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="UserId" DataValueField="UserId" ></asp:DropDownList>
               
                       
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select UserId from balaji.UserRoles_HR_Batch4"></asp:SqlDataSource>
               
                       
                        </td>
                       <td>
                           &nbsp;</td>
                       <td>
                           <asp:Button ID="Button1" OnClick="Button1_Click" CssClass="waves-effect waves-light btn" runat="server" Text="Refresh"  />
                       </td>
                   </tr>
               </table>
               <br />
               <asp:Panel ID="Panel1" runat="server">
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                       <Columns>
                           <asp:BoundField DataField="UserId" HeaderText="UserId" SortExpression="UserId" />
                           <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
                       </Columns>
                   </asp:GridView>

                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.UserRoles_HR_Batch4"></asp:SqlDataSource>

               </asp:Panel>
       <asp:Panel ID="Panel2" runat="server">
           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
               <Columns>
                   <asp:BoundField DataField="UserId" HeaderText="UserId" SortExpression="UserId" />
                   <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
               </Columns>
           </asp:GridView>

               <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.UserRoles_HR_Batch4 where [UserId]=@UserId">
                   <SelectParameters>
                       <asp:ControlParameter ControlID="ddUserid" Name="UserId" PropertyName="SelectedValue" />
                   </SelectParameters>
           </asp:SqlDataSource>

               </asp:Panel>
               

           </td>
               <td style="width:10%">

           </td>
       </tr>
   </table>
</asp:Content>
