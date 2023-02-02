<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="SchoolWebApp.OgrenciGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

       <form id="form1" runat="server">
      
        <div class="form-group">

            <div >

  
              <asp:Label for="TxtOgrID" ID="Label7" runat="server" >Öğrenci ID</asp:Label>
         
            <asp:TextBox ID="TxtOgrID"  runat="server" CssClass="form-control"></asp:TextBox>
          </div>

            <div >

  
              <asp:Label for="TxtOgrAd" ID="Label1" runat="server" >Öğrenci Adı</asp:Label>
         
            <asp:TextBox ID="TxtOgrAd"  runat="server" CssClass="form-control"></asp:TextBox>
          </div>
            <br />
               <div >
             <asp:Label for="TxtOgrSoyad" ID="Label2" runat="server" >Öğrenci Soyadı</asp:Label>
         
            <asp:TextBox ID="TxtOgrSoyad"  runat="server" CssClass="form-control"></asp:TextBox>
               </div>  <br />
               <div >
             <asp:Label for="TxtOgrTelefon" ID="Label3" runat="server" >Öğrenci Telefon</asp:Label>
         
            <asp:TextBox ID="TxtOgrTelefon"  runat="server" CssClass="form-control"></asp:TextBox>
                      </div>  <br />

               <div >
             <asp:Label for="TxtOgrMail" ID="Label4" runat="server" >Öğrenci Mail</asp:Label>
         
            <asp:TextBox ID="TxtOgrMail"  runat="server" CssClass="form-control"></asp:TextBox>
                     
                   </div> <br />

              <div >
             <asp:Label for="TxtOgrSifre" ID="Label5" runat="server" >Öğrenci Şifre</asp:Label>
         
            <asp:TextBox ID="TxtOgrSifre"  runat="server" CssClass="form-control"></asp:TextBox>
                     
                   </div> <br />
             <div >
             <asp:Label for="TxtOgrFoto" ID="Label6" runat="server" >Öğrenci Fotoğraf Linki</asp:Label>
         
            <asp:TextBox ID="TxtOgrFoto"  runat="server" CssClass="form-control"></asp:TextBox>
                     
                   </div> <br />
            

        </div>
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Güncelle" OnClick="Button1_Click"  />


    </form>
</asp:Content>
