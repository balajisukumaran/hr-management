<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CivilStatusControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CivilStatusControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
     
    
     <br />
    <br />
			<center>
				<table style="width:auto ">
		 

        <tr>
            <td style="width: 173px">
                <asp:Label ID="lblStatusDes" runat="server" Text="Status Description"></asp:Label>
            </td>
            
            <td style="width: 248px">
                <asp:TextBox ID="txtStatusDes" runat="server" TextMode="MultiLine"></asp:TextBox>
                
            </td>
           <td>
                              <asp:RequiredFieldValidator ID="rfvStatusDesc" runat="server" Display="Dynamic" ErrorMessage="Enter Status Description" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtStatusDes" Text="Status Description is Required"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="regStatusDesc" runat="server" ControlToValidate="txtStatusDes" ValidationExpression="[0-9a-zA-Z #,-]+" Text="Please provide Status Description" ErrorMessage="[Status Description is  Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                           </td>

      
        </tr>

                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
						<asp:Button ID="btn" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" OnClick="btn_Click" />
                                	</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
   
    

</asp:Content>

