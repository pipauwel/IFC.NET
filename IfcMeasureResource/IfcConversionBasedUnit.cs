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

namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("7d4b1cf1-345c-456d-9199-c2fc2e7e94f0")]
	public partial class IfcConversionBasedUnit : IfcNamedUnit,
		BuildingSmart.IFC.IfcExternalReferenceResource.IfcResourceObjectSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The word, or group of words, by which the conversion based unit is referred to.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("The physical quantity from which the converted unit is derived.")]
		[Required()]
		public IfcMeasureWithUnit ConversionFactor { get; set; }
	
		[InverseProperty("RelatedResourceObjects")] 
		[Description("Reference to external information, e.g. library, classification, or document information, which is associated with the conversion-based unit.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE New inverse attribute.</blockquote>")]
		public ISet<IfcExternalReferenceRelationship> HasExternalReference { get; protected set; }
	
	
		public IfcConversionBasedUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcLabel name, IfcMeasureWithUnit conversionFactor)
			: base(dimensions, unitType)
		{
			this.Name = name;
			this.ConversionFactor = conversionFactor;
			this.HasExternalReference = new HashSet<IfcExternalReferenceRelationship>();
		}
	
	
	}
	
}
