<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="ProjectControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.ProjectControl" %>
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
                                 <asp:Label ID="lblProjId" runat="server" Text="Project ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtProjId" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvProjId" runat="server" Display="Dynamic" ErrorMessage="Enter Project Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtProjId" Text="ProjectID is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblProjName" runat="server" Text="Project Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtProjName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvProjName" runat="server" Display="Dynamic" ErrorMessage="Enter Project Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtProjName" Text="Project Name is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvDesc" runat="server" Display="Dynamic" ErrorMessage="Enter Description" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtDescription" Text="Description is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblClient" runat="server" Text="Client"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtClient" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvClient" runat="server" Display="Dynamic" ErrorMessage="Enter Client" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtClient" Text="Client is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                     <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblStartDate" runat="server" Text="Start Date:"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" Display="Dynamic" ErrorMessage="Enter StartDate" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtStartDate" Text="StartDate is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                       <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" Display="Dynamic" ErrorMessage="Enter EndDate" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtEndDate" Text="EndDate is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                    
				</table>
			</td>
       </tr>
		<tr>
			<td colspan="3">
              <table>
                  <tr>
                   <td style="width: 689px">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;<asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 1px; top: 0px" />  
                       
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                       <asp:Button ID="btnDelete" CssClass="waves-effect waves-light btn" Text="Delete" runat="server" style="left: 0px; top: 1px" /> 
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="btnUpdate" CssClass="waves-effect waves-light btn" Text="Update" runat="server" style="left: 3px; top: 0px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                            <asp:HyperLink ID="btnSearch" CssClass="waves-effect waves-light btn" runat="server" Text="Search" NavigateUrl="~/ProjectSearch.aspx" ></asp:HyperLink>
                    

					</td>
                    </tr>
                 </table>
			</td>
		</tr>
      </table>
</asp:Content>