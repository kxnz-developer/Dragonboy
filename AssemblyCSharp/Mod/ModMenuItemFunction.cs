﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod;
public class ModMenuItemFunction
{
    public string Title { get; set; }

    public string Description { get; set; }

    public bool isDisabled { get; set; }

    public ModMenuItemFunction(string title, string description, bool isDisabled)
    {
        Title = title;
        Description = description;
        this.isDisabled = isDisabled;
    }

    public ModMenuItemFunction(string title, string description) : this(title, description, false)
    {

    }

    public override bool Equals(object obj)
    {
        if (obj is ModMenuItemFunction func)
        {
            return func.Title == Title && func.Description == Description && func.isDisabled == isDisabled;
        }
        else return false;
    }

    public override int GetHashCode()
    {
        int hashCode = 256642751;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
        hashCode = hashCode * -1521134295 + isDisabled.GetHashCode();
        return hashCode;
    }
}
