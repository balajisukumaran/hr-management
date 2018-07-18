<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CapgeminiDetailsControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CapgeminiDetailsControl" %>
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
								<asp:DropDownList CssClass="browser-default" ID="ddSelectById" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                      <tr>
							<td style="width: 173px">
								<asp:Label ID="lblEmployeeId" runat="server" Text="Employee ID"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddEmployeeID" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblEmail" runat="server" Text="Email ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                      <tr>
							<td style="width: 173px">
								<asp:Label ID="lblLevel" runat="server" Text="Level"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddlevel" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblDateHired" runat="server" Text="Date Hired"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <input type="date" id="dpDateHired" class="datepicker"/>       
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                     <tr>
							<td style="width: 173px">
								<asp:Label ID="lblSpeciality" runat="server" Text="Speciality"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddSpeciality" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                     <tr>
							<td style="width: 173px">
								<asp:Label ID="lblStatus" runat="server" Text="Civil Status"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddCivilStatus" runat="server" Width="244px"></asp:DropDownList>           
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
				</table>
			</td>
       </tr>
		<tr>
			<td colspan="3">
              <table>
                  <tr>
                   <td style="width: 689px"> <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 224px; top: 0px" />  
                       
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                       <asp:Button ID="btnDelete" CssClass="waves-effect waves-light btn" Text="Delete" runat="server" style="left: 0px; top: 1px" /> 
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="btnUpdate" CssClass="waves-effect waves-light btn" Text="Update" runat="server" style="left: 3px; top: 0px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            <asp:HyperLink ID="btnSearch" CssClass="waves-effect waves-light btn" runat="server" Text="Search" NavigateUrl="~/CapgeminiDetailsSearch.aspx" ></asp:HyperLink>
                    

					</td>
                    </tr>
                 </table>
			</td>
		</tr>
      </table>
</asp:Content>
