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
using BuildingSmart.IFC.IfcProductExtension;

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("bbddf2c3-cd7d-4357-94ae-dc7c126b2265")]
	public partial class IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The second <em>IfcMaterialProfileSet</em> set to which the usage is applied.")]
		[Required()]
		public IfcMaterialProfileSet ForProfileEndSet { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Index reference to a significant point in the second section profile. Describes how this section is aligned relative to the axis of the member it is associated with. This parametric specification of profile alignment can be provided redundantly to the explicit alignment defined by ForProfileSet.MaterialProfiles[*].Profile.")]
		public IfcCardinalPointReference? CardinalEndPoint { get; set; }
	
	
		public IfcMaterialProfileSetUsageTapering(IfcMaterialProfileSet forProfileSet, IfcMaterialProfileSet forProfileEndSet)
			: base(forProfileSet)
		{
			this.ForProfileEndSet = forProfileEndSet;
		}
	
	
	}
	
}
