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
	[Guid("ad545ffd-432b-4bf8-8746-16d492c4ee6d")]
	public partial class IfcDistributionControlElement : IfcDistributionElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The ControlElement Point Identification assigned to this control element by the Building Automation System.")]
		public IfcIdentifier? ControlElementId { get; set; }
	
		[InverseProperty("RelatedControlElements")] 
		[Description("Reference through the relationship object to related distribution flow elements.")]
		[MaxLength(1)]
		public ISet<IfcRelFlowControlElements> AssignedToFlowElement { get; protected set; }
	
	
		public IfcDistributionControlElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.AssignedToFlowElement = new HashSet<IfcRelFlowControlElements>();
		}
	
	
	}
	
}
