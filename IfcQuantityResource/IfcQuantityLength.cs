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
	[Guid("306d4f10-3266-4f40-b5a9-00df783a1057")]
	public partial class IfcQuantityLength : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Length measure value of this quantity.")]
		[Required()]
		public IfcLengthMeasure LengthValue { get; set; }
	
	
		public IfcQuantityLength(IfcLabel name, IfcLengthMeasure lengthValue)
			: base(name)
		{
			this.LengthValue = lengthValue;
		}
	
	
	}
	
}
