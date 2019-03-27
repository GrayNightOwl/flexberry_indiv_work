﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="v3_SotrudnikL.aspx.cs" Inherits="IIS.Product_26934.v3_СотрудникL" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " + Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.ListFormHeaderCssClass %>">Сотрудник</h2>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.ListFormControlsCssClass %>">
            

            <ac:WebObjectListView ID="WebObjectListView1" runat="server" Visible="true" />
            



        </div>
    </div>

    
  <head>
    <!--Load the AJAX API-->
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript">
        
            var chartData; // globar variable for hold chart data
        google.load("visualization", "1", {packages: ["corechart"] });

        // Here We will fill chartData

        $(document).ready(function () {

                $.ajax({
                    url: '/myapi/Bar/GetChartData',
                    data: "",
                    dataType: 'JSON',
                    type: 'GET',
                    contentType: "application/json; chartset=utf-8",
                    success: function (data) {
                        chartData = data;
                    },
                    error: function (jqXHR,textStatus,errorThrown) {
                        alert("Error loading data! Please try again.");
                        console.log(textStatus);
                        debugger;
                    }
                }).done(function () {
                    // after complete loading data
                    google.setOnLoadCallback(drawChart);
                    drawChart();
                });
            });


        function drawChart() {
            var data = google.visualization.arrayToDataTable(chartData);

            var options = {
                title: "Время работы различных должностей",
                pointSize: 5
            };

            var barChart = new google.visualization.BarChart(document.getElementById('chart_div'));
            barChart.draw(data, options);

        }

    </script>


      <div id="chart_div" style="width:600px;height:400px">
      

    </div>


</asp:Content>
