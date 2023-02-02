<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchoolWebApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
  <thead >
    <tr>
      <th scope="col">ID</th>
      <th scope="col">AD</th>
      <th scope="col">SOYAD</th>
      <th scope="col">TELEFON</th>
         <th scope="col">Mail</th>
         <th scope="col">Şifre</th>
         <th scope="col">İşlemler</th>
         
    </tr>
  </thead>
        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>
                  <tr>
          <th scope="row"><%#Eval("OGRID") %></th>
          <td><%#Eval("OGRAD") %></td>
          <td><%#Eval("OGRSOYAD") %></td>
          <td><%#Eval("OGRTELEFON") %></td>
         <td><%#Eval("OGRMAIL") %></td>
         <td><%#Eval("OGRSIFRE") %></td>
         <td>
            <%-- <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID=" + Eval("OGRID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>--%>
              <asp:HyperLink ID="HyperLink3" NavigateUrl='<%# (Eval("OGRID") != null) ? 
      String.Format("~/OgrenciSil.aspx?OGRID={0}", Eval("OGRID")) : 
      "#" 
%>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
             
             <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# (Eval("OGRID") != null) ? 
      String.Format("~/OgrenciGuncelle.aspx?OGRID={0}", Eval("OGRID")) : 
      "#" 
%>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

         </td>
    </tr>
            </ItemTemplate>
        </asp:Repeater>
  <tbody>
  


  
   
  </tbody>
</table>
</asp:Content>
