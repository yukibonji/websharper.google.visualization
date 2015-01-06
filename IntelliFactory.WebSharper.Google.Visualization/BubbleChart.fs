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

namespace IntelliFactory.WebSharper.Google.Visualization

open Microsoft.FSharp.Quotations
open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.JavaScript
open IntelliFactory.WebSharper.Google.Visualization
open IntelliFactory.WebSharper.Google.Visualization.Base

type ColorAxisLegend [<Inline "{}">] () =
    [<DefaultValue>]
    val mutable position : LegendPosition

    [<DefaultValue>]
    val mutable textStyle : TextStyle

    /// A format string for numeric labels. This is a subset of the
    /// ICU pattern set. For instance, {numberFormat:'.##'} will
    /// display values "10.66", "10.6", and "10.0" for values 10.666,
    /// 10.6, and 10.
    [<DefaultValue>]
    val mutable numberFormat : string

type BubbleColorAxis [<Inline "{}">] () =
    [<DefaultValue>]
    val mutable minValue : float

    [<DefaultValue>]
    val mutable maxValue : float

    [<DefaultValue>]
    val mutable values : float[]

    [<DefaultValue>]
    val mutable legend : ColorAxisLegend

type Bubble [<Inline "{}">] () =
    [<DefaultValue>]
    val mutable opacity : float

    [<DefaultValue>]
    val mutable stroke : string

    [<DefaultValue>]
    val mutable textStyle : TextStyle

type SizeAxis [<Inline "{}">] () =
    [<DefaultValue>]
    val mutable maxSize : float

    [<DefaultValue>]
    val mutable minSize : float

    [<DefaultValue>]
    val mutable maxValue : float

    [<DefaultValue>]
    val mutable minValue : float

type BubbleChartOptions [<Inline "{}">] () =
    inherit ChartOptionsCommon()

    [<DefaultValue>]
    val mutable bubble : Bubble

    [<DefaultValue>]
    val mutable colorAxis : BubbleColorAxis

    [<DefaultValue>]
    val mutable sizeAxis : SizeAxis

    [<DefaultValue>]
    val mutable sortBubblesBySize : bool

/// A bubble chart that is rendered within the browser using SVG or
/// VML. Displays tips when hovering over bubbles. A bubble chart is
/// used to visualize a data set with 2 to 4 dimensions. The first two
/// dimensions are visualized as coordinates, the 3rd as color and the
/// 4th as size.
[<Name "google.visualization.BubbleChart">]
[<Require(typeof<Dependencies.CoreChart>)>]
type BubbleChart [<Stub>] (e : Dom.Element) =
    inherit ChartCommon<BubbleChartOptions>()
