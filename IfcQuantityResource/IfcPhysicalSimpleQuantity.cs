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

namespace BuildingSmart.IFC.IfcQuantityResource
{
	[Guid("a22516ac-defc-4721-8199-3c41ac139b8f")]
	public abstract partial class IfcPhysicalSimpleQuantity : IfcPhysicalQuantity
	{
		[DataMember(Order = 0)] 
		[Description("Optional assignment of a unit. If no unit is given, then the global unit assignment, as established at the IfcProject, applies to the quantity measures.")]
		public IfcNamedUnit Unit { get; set; }
	
	
		protected IfcPhysicalSimpleQuantity(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
