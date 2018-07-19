<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CapgeminiDetailsControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.CapgeminiDetailsControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <br />
    <br />
			<center>
				<table style="width:auto ">
					    
                      <tr>
							<td style="width: 173px">
								<asp:Label ID="lblEmployeeId" runat="server" Text="Employee ID"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddEmployeeID" runat="server" Width="244px" DataSourceID="SqlDataSource1" DataTextField="EmployeeID" DataValueField="EmployeeID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Employee_HR_Batch4"></asp:SqlDataSource>
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
								<asp:DropDownList CssClass="browser-default" ID="ddlevel" runat="server" Width="244px" DataSourceID="SqlDataSource2" DataTextField="LevelDescription" DataValueField="LevelId"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Level_HR_Batch4"></asp:SqlDataSource>
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
                                <asp:TextBox ID="dpDateHired" runat="server" TextMode="Date" CssClass="browser-default"></asp:TextBox>
                              <%-- <input type="date" id="dpDateHired" class="datepicker"/>    --%>   
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
								<asp:DropDownList CssClass="browser-default" ID="ddSpeciality" runat="server" Width="244px" DataSourceID="SqlDataSource3" DataTextField="SpecialityName" DataValueField="SpecialityID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Speciality_HR_Batch4"></asp:SqlDataSource>
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
								<asp:DropDownList CssClass="browser-default" ID="DropDownList1" runat="server" Width="244px" DataSourceID="SqlDataSource4" DataTextField="StatusDescription" DataValueField="StatusId"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select *  from balaji.CivilStatus_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" OnClick="btnInsert_Click"/>  
							</td>
							<td>
								
							</td>
						</tr>
    
                 </table>
			</center>
		
     
</asp:Content>
