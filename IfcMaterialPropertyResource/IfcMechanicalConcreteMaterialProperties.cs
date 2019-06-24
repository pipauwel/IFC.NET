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

using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IFCMATERIALPROPERTYRESOURCE
{
	[Guid("c750da07-d276-413b-b77d-f5072eed05bc")]
	public partial class IfcMechanicalConcreteMaterialProperties : IfcMechanicalMaterialProperties
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The compressive strength of the concrete.")]
		public IfcPressureMeasure? CompressiveStrength { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The maximum aggregate size of the concrete.")]
		public IfcPositiveLengthMeasure? MaxAggregateSize { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Description of the admixtures added to the concrete mix.")]
		public IfcText? AdmixturesDescription { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Description of the workability of the fresh concrete defined according to local standards.")]
		public IfcText? Workability { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The protective pore ratio indicating the frost-resistance of the concrete.")]
		public IfcNormalisedRatioMeasure? ProtectivePoreRatio { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Description of the water impermeability denoting the water repelling properties.")]
		public IfcText? WaterImpermeability { get; set; }
	
	
		public IfcMechanicalConcreteMaterialProperties(IfcMaterial material)
			: base(material)
		{
		}
	
	
	}
	
}
