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
using BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN;

namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("0723c581-0348-47f4-bca7-0f9d95f046c0")]
	public partial class IfcMeasureWithUnit :
		BuildingSmart.IFC.IfcCostResource.IfcAppliedValueSelect,
		BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN.IfcConditionCriterionSelect,
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
