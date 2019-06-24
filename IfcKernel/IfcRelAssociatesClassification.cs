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
	[Guid("b9fd35c3-2f14-479b-b837-b8d959214bef")]
	public partial class IfcRelAssociatesClassification : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Classification applied to the objects.")]
		[Required()]
		public IfcClassificationNotationSelect RelatingClassification { get; set; }
	
	
		public IfcRelAssociatesClassification(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcClassificationNotationSelect relatingClassification)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingClassification = relatingClassification;
		}
	
	
	}
	
}
