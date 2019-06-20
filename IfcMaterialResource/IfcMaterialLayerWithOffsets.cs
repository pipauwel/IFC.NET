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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("7b1a1c54-e0c2-488f-9134-36f48e15796a")]
	public partial class IfcMaterialLayerWithOffsets : IfcMaterialLayer
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Orientation of the offset; shall be perpendicular to the parent layer set direction.")]
		[Required()]
		public IfcLayerSetDirectionEnum OffsetDirection { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The numerical value of layer offset, in the direction of the axis assigned by the attribute <em>OffsetDirection</em>. The <em>OffsetValues[1]</em> identifies the offset from the lower position along the axis direction (normally the start of the standard extrusion), the <em>OffsetValues[2]</em> identifies the offset from the upper position along the axis direction (normally the end of the standard extrusion).")]
		[Required()]
		[MinLength(1)]
		[MaxLength(2)]
		public IfcLengthMeasure[] OffsetValues { get; set; }
	
	
		public IfcMaterialLayerWithOffsets(IfcNonNegativeLengthMeasure layerThickness, IfcLayerSetDirectionEnum offsetDirection, IfcLengthMeasure[] offsetValues)
			: base(layerThickness)
		{
			this.OffsetDirection = offsetDirection;
			this.OffsetValues = offsetValues;
		}
	
	
	}
	
}
