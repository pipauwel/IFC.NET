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

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("048744df-7b72-4775-bb9d-23cb26297991")]
	public partial class IfcMaterialClassificationRelationship
	{
		[DataMember(Order = 0)] 
		[Description("The material classifications identifying the type of material.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcClassificationNotationSelect> MaterialClassifications { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("Material being classified.")]
		[Required()]
		public IfcMaterial ClassifiedMaterial { get; set; }
	
	
		public IfcMaterialClassificationRelationship(IfcClassificationNotationSelect[] materialClassifications, IfcMaterial classifiedMaterial)
		{
			this.MaterialClassifications = new HashSet<IfcClassificationNotationSelect>(materialClassifications);
			this.ClassifiedMaterial = classifiedMaterial;
		}
	
	
	}
	
}
