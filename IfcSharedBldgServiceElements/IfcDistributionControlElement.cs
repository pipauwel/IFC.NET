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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("f29818b8-d9e0-49fc-a593-993420817803")]
	public partial class IfcDistributionControlElement : IfcDistributionElement
	{
		[InverseProperty("RelatedControlElements")] 
		[Description("Reference through the relationship object to related distribution flow elements.")]
		[MaxLength(1)]
		public ISet<IfcRelFlowControlElements> AssignedToFlowElement { get; protected set; }
	
	
		public IfcDistributionControlElement(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.AssignedToFlowElement = new HashSet<IfcRelFlowControlElements>();
		}
	
	
	}
	
}
