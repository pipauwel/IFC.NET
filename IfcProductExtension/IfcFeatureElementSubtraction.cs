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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("b1f5bb6b-9f49-491a-b274-e457051581d8")]
	public abstract partial class IfcFeatureElementSubtraction : IfcFeatureElement
	{
		[InverseProperty("RelatedOpeningElement")] 
		[Description("Reference to the Voids Relationship that uses this Opening Element to create a void within an Element. The Opening Element can only be used to create a single void within a single Element.")]
		public IfcRelVoidsElement VoidsElements { get; set; }
	
	
		protected IfcFeatureElementSubtraction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
