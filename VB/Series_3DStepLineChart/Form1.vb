﻿Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DStepLineChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim StepLineChart3D As New ChartControl()

            ' Add a step line series to it.
            Dim series1 As New Series("Series 1", ViewType.StepLine3D)

            ' Add points to the series.
            series1.Points.Add(New SeriesPoint("A", 12))
            series1.Points.Add(New SeriesPoint("B", 4))
            series1.Points.Add(New SeriesPoint("C", 17))
            series1.Points.Add(New SeriesPoint("D", 7))
            series1.Points.Add(New SeriesPoint("E", 12))
            series1.Points.Add(New SeriesPoint("F", 4))
            series1.Points.Add(New SeriesPoint("G", 17))
            series1.Points.Add(New SeriesPoint("H", 7))

            ' Add the series to the chart.
            StepLineChart3D.Series.Add(series1)

            ' Access labels of the series.
            series1.LabelsVisibility = DefaultBoolean.True

            CType(series1.Label, Line3DSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

            ' Access the series options.
            series1.Label.TextPattern = "{A}: {V}"

            ' Customize the view-type-specific properties of the series.
            Dim myView As StepLine3DSeriesView = CType(series1.View, StepLine3DSeriesView)
            myView.LineWidth = 5
            myView.LineThickness = 4

            ' Access the diagram's options.
            CType(StepLineChart3D.Diagram, XYDiagram3D).RuntimeRotation = True
            CType(StepLineChart3D.Diagram, XYDiagram3D).RotationType = RotationType.UseMouseStandard

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Step Line Chart"
            StepLineChart3D.Titles.Add(chartTitle1)
            StepLineChart3D.Legend.Visibility = DefaultBoolean.False

            ' Add the chart to the form.
            StepLineChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(StepLineChart3D)
        End Sub

    End Class
End Namespace
