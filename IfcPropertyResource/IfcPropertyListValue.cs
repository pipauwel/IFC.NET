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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPropertyResource
{
	[Guid("c208d56a-9c19-4967-bdf5-47bb2f46c8f4")]
	public partial class IfcPropertyListValue : IfcSimpleProperty
	{
		[DataMember(Order = 0)] 
		[Description("List of values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcValue> ListValues { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("Unit for the list values, if not given, the default value for the measure type (given by the TYPE of nominal value) is used as defined by the global unit assignment at IfcProject.")]
		public IfcUnit Unit { get; set; }
	
	
		public IfcPropertyListValue(IfcIdentifier name, IfcValue[] listValues)
			: base(name)
		{
			this.ListValues = new List<IfcValue>(listValues);
		}
	
	
	}
	
}
