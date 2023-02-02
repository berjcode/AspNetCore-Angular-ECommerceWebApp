<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="SchoolWebApp.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server">
       
         <div>

          
            Enter your name:
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server"/>

         </div>
      </form>
      
</asp:Content>
