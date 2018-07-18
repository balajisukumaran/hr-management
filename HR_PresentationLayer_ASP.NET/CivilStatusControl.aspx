<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CivilStatusControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CivilStatusControl" %>
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
                 <asp:DropDownList ID="ddSelectById" CssClass="browser-default" runat="server" Width="244px"></asp:DropDownList>           
            </td>
            <td>
            <%--                <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%></td>
      
        </tr>
        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblStatusId" runat="server" Text="Status ID"></asp:Label>
            </td>
            <td style="width: 248px">
                <asp:TextBox ID="txtStatusId" runat="server"></asp:TextBox>                
            </td>
            <td>
<%--                <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%></td>
      
        </tr>

        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblStatusDes" runat="server" Text="Status Description"></asp:Label>
            </td>
            
            <td style="width: 248px">
                <asp:TextBox ID="txtStatusDes" runat="server" ></asp:TextBox>
                
            </td>
            <td>
              <%--  <asp:RequiredFieldValidator ID="rfvCatName" runat="server" Display="Dynamic" ErrorMessage="Enter Category Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatName" Text="Category Name is Required"></asp:RequiredFieldValidator>
               --%>

            </td>

      
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


