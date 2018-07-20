<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="CategoriesControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CategoriesControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    
     <br />
    <br />
			<center>
				<table style="width:auto ">


        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblCatName" runat="server" Text="Category Name"></asp:Label>
            </td>
            
            <td style="width: 238px">
                <asp:TextBox ID="txtCatName" runat="server" ></asp:TextBox>
                
            </td>
            <td>
              <%--  <asp:RequiredFieldValidator ID="rfvCatName" runat="server" Display="Dynamic" ErrorMessage="Enter Category Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatName" Text="Category Name is Required"></asp:RequiredFieldValidator>
               --%>

            </td>

      
        </tr>

        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblCatDesc" runat="server" Text="Category Description"></asp:Label>
            </td>
            
            <td style="width: 238px">
                <asp:TextBox ID="txtCatDesc" runat="server"></asp:TextBox>
               
            </td>
            <td>
            <%--    <asp:RequiredFieldValidator ID="rfvCatDesc" runat="server" Display="Dynamic" ErrorMessage="Enter Category Description" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatDesc" Text="Category Description is Required"></asp:RequiredFieldValidator>
              --%> 
            </td>
 
        </tr>
           
                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" OnClick="btnInsert_Click" />  
							</td>
							<td>
								
							</td>
						</tr>
    
                 </table>
			</center>
		
   
    
    
    
    
</asp:Content>
