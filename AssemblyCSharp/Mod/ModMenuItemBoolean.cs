﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mod;
public class ModMenuItemBoolean
{
    public string Title { get; set; }

    public string Description { get; set; }

    public bool Value { get; set; }

    public string RMSName { get; set; }

    public bool isDisabled { get; set; }

    public ModMenuItemBoolean(string title, string description, bool value, string rMSName, bool isDisabled) : this(title, description, rMSName, value)
    {
        this.isDisabled = isDisabled;
    }

    public ModMenuItemBoolean(string title, string description, bool value, string rmsName) : this(title, description, rmsName)
    {
        Value = value;
        isDisabled = false;
    }
    public ModMenuItemBoolean(string title, string description, string rmsName, bool isDisabled) : this(title, description, rmsName)
    {
        this.isDisabled = isDisabled;
    }
    public ModMenuItemBoolean(string title, string description, string rmsName)
    {
        Title = title;
        Description = description;
        Value = false;
        RMSName = rmsName;
        isDisabled = false;
    }

    public override bool Equals(object obj)
    {
        if (obj is ModMenuItemBoolean modMenuItem)
        {
            return modMenuItem.Title == Title && modMenuItem.Description == Description && modMenuItem.Value == Value && modMenuItem.RMSName == RMSName && modMenuItem.isDisabled == isDisabled;
        }
        return false;
    }

    public override int GetHashCode()
    {
        int hashCode = -1012648466;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
        hashCode = hashCode * -1521134295 + Value.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RMSName);
        return hashCode;
    }
}
