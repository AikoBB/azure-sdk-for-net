// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberNotInRange Filter.
/// </summary>
public partial class NumberNotInRangeFilter : EventGridFilter
{
    /// <summary>
    /// The set of filter values.
    /// </summary>
    public BicepList<BicepList<double>> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<BicepList<double>>? _values;

    /// <summary>
    /// Creates a new NumberNotInRangeFilter.
    /// </summary>
    public NumberNotInRangeFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of NumberNotInRangeFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("operatorType", ["operatorType"], defaultValue: "NumberNotInRange");
        _values = DefineListProperty<BicepList<double>>("Values", ["values"]);
    }
}
