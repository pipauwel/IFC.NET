// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcCostResource;

namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("7d000d8f-2938-439d-93a8-c32b17a46db8")]
	public partial class IfcMeasureWithUnit :
		BuildingSmart.IFC.IfcCostResource.IfcAppliedValueSelect,
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect
	{
		[DataMember(Order = 0)] 
		[Description("The value of the physical quantity when expressed in the specified units.")]
		[Required()]
		public IfcValue ValueComponent { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The unit in which the physical quantity is expressed.")]
		[Required()]
		public IfcUnit UnitComponent { get; set; }
	
	
		public IfcMeasureWithUnit(IfcValue valueComponent, IfcUnit unitComponent)
		{
			this.ValueComponent = valueComponent;
			this.UnitComponent = unitComponent;
		}
	
	
	}
	
}
