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

using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcControlExtension
{
	[Guid("1498678e-05c1-4f14-8e24-50a12e670b9f")]
	public partial class IfcRelAssociatesConstraint : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The intent of the constraint usage with regard to its related IfcConstraint and IfcObjects, IfcPropertyDefinitions or IfcRelationships. Typical values can be e.g. RATIONALE or EXPECTED PERFORMANCE.")]
		[Required()]
		public IfcLabel Intent { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to constraint that is being applied using this relationship.")]
		[Required()]
		public IfcConstraint RelatingConstraint { get; set; }
	
	
		public IfcRelAssociatesConstraint(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcLabel intent, IfcConstraint relatingConstraint)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.Intent = intent;
			this.RelatingConstraint = relatingConstraint;
		}
	
	
	}
	
}
