using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money
{
    public float Value { get; private set; }
    public float Bank1AppliedValue { get; private set; }
    public float Bank2AppliedValue { get; private set; }
    public int Bank1WeekOfAppliance { get; private set;  }
    public int Bank2WeekOfAppliance { get; private set; }
    public int Bank1WeekOfClaim { get; private set; }
    public int Bank2WeekOfClaim { get; private set; }
    public void SetValue(float newValue)
    {
        Value = newValue;
    }

    public void SetBank1AppliedValue(float newValue)
    {
        Bank1AppliedValue = newValue;
    }

    public void SetBank2AppliedValue(float newValue)
    {
        Bank2AppliedValue = newValue;
    }

    public void SetBank1WeekOfAppliance(int newValue)
    {
        Bank1WeekOfAppliance = newValue;
    }

    public void SetBank2WeekOfAppliance(int newValue)
    {
        Bank2WeekOfAppliance = newValue;
    }

    public void SetBank1WeekOfClaim(int newValue)
    {
        Bank1WeekOfClaim = newValue;
    }

    public void SetBank2WeekOfClaim(int newValue)
    {
        Bank2WeekOfClaim = newValue;
    }
}
