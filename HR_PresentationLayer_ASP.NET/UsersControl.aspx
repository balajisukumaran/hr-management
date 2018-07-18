
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UsersControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.UsersControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
     <table style="width:100%;height:auto">
       <tr> 
			<td style="width:20%; height:auto">

			</td>
			<td>
				<table style="width:100% ">
					    <tr>
							<td style="width: 173px">
								<asp:Label ID="SelectByID" runat="server" Text="Select By ID"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblUserId" runat="server" Text="User ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvUserId" runat="server" Display="Dynamic" ErrorMessage="Enter User Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtUserId" Text="UserId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                     <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvUserName" runat="server" Display="Dynamic" ErrorMessage="Enter User Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtUserName" Text="User Name is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                     <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvPassword" runat="server" Display="Dynamic" ErrorMessage="Enter Password" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtPassword" Text="Password is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                     <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" Display="Dynamic" ErrorMessage="Enter FirstName" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtFirstName" Text="First Name is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                    <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvLastName" runat="server" Display="Dynamic" ErrorMessage="Enter LastName" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtLastName" Text="Last Name is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>


				</table>
			</td>
       </tr>
		<tr>
			<td colspan="3">
              <table>
                  <tr>
                   <td style="width: 689px">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;<asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 1px; top: 0px" />  
                       
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                       <asp:Button ID="btnDelete" CssClass="waves-effect waves-light btn" Text="Delete" runat="server" style="left: 0px; top: 1px" /> 
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="btnUpdate" CssClass="waves-effect waves-light btn" Text="Update" runat="server" style="left: 3px; top: 0px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                            <asp:HyperLink ID="btnSearch" CssClass="waves-effect waves-light btn" runat="server" Text="Search" NavigateUrl="~/UsersSearch.aspx" ></asp:HyperLink>
                    

					</td>
                    </tr>
                 </table>
			</td>
		</tr>
      </table>
</asp:Content>
