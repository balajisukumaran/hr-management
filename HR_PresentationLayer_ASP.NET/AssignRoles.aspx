<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignRoles.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.AssignRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
     <br />
    <br />
			<center>
				<table style="width:auto ">
				
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="ldlUserId" runat="server" Text="User ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                 						<asp:DropDownList CssClass="browser-default" runat="server" ID="ddUserId" Width="244px" DataSourceID="SqlDataSource1" DataTextField="UserId" DataValueField="UserId"></asp:DropDownList>             
                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Users_HR_Batch4"></asp:SqlDataSource>
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               						<asp:DropDownList CssClass="browser-default" runat="server" ID="ddRole" Width="244px" DataSourceID="SqlDataSource2" DataTextField="RoleName" DataValueField="RoleId"></asp:DropDownList>             
                                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Roles_HR_Batch4"></asp:SqlDataSource>
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
							<td style="width: 173px">
								
						<asp:Button runat="server" CssClass="waves-effect waves-light btn" Text="Add New" ID="btnAdd" style="left: 0px; top: -11px" OnClick="btnAdd_Click"  />
                              
								
							</td>
							<td style="width: 248px">  
                          <asp:HyperLink ID="btnList" runat="server" CssClass="waves-effect waves-light btn" Text="List Roles" NavigateUrl="~/AssignRolesSearch.aspx" ></asp:HyperLink>
						  <br />
                                <br />
                                	</td>
							<td>
								
							</td>
						</tr>
    
                 </table>
			</center>
		
    




</asp:Content>
