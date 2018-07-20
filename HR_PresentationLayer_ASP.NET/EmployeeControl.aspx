<%@ Page Title="" Language="C#" MasterPageFile="~/HRClerkMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.EmployeeControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    
       
     <br />
    <br />
			<center>
				<table style="width:auto ">
	
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>  

                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvfname" runat="server" Display="Dynamic" ErrorMessage="Enter First Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtFirstName" Text="First Name is Required"></asp:RequiredFieldValidator>
                               <asp:RegularExpressionValidator ID="revfName" runat="server" ControlToValidate="txtFirstName" ValidationExpression="[A-Z][a-z]+" Text="Please provide name starting with capital alphabet and followed by small alphabets" ErrorMessage="[Name should start with capital alphabet and followed by small alphabets]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                                
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                        <asp:RegularExpressionValidator ID="revMName" runat="server" ControlToValidate="txtMiddleName" ValidationExpression="[A-Za-z]+" Text="Please provide name starting with  alphabets" ErrorMessage="[Name should start with  alphabets ]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                         
                        </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                                  <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                  <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>                
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="revlname" runat="server" Display="Dynamic" ErrorMessage="Enter Last Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtLastName" Text="Last Name is Required"></asp:RequiredFieldValidator>
                               <asp:RegularExpressionValidator ID="reglname" runat="server" ControlToValidate="txtLastName" ValidationExpression="[A-Za-z]+" Text="Please provide name starting with  alphabets" ErrorMessage="[Name should start with  alphabets]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                                  </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblBirthDayDate" runat="server" Text="Date of Birth"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:TextBox ID="dpDOB" runat="server" CssClass="browser-default" TextMode="Date" ></asp:TextBox>
    
                            </td>
                            <td>
                             <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="dpDOB" Text="Please provide Date of Birth" ErrorMessage="[Date of Birth should be provided]" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                             <asp:CompareValidator ID="cvDOB" runat="server" ControlToValidate="dpDOB" Type="Date" Operator="DataTypeCheck" Text="Please provide proper Date of Birth" ErrorMessage="[Date of Birth should be in proper format]" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                  </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>         
                            </td>
                            <td>
                             <asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="txtAge" Text="Please provide Age" ErrorMessage="[Age should be provided]" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                             <asp:CompareValidator ID="cvAge" runat="server" ControlToValidate="txtAge" Type="Integer" Operator="DataTypeCheck" Text="Please provide proper Age" ErrorMessage="[Age should be a Number]" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                  </td>
      
                        </tr>
                     <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lbl" runat="server" Text="Gender"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:RadioButtonList ID="rdGender" runat="server" >
                                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:RadioButtonList>             
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvGender" runat="server" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ControlToValidate="rdGender" Text="Gender should be  either Male or Female"  ErrorMessage="[Select either Male or Female]"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblCivilStatus" runat="server" Text="Civil Status"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddCivilStatus" runat="server" Width="244px" DataSourceID="SqlDataSource1" DataTextField="StatusDescription" DataValueField="StatusId"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.CivilStatus_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<asp:RequiredFieldValidator ID="rfvCivil" runat="server" Display="Dynamic" ErrorMessage="Select Civil Status" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ddCivilStatus" Text="Civil Status is Required"></asp:RequiredFieldValidator>
								
							</td>
						</tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblReligion" runat="server" Text="Religion"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtReligion" runat="server"></asp:TextBox>         
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvReligion" runat="server" Display="Dynamic" ErrorMessage="Enter Religion" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtReligion" Text="Religion is Required"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCitizen" runat="server" Text="Citizenship"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCitizen" runat="server"></asp:TextBox>    
                                     
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvCitizen" runat="server" Display="Dynamic" ErrorMessage="Enter Citizen" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCitizen" Text="Citizen is Required"></asp:RequiredFieldValidator>
                        </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblMobileNo" runat="server" Text="Mobile number"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>         
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvMobile" runat="server" Display="Dynamic" ErrorMessage="Enter MobileNo" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtMobileNo" Text="MobileNo is Required"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="revMobile" runat="server" ControlToValidate="txtMobileNo" ValidationExpression="[7-9][0-9]{9}" Text="Please provide phone number starting with 7 or 8 or 9 and the length should be 10" ErrorMessage="[Phone number should start with 7 or 8 or 9 and it should have 10 digits]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
          
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblHomePhoneNo" runat="server" Text="Home Phone Number"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtHomePhoneNo" runat="server"></asp:TextBox>         
                            </td>
                           <td>
                              <asp:RequiredFieldValidator ID="rfvHomeNo" runat="server" Display="Dynamic" ErrorMessage="Enter Home PhoneNo" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtHomePhoneNo" Text="Home PhoneNo is Required"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="regHomeNo" runat="server" ControlToValidate="txtHomePhoneNo" ValidationExpression="[7-9][0-9]{9}" Text="Please provide phone number starting with 7 or 8 or 9 and the length should be 10" ErrorMessage="[Phone number should start with 7 or 8 or 9 and it should have 10 digits]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
          
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblStreet1" runat="server" Text="Street 1"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:TextBox ID="txtStreet1" runat="server" TextMode="MultiLine"></asp:TextBox>       
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvStreet1" runat="server" Display="Dynamic" ErrorMessage="Enter Street1" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtStreet1" Text="Street1 is Required"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="regStreet1" runat="server" ControlToValidate="txtStreet1" ValidationExpression="[0-9a-zA-Z #,-]+" Text="Please provide Correct Address" ErrorMessage="[Address is  Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                           </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblStreet2" runat="server" Text="Street 2"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                                <asp:TextBox ID="txtStreet2" runat="server" TextMode="MultiLine"></asp:TextBox>       
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvStreet2" runat="server" Display="Dynamic" ErrorMessage="Enter Street2" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtStreet2" Text="Street2 is Required"></asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="regStreet2" runat="server" ControlToValidate="txtStreet2" ValidationExpression="[0-9a-zA-Z #,-]+" Text="Please provide Correct Address" ErrorMessage="[Address is  Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                         
                        </td>
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>         
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvCity" runat="server" Display="Dynamic" ErrorMessage="Enter City" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCity" Text="City is Required"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regCity" runat="server" ControlToValidate="txtCity" ValidationExpression="[A-Za-z]+" Text="Please provide City Name" ErrorMessage="[City Name is Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblUserState" runat="server" Text="State"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtUserState" runat="server"></asp:TextBox>         
                            </td>
                           <td>
                              <asp:RequiredFieldValidator ID="rfvState" runat="server" Display="Dynamic" ErrorMessage="Enter State" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtUserState" Text="State is Required"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regState" runat="server" ControlToValidate="txtUserState" ValidationExpression="[A-Za-z]+" Text="Please provide State Name" ErrorMessage="[State Name is Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblzip" runat="server" Text="zip"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>         
                            </td>
                             <td>
                              <asp:RequiredFieldValidator ID="rfvZip" runat="server" Display="Dynamic" ErrorMessage="Enter Zip Code" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtZip" Text=" 6 digit Zip Codeis Required"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regZip" runat="server" ControlToValidate="txtZip" ValidationExpression="[0-9]{6}" Text="Please provide 6 digit Zip Code" ErrorMessage="[ 6 digit Zip Codeis Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                            </td>
      
                        </tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>         
                            </td>
                            <td>
                              <asp:RequiredFieldValidator ID="rfvCountry" runat="server" Display="Dynamic" ErrorMessage="Enter Country" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCountry" Text="Country is Required"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regCountry" runat="server" ControlToValidate="txtCountry" ValidationExpression="[A-Za-z]+" Text="Please provide Country Name" ErrorMessage="[Country Name is Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                             
                            </td>
      
                        </tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblProject" runat="server" Text="Project"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddProject"  runat="server" Width="244px" DataSourceID="SqlDataSource2" DataTextField="ProjectName" DataValueField="ProjectID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Project_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<asp:RequiredFieldValidator ID="rfvProject" runat="server" Display="Dynamic" ErrorMessage="Select Project Id" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ddProject" Text="ProjectId is Required"></asp:RequiredFieldValidator>
								
							</td>
						</tr>
                    <tr>
							<td style="width: 195px">
								<asp:Label ID="lblSkills" runat="server" Text="Skills"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
							</td>
							<td style="width: 248px">
								<asp:DropDownList CssClass="browser-default" ID="ddSkills" runat="server" Width="244px" DataSourceID="SqlDataSource3" DataTextField="SkillName" DataValueField="SkillID"></asp:DropDownList>           
							    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:16MayCHNConnectionString %>" SelectCommand="select * from balaji.Skill_HR_Batch4"></asp:SqlDataSource>
							</td>
							<td>
								<asp:RequiredFieldValidator ID="rfvSkills" runat="server" Display="Dynamic" ErrorMessage="Select Skill" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ddSkills" Text="Skill is Required"></asp:RequiredFieldValidator>
								
							</td>
						</tr>
                    <tr>
                            <td style="width: 195px">
                                 <asp:Label ID="lblEducationalBackground" runat="server" Text="Educational Background"></asp:Label>
                                 <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="width: 248px">
                               <asp:TextBox ID="txtEducationalBackground" runat="server" TextMode="MultiLine"></asp:TextBox>         
                            </td>
                            <td>
                                 <asp:RequiredFieldValidator ID="rfvEB" runat="server" Display="Dynamic" ErrorMessage="Enter Educational Background" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtEducationalBackground" Text="Educational Background is Required"></asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="regEB" runat="server" ControlToValidate="txtEducationalBackground" ValidationExpression="[a-zA-Z]+" Text="Please provide Educational Background" ErrorMessage="[Educational Background is  Required]" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                         
                           </td>
      
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


