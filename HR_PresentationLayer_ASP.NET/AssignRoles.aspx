<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignRoles.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.AssignRoles" %>

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
								<asp:DropDownList CssClass="browser-default" runat="server" ID="btnSelectById" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="ldlUserId" runat="server" Text="User ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                 						<asp:DropDownList CssClass="browser-default" runat="server" ID="ddUserId" Width="244px"></asp:DropDownList>             
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
                               						<asp:DropDownList CssClass="browser-default" runat="server" ID="ddRole" Width="244px"></asp:DropDownList>             
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnAssign" CssClass="waves-effect waves-light btn" Text="Assign" runat="server" style="left: 78px; top: 0px" />  
							</td>
							<td>
								
							</td>
						</tr>
    
                 </table>
			</center>
		
    




</asp:Content>
