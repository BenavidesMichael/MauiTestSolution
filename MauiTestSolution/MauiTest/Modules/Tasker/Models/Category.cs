﻿using PropertyChanged;

namespace MauiTest.Modules.Tasker.Models;

[AddINotifyPropertyChangedInterface]
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public int Pending { get; set; }
    public float Percentage { get; set; }
    public bool IsSelected { get; set; }
}