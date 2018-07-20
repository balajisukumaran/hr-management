<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="ProjectControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.ProjectControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
     
    
       
     <br />
    <br />
			<center>
				<table style="width:auto ">
		 
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblProjName" runat="server" Text="Project Name"></asp:Label>
                                <asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtProjName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvProjName" runat="server" Display="Dynamic"  ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtProjName" Text="Project Name is Required"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                                <asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtDescription"  TextMode="MultiLine" Rows="6" Columns="10" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvDesc" runat="server" Display="Dynamic"  ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtDescription" Text="Description is Required"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblClient" runat="server" Text="Client"></asp:Label>
                                <asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtClient" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:requiredfieldvalidator id="rfvclient" runat="server" display="dynamic"  forecolor="red" setfocusonerror="true" controltovalidate="txtclient" text="Client is required"></asp:requiredfieldvalidator>
                        </td>
      
                        </tr>
                     <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblStartDate" runat="server" Text="Start Date:"></asp:Label>
                                <asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtStartDate" runat="server" CssClass="browser-default" TextMode="Date"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" Display="Dynamic"  ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtStartDate" Text="StartDate is Required"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
                                <asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtEndDate" runat="server" CssClass="browser-default" TextMode="Date"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" Display="Dynamic"  ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtEndDate" Text="EndDate is Required"></asp:RequiredFieldValidator>
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
