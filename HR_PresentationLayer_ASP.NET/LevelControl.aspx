
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="LevelControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.LevelControl" %>
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
                            <td style="width: 195px">
                                 <asp:Label ID="lblLevelId" runat="server" Text="Level ID"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtLevelId" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
                            <td style="width: 173px">
                                 <asp:Label ID="lblLevDes" runat="server" Text="Level Description"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtLevelDes" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
				</table>
			</td>
       </tr>
		<tr>
			<td colspan="3">
              <table>
                  <tr>
                   <td style="width: 689px">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;<asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 1px; top: 0px" />  
                       
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                       <asp:Button ID="btnDelete" CssClass="waves-effect waves-light btn" Text="Delete" runat="server" style="left: 0px; top: 1px" /> 
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="btnUpdate" CssClass="waves-effect waves-light btn" Text="Update" runat="server" style="left: 3px; top: 0px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                            <asp:HyperLink ID="btnSearch" CssClass="waves-effect waves-light btn" runat="server" Text="Search" NavigateUrl="~/LevelSearch.aspx" ></asp:HyperLink>
                    

					</td>
                    </tr>
                 </table>
			</td>
		</tr>
      </table>
      </CENTER>
</asp:Content>