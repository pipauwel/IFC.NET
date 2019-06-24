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
	[Guid("920900b8-14ac-46d6-be66-5fb04844b48f")]
	public partial class IfcQuantityArea : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Area measure value of this quantity.")]
		[Required()]
		public IfcAreaMeasure AreaValue { get; set; }
	
	
		public IfcQuantityArea(IfcLabel name, IfcAreaMeasure areaValue)
			: base(name)
		{
			this.AreaValue = areaValue;
		}
	
	
	}
	
}
