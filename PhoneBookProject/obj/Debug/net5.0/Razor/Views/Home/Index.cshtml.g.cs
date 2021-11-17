#pragma checksum "D:\Asp.Net Core Mvc\PhoneBookProject\PhoneBookProject V2\PhoneBookProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01aadc91962d9a2a59a79ec66f00a1e724f92f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Asp.Net Core Mvc\PhoneBookProject\PhoneBookProject V2\PhoneBookProject\Views\_ViewImports.cshtml"
using PhoneBookProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.Net Core Mvc\PhoneBookProject\PhoneBookProject V2\PhoneBookProject\Views\_ViewImports.cshtml"
using PhoneBookProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01aadc91962d9a2a59a79ec66f00a1e724f92f10", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bbb0c93b3bb8027b26690aad5b7680be9399a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Asp.Net Core Mvc\PhoneBookProject\PhoneBookProject V2\PhoneBookProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "صفحه نخست";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-6"">
            <!-- AREA CHART -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">منطقه</h3>

                    
                </div>
                <div class=""box-body""");
            BeginWriteAttribute("style", " style=\"", 593, "\"", 601, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""chart"">
                        <canvas id=""areaChart"" style=""height: 250px; width: 594px;"" width=""742"" height=""312""></canvas>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
            <!-- DONUT CHART -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">دونات</h3>

                  
                </div>
                <div class=""box-body"">
                    <canvas id=""pieChart"" style=""height: 307px; width: 614px;"" width=""767"" height=""383""></canvas>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->

        </div>
        <!-- /.col (LEFT) -->
        <div class=""col-md-6"">
            <!-- LINE CHART -->
            <div class=""box box-info"">
                <div class=""box-header with-border"">
                    <");
            WriteLiteral(@"h3 class=""box-title"">خطی</h3>

                    
                </div>
                <div class=""box-body"">
                    <div class=""chart"">
                        <canvas id=""lineChart"" style=""height: 250px; width: 594px;"" width=""742"" height=""312""></canvas>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
            <!-- BAR CHART -->
            <div class=""box box-success"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">ستونی</h3>

                  
                </div>
                <div class=""box-body"">
                    <div class=""chart"">
                        <canvas id=""barChart"" style=""height: 229px; width: 594px;"" width=""742"" height=""286""></canvas>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->

        </div>
        <!-- /.col (RIG");
            WriteLiteral(@"HT) -->
    </div>
    <!-- /.row -->

</section>


<!-- jQuery 3 -->
<script src=""../../bower_components/jquery/dist/jquery.min.js""></script>
<!-- Bootstrap 3.3.7 -->
<script src=""../../bower_components/bootstrap/dist/js/bootstrap.min.js""></script>
<!-- ChartJS -->
<script src=""../../bower_components/Chart.js/Chart.js""></script>
<!-- FastClick -->
<script src=""../../bower_components/fastclick/lib/fastclick.js""></script>
<!-- AdminLTE App -->
<script src=""../../dist/js/adminlte.min.js""></script>
<!-- AdminLTE for demo purposes -->
<script src=""../../dist/js/demo.js""></script>
<!-- page script -->



<script>
    $(function () {
        /* ChartJS
         * -------
         * Here we will create a few charts using ChartJS
         */

        //--------------
        //- AREA CHART -
        //--------------

        // Get context with jQuery - using jQuery's .get() method.
        var areaChartCanvas = $('#areaChart').get(0).getContext('2d')
        // This will get the f");
            WriteLiteral(@"irst returned node in the jQuery collection.
        var areaChart = new Chart(areaChartCanvas)

        var areaChartData = {
            labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
            datasets: [
                {
                    label: 'Electronics',
                    fillColor: 'rgba(210, 214, 222, 1)',
                    strokeColor: 'rgba(210, 214, 222, 1)',
                    pointColor: 'rgba(210, 214, 222, 1)',
                    pointStrokeColor: '#c1c7d1',
                    pointHighlightFill: '#fff',
                    pointHighlightStroke: 'rgba(220,220,220,1)',
                    data: [65, 59, 80, 81, 56, 55, 40]
                },
                {
                    label: 'Digital Goods',
                    fillColor: 'rgba(60,141,188,0.9)',
                    strokeColor: 'rgba(60,141,188,0.8)',
                    pointColor: '#3b8bba',
                    pointStrokeColor: 'rgba(60,141,188,1)',
                  ");
            WriteLiteral(@"  pointHighlightFill: '#fff',
                    pointHighlightStroke: 'rgba(60,141,188,1)',
                    data: [28, 48, 40, 19, 86, 27, 90]
                }
            ]
        }

        var areaChartOptions = {
            //Boolean - If we should show the scale at all
            showScale: true,
            //Boolean - Whether grid lines are shown across the chart
            scaleShowGridLines: false,
            //String - Colour of the grid lines
            scaleGridLineColor: 'rgba(0,0,0,.05)',
            //Number - Width of the grid lines
            scaleGridLineWidth: 1,
            //Boolean - Whether to show horizontal lines (except X axis)
            scaleShowHorizontalLines: true,
            //Boolean - Whether to show vertical lines (except Y axis)
            scaleShowVerticalLines: true,
            //Boolean - Whether the line is curved between points
            bezierCurve: true,
            //Number - Tension of the bezier curve between points
     ");
            WriteLiteral(@"       bezierCurveTension: 0.3,
            //Boolean - Whether to show a dot for each point
            pointDot: false,
            //Number - Radius of each point dot in pixels
            pointDotRadius: 4,
            //Number - Pixel width of point dot stroke
            pointDotStrokeWidth: 1,
            //Number - amount extra to add to the radius to cater for hit detection outside the drawn point
            pointHitDetectionRadius: 20,
            //Boolean - Whether to show a stroke for datasets
            datasetStroke: true,
            //Number - Pixel width of dataset stroke
            datasetStrokeWidth: 2,
            //Boolean - Whether to fill the dataset with a color
            datasetFill: true,
            //String - A legend template
            legendTemplate: '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<datasets.length; i++){%><li><span style=""background-color:<%=datasets[i].lineColor%>""></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%>");
            WriteLiteral(@"</li><%}%></ul>',
            //Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
            maintainAspectRatio: true,
            //Boolean - whether to make the chart responsive to window resizing
            responsive: true
        }

        //Create the line chart
        areaChart.Line(areaChartData, areaChartOptions)

        //-------------
        //- LINE CHART -
        //--------------
        var lineChartCanvas = $('#lineChart').get(0).getContext('2d')
        var lineChart = new Chart(lineChartCanvas)
        var lineChartOptions = areaChartOptions
        lineChartOptions.datasetFill = false
        lineChart.Line(areaChartData, lineChartOptions)

        //-------------
        //- PIE CHART -
        //-------------
        // Get context with jQuery - using jQuery's .get() method.
        var pieChartCanvas = $('#pieChart').get(0).getContext('2d')
        var pieChart = new Chart(pieChart");
            WriteLiteral(@"Canvas)
        var PieData = [
            {
                value: 700,
                color: '#f56954',
                highlight: '#f56954',
                label: 'Chrome'
            },
            {
                value: 500,
                color: '#00a65a',
                highlight: '#00a65a',
                label: 'IE'
            },
            {
                value: 400,
                color: '#f39c12',
                highlight: '#f39c12',
                label: 'FireFox'
            },
            {
                value: 600,
                color: '#00c0ef',
                highlight: '#00c0ef',
                label: 'Safari'
            },
            {
                value: 300,
                color: '#3c8dbc',
                highlight: '#3c8dbc',
                label: 'Opera'
            },
            {
                value: 100,
                color: '#d2d6de',
                highlight: '#d2d6de',
                label: 'Navigator'
     ");
            WriteLiteral(@"       }
        ]
        var pieOptions = {
            //Boolean - Whether we should show a stroke on each segment
            segmentShowStroke: true,
            //String - The colour of each segment stroke
            segmentStrokeColor: '#fff',
            //Number - The width of each segment stroke
            segmentStrokeWidth: 2,
            //Number - The percentage of the chart that we cut out of the middle
            percentageInnerCutout: 50, // This is 0 for Pie charts
            //Number - Amount of animation steps
            animationSteps: 100,
            //String - Animation easing effect
            animationEasing: 'easeOutBounce',
            //Boolean - Whether we animate the rotation of the Doughnut
            animateRotate: true,
            //Boolean - Whether we animate scaling the Doughnut from the centre
            animateScale: false,
            //Boolean - whether to make the chart responsive to window resizing
            responsive: true,
         ");
            WriteLiteral(@"   // Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
            maintainAspectRatio: true,
            //String - A legend template
            legendTemplate: '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<segments.length; i++){%><li><span style=""background-color:<%=segments[i].fillColor%>""></span><%if(segments[i].label){%><%=segments[i].label%><%}%></li><%}%></ul>'
        }
        //Create pie or douhnut chart
        // You can switch between pie and douhnut using the method below.
        pieChart.Doughnut(PieData, pieOptions)

        //-------------
        //- BAR CHART -
        //-------------
        var barChartCanvas = $('#barChart').get(0).getContext('2d')
        var barChart = new Chart(barChartCanvas)
        var barChartData = areaChartData
        barChartData.datasets[1].fillColor = '#00a65a'
        barChartData.datasets[1].strokeColor = '#00a65a'
        barChartData.dataset");
            WriteLiteral(@"s[1].pointColor = '#00a65a'
        var barChartOptions = {
            //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
            scaleBeginAtZero: true,
            //Boolean - Whether grid lines are shown across the chart
            scaleShowGridLines: true,
            //String - Colour of the grid lines
            scaleGridLineColor: 'rgba(0,0,0,.05)',
            //Number - Width of the grid lines
            scaleGridLineWidth: 1,
            //Boolean - Whether to show horizontal lines (except X axis)
            scaleShowHorizontalLines: true,
            //Boolean - Whether to show vertical lines (except Y axis)
            scaleShowVerticalLines: true,
            //Boolean - If there is a stroke on each bar
            barShowStroke: true,
            //Number - Pixel width of the bar stroke
            barStrokeWidth: 2,
            //Number - Spacing between each of the X value sets
            barValueSpacing: 5,
   ");
            WriteLiteral(@"         //Number - Spacing between data sets within X values
            barDatasetSpacing: 1,
            //String - A legend template
            legendTemplate: '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<datasets.length; i++){%><li><span style=""background-color:<%=datasets[i].fillColor%>""></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>',
            //Boolean - whether to make the chart responsive
            responsive: true,
            maintainAspectRatio: true
        }

        barChartOptions.datasetFill = false
        barChart.Bar(barChartData, barChartOptions)
    })
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591