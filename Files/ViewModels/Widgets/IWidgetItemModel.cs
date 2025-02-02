﻿using System;

namespace Files.ViewModels.Widgets
{
    public interface IWidgetItemModel : IDisposable
    {
        string WidgetName { get; }

        string AutomationProperties { get; }

        bool IsWidgetSettingEnabled { get; }
    }
}