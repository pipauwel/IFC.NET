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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("8ca7e9ca-418d-449f-8156-85a0d8c68a74")]
	public partial class IfcConstructionMaterialResource : IfcConstructionResource
	{
		[DataMember(Order = 0)] 
		[Description("Possible suppliers of the type of materials.")]
		[MinLength(1)]
		public ISet<IfcActorSelect> Suppliers { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The ratio of the amount of a construction material used to the amount provided (determined as a quantity)")]
		public IfcRatioMeasure? UsageRatio { get; set; }
	
	
		public IfcConstructionMaterialResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.Suppliers = new HashSet<IfcActorSelect>();
		}
	
	
	}
	
}
