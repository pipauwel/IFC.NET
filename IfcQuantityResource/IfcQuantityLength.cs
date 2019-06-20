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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcQuantityResource
{
	[Guid("4e958bba-84fa-45d3-bf26-9b6b72632919")]
	public partial class IfcQuantityLength : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Length measure value of this quantity.")]
		[Required()]
		public IfcLengthMeasure LengthValue { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("A formula by which the quantity has been calculated. It can be assigned in addition to the actual value of the quantity. Formulas could be mathematic calculations (like width x height), database links, or a combination. The formula is for informational purposes only.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  Attribute added to the end of the attribute list.</blockquote>")]
		public IfcLabel? Formula { get; set; }
	
	
		public IfcQuantityLength(IfcLabel name, IfcLengthMeasure lengthValue)
			: base(name)
		{
			this.LengthValue = lengthValue;
		}
	
	
	}
	
}
