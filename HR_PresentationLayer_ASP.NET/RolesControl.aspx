
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="RolesControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.RolesControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
        
       
     <br />
    <br />
			<center>
				<table style="width:auto ">
	

        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblRoleName" runat="server" Text="Role Name"></asp:Label>
            </td>
            
            <td style="width: 248px">
                <asp:TextBox ID="txtRoleName" runat="server" ></asp:TextBox>
                
            </td>
            <td>
              <%--  <asp:RequiredFieldValidator ID="rfvRoleName" runat="server" Display="Dynamic" ErrorMessage="Enter Role Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtRoleName" Text="Role Name is Required"></asp:RequiredFieldValidator>
               --%>

            </td>

      
        </tr>
        

                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <%--<asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" />--%> 
                                <asp:Button ID="btn" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" OnClick="btn_Click"  style="left: 78px; top: 0px" /> 
							</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
   
    
</asp:Content>