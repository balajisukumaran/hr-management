
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UsersControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.UsersControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
  
    
    
       
     <br />
    <br />
			<center>
				<table style="width:auto ">
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


                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" />  
							</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
    </asp:Content>
