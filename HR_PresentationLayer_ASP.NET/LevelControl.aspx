﻿
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="LevelControl.aspx.cs" Inherits="HR_PresentationLayer_ASP.NET.LevelControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
   


       
     <br />
    <br />
			<center>
				<table style="width:auto ">

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
                        <tr>
							<td style="width: 173px">
								
							</td>
							<td style="width: 248px">  
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                      <%--          
						<asp:Button ID="btn" CssClass="waves-effect waves-light btn" Text="Insert" runat="server" style="left: 78px; top: 0px" OnClick="btn_Click" />
                         --%>
                                <asp:Button ID="btnIns" CssClass="waves-effect waves-light btn" Text="Insert" runat="server"  style="left: 78px; top: 0px" OnClick="btnIns_Click"/>

							</td>
							<td>
								
							</td>
						</tr>

    
                 </table>
			</center>
		
   
    





</asp:Content>