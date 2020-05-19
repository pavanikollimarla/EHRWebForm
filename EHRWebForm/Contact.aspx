<%@ Page Title="WebForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EHRWebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <%--<h2><%: Title %>--%>
        <%--<form id ="form1" runat="server">--%>
            <div>
                <h2>Web forms</h2>
                <br />
                <table>
                    <tr>
                    <td>First Name</td>
                    <td>         
                        <asp:TextBox ID="FnText" runat="server" Height="26px"></asp:TextBox>
                    </td>
                    </tr>
                        <tr>
                            <td>Email:</td>
                        <td>
                    <asp:TextBox ID="Emtext" runat="server" Height="26px"></asp:TextBox>
                            
                        </td>
                            </tr>

                    <tr>
                        <td>
                            <asp:Button ID="GetAll" runat="server" Text="GetAllDoctors" OnClick="GetAll_Click" />
                        </td>
                        <td>
                            <asp:Button ID="GetFN" runat="server" Text="GetAllDoctorsByFn" OnClick="GetFN_Click" />
                        </td>
                    </tr>           
                </table>
            </div>
       <%-- </form>--%>
                     
    <br /><br /><br />
        <div class ="msg">
            <asp:Literal ID="Lit" runat="server"></asp:Literal>
        </div>
    <br /><br /><br />
        <asp:GridView ID="GridView1" runat="server">
                            </asp:GridView>

       <%-- </h2>--%>
        
    
</asp:Content>
