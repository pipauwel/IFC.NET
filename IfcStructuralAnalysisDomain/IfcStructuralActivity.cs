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
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("b7ecfe53-434a-4afb-b963-301a02d20c51")]
	public abstract partial class IfcStructuralActivity : IfcProduct
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the load resource, which is used to define the load type, direction and load values. The specified load types are provided in the IfcStructuralLoadResource presented at the end of this document.")]
		[Required()]
		public IfcStructuralLoad AppliedLoad { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Indicates if the load values are defined by using the local  coordinate system or the global project coordinate system.")]
		[Required()]
		public IfcGlobalOrLocalEnum GlobalOrLocal { get; set; }
	
		[InverseProperty("RelatedStructuralActivity")] 
		[Description("References to the IfcRelConnectsStructuralActivity relationship by which activities can be associated to structural representations.")]
		public IfcRelConnectsStructuralActivity AssignedToStructuralItem { get; set; }
	
	
		protected IfcStructuralActivity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
			: base(globalId, ownerHistory)
		{
			this.AppliedLoad = appliedLoad;
			this.GlobalOrLocal = globalOrLocal;
		}
	
	
	}
	
}
