﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace ZetecModelWPFDemo
{
    class CanvasAutoResize : Canvas

    {
        protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint)
        {
            base.MeasureOverride(constraint);
            double width = base
                .InternalChildren
                .OfType<UIElement>()
                .Max(i => i.DesiredSize.Width + (double)i.GetValue(Canvas.LeftProperty));

            double height = base
                .InternalChildren
                .OfType<UIElement>()
                .Max(i => i.DesiredSize.Height + (double)i.GetValue(Canvas.TopProperty));

            return new Size(width, height);
        }

    }
}
