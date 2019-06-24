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
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("c0389382-3fc5-4f9f-9179-be2e3984f463")]
	public partial class IfcDistributionFlowElement : IfcDistributionElement
	{
		[InverseProperty("RelatingFlowElement")] 
		[Description("Reference to the relationship object that relates control elements.")]
		[MaxLength(1)]
		public ISet<IfcRelFlowControlElements> HasControlElements { get; protected set; }
	
	
		public IfcDistributionFlowElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.HasControlElements = new HashSet<IfcRelFlowControlElements>();
		}
	
	
	}
	
}
