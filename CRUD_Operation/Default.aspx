<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_Operation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkselect" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="lnkselect_Click" >Select</asp:LinkButton>
                    </ItemTemplate>                    
                </asp:TemplateField>               
                <asp:TemplateField>
                     <ItemTemplate>
                        <asp:LinkButton ID="lnkview" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="lnkview_Click" >View</asp:LinkButton>
                         </ItemTemplate>
                </asp:TemplateField>


            </Columns>

        </asp:GridView>              
        
    </main>
    <asp:HiddenField id="txtid" runat="server" />
     <asp:Label ID="lblfname" runat="server" Text="First Name"></asp:Label>
     <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
     <br /><br />
     <asp:Label ID="lbllname" runat="server" Text="Last Name"></asp:Label>
     <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
     <br /><br />
     <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
     <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
     <br /><br />
     <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
     <br /><br />
     <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnadd_Click" />
     <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
     <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
</asp:Content>
