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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("4bd9bd82-20ff-4504-bb85-feccfdfe7377")]
	public partial class IfcRelAssociatesClassification : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Classification applied to the objects.")]
		[Required()]
		public IfcClassificationSelect RelatingClassification { get; set; }
	
	
		public IfcRelAssociatesClassification(IfcGloballyUniqueId globalId, IfcDefinitionSelect[] relatedObjects, IfcClassificationSelect relatingClassification)
			: base(globalId, relatedObjects)
		{
			this.RelatingClassification = relatingClassification;
		}
	
	
	}
	
}
