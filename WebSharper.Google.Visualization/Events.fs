﻿// $begin{copyright}
//
// This file is confidential and proprietary.
//
// Copyright (c) IntelliFactory, 2004-2010.
//
// All rights reserved.  Reproduction or use in whole or in part is
// prohibited without the written consent of the copyright holder.
//-----------------------------------------------------------------
// $end{copyright}

namespace WebSharper.Google.Visualization

open Microsoft.FSharp.Quotations
open WebSharper
open WebSharper.JavaScript
open WebSharper.Google.Visualization
open WebSharper.Google.Visualization.Base

[<Require(typeof<Dependencies.JsApi>)>]
module Events = 

    module private Visualizations =
        type AreaChart = WebSharper.Google.Visualization.AreaChart
        type BarChart = WebSharper.Google.Visualization.BarChart
        type ColumnChart = WebSharper.Google.Visualization.ColumnChart
        type LineChart = WebSharper.Google.Visualization.LineChart
        type PieChart = WebSharper.Google.Visualization.PieChart
        type ScatterChart = WebSharper.Google.Visualization.ScatterChart
        type IntensityMap = WebSharper.Google.Visualization.IntensityMap
        type MotionChart = WebSharper.Google.Visualization.MotionChart
        type OrgChart = WebSharper.Google.Visualization.OrgChart
        type Table = WebSharper.Google.Visualization.Table
        type TreeMap = WebSharper.Google.Visualization.TreeMap

    [<Inline "google.visualization.events.addListener($target, $event, $h)">]
    let internal listen<'param> (target: obj) 
                                (event: string) 
                                (h: 'param -> unit) : unit = X

    [<JavaScript>]
    let internal event<'T> (target: obj) (eventName: string) =
        let ev = new Event<_>()
        listen<'T> target eventName ev.Trigger
        ev.Publish

    /// Wrapper for onmouse_ events args.
    type RowColumnIndexes = {
        row : int
        column : int
    }

    type AreaChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.AreaChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.AreaChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.AreaChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.AreaChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type BarChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.BarChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.BarChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.BarChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.BarChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type ColumnChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.ColumnChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.ColumnChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.ColumnChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.ColumnChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type LineChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.LineChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.LineChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.LineChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.LineChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type PieChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.PieChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.PieChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.PieChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.PieChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type ScatterChart =
        
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call them only after the
        /// event was fired
        [<JavaScript>]
        static member Ready (visualization: Visualizations.ScatterChart) = 
            event<unit> visualization "ready"

        /// Fired when the user clicks a point or legend. When a point is selected, the 
        /// corresponding cell in the data table is selected; when a legend is selected, 
        /// the corresponding column in the data table is selected. To learn what has 
        /// been selected, call getSelection().
        [<JavaScript>]
        static member Select (visualization: Visualizations.ScatterChart) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.ScatterChart) = 
            event<RowColumnIndexes> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.ScatterChart) = 
            event<RowColumnIndexes> visualization "onmouseout"

    type RegionClickArgs = {
        region : string
    }

    type IntensityMap =
        [<JavaScript>]
        /// Standard select event
        static member Select (visualization: Visualizations.IntensityMap) = 
            event<unit> visualization "select"

        [<JavaScript>]
        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener
        /// for this event before you call the draw method, and call the methods only 
        /// after the event was fired 	None
        static member Ready (visualization: Visualizations.IntensityMap) = 
            event<unit> visualization "Ready"

    type MotionChart =

        /// The chart is ready for external method calls. If you want to interact with the chart,
        /// and call methods after you draw it, you should set up a listener for this event
        /// before you call the draw method, and call them only after the event was fired.
        [<JavaScript>]
        static member Ready (visualization: Visualizations.MotionChart) = 
            event<unit> visualization "ready"

        /// The user has interacted with the chart in some way. Call getState() to learn the
        /// current state of the chart.
        [<JavaScript>]
        static member StateChange (visualization: Visualizations.MotionChart) = 
            event<unit> visualization "statechange"

    type CollapseEventArgs = {
        collapsed : bool
        row : int
    }

    type Row = {
        row : int
    }

    type OrgChart =
        /// Event triggered when allowCollapse is set to true and the user double clicks on a
        /// node with children.
        [<JavaScript>]
        static member Collapse (visualization: Visualizations.OrgChart) = 
            event<CollapseEventArgs> visualization "collapse"

        /// Triggered when the user hovers over a specific row.  row - The zero-based index of
        /// the row in the data table, corresponding to the node being moused over.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.OrgChart) = 
            event<Row> visualization "onmouseover"

        /// Triggered when the user hovers out of a row.  row - The zero-based index of the row
        /// in the data table, corresponding to the node being moused out from.
        [<JavaScript>]
        static member OnMouseOut (visualization: Visualizations.OrgChart) = 
            event<Row> visualization "onmouseout"

        /// Standard select event
        [<JavaScript>]
        static member Select (visualization: Visualizations.OrgChart) = 
            event<unit> visualization "select"

        /// The chart is ready for external method calls. If you want to interact with
        /// the chart, and call methods after you draw it, you should set up a listener for this event before you call the draw method, and call the methods only after the event is fired. 	
        [<JavaScript>]
        static member Ready (visualization: Visualizations.OrgChart) = 
            event<unit> visualization "ready"

    type PageArgs = {
        page : int
    }

    type SortArgs = {
        column : int
        ascending : bool
        sortedIndexes : int []
    }

    type Table =

        /// The chart is ready for external method calls. If you want to interact with the chart,
        /// and call methods after you draw it, you should set up a listener for this event before
        /// you call the draw method, and call them only after the event was fired.
        [<JavaScript>]
        static member Ready (visualization: Visualizations.Table) = 
            event<unit> visualization "ready"

        /// Standard select event, but only entire rows can be selected.
        [<JavaScript>]
        static member Select (visualization: Visualizations.Table) = 
            event<unit> visualization "select"

        /// Triggered when users click on a page navigation button.
        [<JavaScript>]
        static member Page (visualization: Visualizations.Table) = 
            event<PageArgs> visualization "page"

        /// Triggered when users click on a column header, and the sort option is not 'disable'.
        [<JavaScript>]
        static member Sort (visualization: Visualizations.Table) = 
            event<SortArgs> visualization "sort"

    type TreeMap = 

        /// The chart is ready for external method calls. If you want to interact with the chart,
        /// and call methods after you draw it, you should set up a listener for this event before
        /// you call the draw method, and call them only after the event was fired.
        [<JavaScript>]
        static member Ready (visualization: Visualizations.TreeMap) = 
            event<unit> visualization "ready"

        /// Standard select event, but only entire rows can be selected.
        [<JavaScript>]
        static member Select (visualization: Visualizations.TreeMap) = 
            event<unit> visualization "select"

        /// Fired when the user mouses over a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        [<JavaScript>]
        static member OnMouseOver (visualization: Visualizations.TreeMap) = 
            event<int> visualization "onmouseover"

        [<JavaScript>]
        /// Fired when the user mouses away from a point, and passes in the row and column 
        /// indexes of the corresponding cell.
        static member OnMouseOut (visualization: Visualizations.TreeMap) = 
            event<int> visualization "onmouseout"
