﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="v3_ProektL.aspx.cs" Inherits="IIS.Product_26934.v3_ПроектL" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " + Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.ListFormHeaderCssClass %>">Проект</h2>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.ListFormControlsCssClass %>">
            <asp:ImageButton ID="AuditBtn" runat="server" ImageUrl="~/App_Themes/BlueSky/Pages/EditPage/Images/audit.png" OnClick="AuditBtn_Click" AlternateText="Аудит"/>
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
                    url: 'myapi/Bar/GetChartData',
                    data: "",
                    dataType: 'JSON',
                    type: 'GET',
                    contentType: "application/json; chartset=utf-8",
                    success: function (data) {
                        chartData = data.d;
                    },
                    error: function () {
                        alert("Error loading data! Please try again.");
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
                title: "Company Performance Product Category Wise",
                pointSize: 5
            };

            var barChart = new google.visualization.BarChart(document.getElementById('chart_div'));
            barChart.draw(data, options);

        }

    </script>


      <div id="chart_div" style="width:600px;height:400px">
      

    </div>



<%--    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript">
    
    // Load the Visualization API and the piechart package.
    google.charts.load('current', {'packages':['corechart']});
      
    // Set a callback to run when the Google Visualization API is loaded.
    //google.charts.setOnLoadCallback(drawChart);
      
    function drawChart() {

        $(document).ready(function () {
            var jsonData =
            $.ajax
                ({
                url: "myapi/Bar/GetChartData",
                dataType: "json",
                async: false,
                success: function (data, status, xhr) {
                    debugger;
                    chart
                },
                error: function (data, status, xhr) {
                    alert("произошла ошибка");
                    debugger;
                },
            })
            .responseText;
        }).done(function () {

             //after complete loading data
            google.setOnLoadCallback(drawChart);
            drawChart();
            })

          
       //Create our data table out of JSON data loaded from server.
       // var data = new google.visualization.DataTable(jsonData);

       // var data = new google.visualization.DataTable();
       // data.addColumn('string', 'Topping');
       // data.addColumn('number', 'Slices');
       // data.addRows([
       //     ['Mushrooms', 3],
       //     ['Onions', 1],
       //     ['Olives', 1],
       //     ['Zucchini', 1],
       //     ['Pepperoni', 2]
       // ]);



       Instantiate and draw our chart, passing in some options.
      var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
      chart.draw(data, {width: 400, height: 240});
    }

    </script>
  </head>

  <body>
    <!--Div that will hold the pie chart-->
        диаграмма, появись
    <div id="chart_div"></div>
  </body>--%>


            
         
<%--  <head>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable(
                [
                ['Year', 'Sales', 'Expenses', 'Profit'],
                ['2014', 1000, 400, 200],
                ['2015', 1170, 460, 250],
                ['2016', 660, 1120, 300],
                ['2017', 1030, 540, 350]
                ]
            );

            var options = {
                chart: {
                    title: 'Company Performance',
                    subtitle: 'Sales, Expenses, and Profit: 2014-2017',
                },
                bars: 'horizontal' // Required for Material Bar Charts.
            };

            var chart = new google.charts.Bar(document.getElementById('barchart_material'));

            chart.draw(data, google.charts.Bar.convertOptions(options));
        }
    </script>
  </head>
  <body>
    <div id="barchart_material" style="width: 900px; height: 500px;"></div>
  </body>--%>




</asp:Content>