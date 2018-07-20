<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.EmployeeControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    
       
     <br />
    <br />
			<center>
				<table style="width:auto ">
	
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblBirthDayDate" runat="server" Text="Date of Birth"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:TextBox ID="dpDOB" runat="server" CssClass="browser-default" TextMode="Date" ></asp:TextBox>
    
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                     <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lbl" runat="server" Text="Gender"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:RadioButtonList ID="rdGender" runat="server" >
                                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:RadioButtonList>             
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblCivilStatus" runat="server" Text="Civil Status"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddCivilStatus" runat="server" Width="244px" DataSourceID="SqlDataSource1" DataTextField="StatusDescription" DataValueField="StatusId"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.CivilStatus_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblReligion" runat="server" Text="Religion"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtReligion" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCitizen" runat="server" Text="Citizenship"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCitizen" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblMobileNo" runat="server" Text="Mobile number"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblHomePhoneNo" runat="server" Text="Home Phone Number"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtHomePhoneNo" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblStreet1" runat="server" Text="Street 1"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblStreet2" runat="server" Text="Street 2"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblUserState" runat="server" Text="State"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtUserState" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblzip" runat="server" Text="zip"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblProject" runat="server" Text="Project"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddProject"  runat="server" Width="244px" DataSourceID="SqlDataSource2" DataTextField="ProjectName" DataValueField="ProjectID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Project_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblSkills" runat="server" Text="Skills"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddSkills" runat="server" Width="244px" DataSourceID="SqlDataSource3" DataTextField="SkillName" DataValueField="SkillID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Skill_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<%--<asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
								--%>
							</td>
						</tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblEducationalBackground" runat="server" Text="Educational Background"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtEducationalBackground" runat="server"></asp:TextBox>         
                            </td>
                            <td>
<%--                              <asp:RequiredFieldValidator ID="rfvCatId" runat="server" Display="Dynamic" ErrorMessage="Enter Category Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCatId" Text="CategoryId is Required"></asp:RequiredFieldValidator>
            --%>            </td>
      
                        </tr>
                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" OnClick="btnInsert_Click" style="left: 78px; top: 0px" />  
							</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
   
</asp:Content>
