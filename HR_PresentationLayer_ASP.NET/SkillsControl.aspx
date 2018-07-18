<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="SkillsControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.SkillsControl" %>
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
                            <td style="width: 195px">
                                 <asp:Label ID="lblSkillId" runat="server" Text="Skill ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtSkillId" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblSkillName" runat="server" Text="Skill Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtSkillName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                          <%--asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"---%>
                       </td>
      
                        </tr>
                    <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblSkillDes" runat="server" Text="Skill Description"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtSkillDes" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                          <%--asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"---%>
                       </td>
      
                        </tr>
                    <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblCatID" runat="server" Text="CategoryID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                   <asp:DropDownList CssClass="browser-default" runat="server" Width="244px"></asp:DropDownList>                         
                            </td>
                            <td>
                          <%--asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"---%>
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