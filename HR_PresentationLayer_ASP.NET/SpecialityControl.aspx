﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SpecialityControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.SpecialityControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
      




       
     <br />
    <br />
			<center>
				<table style="width:auto ">
	
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

                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                                <asp:Button ID="btnInsert" CssClass="waves-effect waves-light btn" Text="Insert" OnClick="btnInsert_Click" runat="server" style="left: 78px; top: 0px" />  
							</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
   
    
</asp:Content>