﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="v3_SotrudnikL.aspx.cs" Inherits="IIS.Product_26934.v3_СотрудникL" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " + Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.ListFormHeaderCssClass %>">Сотрудник</h2>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.ListFormControlsCssClass %>">
            <asp:ImageButton ID="AuditBtn" runat="server" ImageUrl="~/App_Themes/BlueSky/Pages/EditPage/Images/audit.png" OnClick="AuditBtn_Click" AlternateText="Аудит"/>
            

            <ac:WebObjectListView ID="WebObjectListView1" runat="server" Visible="true" />
            



        </div>
    </div>
</asp:Content>
