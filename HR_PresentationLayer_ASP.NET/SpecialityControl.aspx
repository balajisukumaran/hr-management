<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SpecialityControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.SpecialityControl" %>
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
                                 <asp:Label ID="lblSpecialityId" runat="server" Text="Speciality ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtSpecialityId" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvSpecialityId" runat="server" Display="Dynamic" ErrorMessage="Enter Speciality Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtSpecialityId" Text="SpecialityId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>

                      <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblSpecialityName" runat="server" Text="Speciality Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtSpecialityName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvSpecialityName" runat="server" Display="Dynamic" ErrorMessage="Enter Speciality Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtSpecialityName" Text="SpecialityName is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
				</table>
			</td>
       </tr>
		<tr>
			<td colspan="3">
              <table>
                  <tr>
                   <td style="width: 689px">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;<asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 1px; top: 0px" />  
                       
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                       <asp:Button ID="btnDelete" CssClass="waves-effect waves-light btn" Text="Delete" runat="server" style="left: 0px; top: 1px" /> 
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="btnUpdate" CssClass="waves-effect waves-light btn" Text="Update" runat="server" style="left: 3px; top: 0px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                            <asp:HyperLink ID="btnSearch" CssClass="waves-effect waves-light btn" runat="server" Text="Search" NavigateUrl="~/SpecialitySearch.aspx" ></asp:HyperLink>
                    

					</td>
                    </tr>
                 </table>
			</td>
		</tr>
      </table>
</asp:Content>