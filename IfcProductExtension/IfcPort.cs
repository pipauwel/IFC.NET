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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("6039b15a-9b36-4f5f-9d66-2c80b0c6ccb9")]
	public abstract partial class IfcPort : IfcProduct
	{
		[InverseProperty("RelatingPort")] 
		[Description("Reference to the element to port connection relationship. The relationship then refers to the element in which this port is contained.")]
		public IfcRelConnectsPortToElement ContainedIn { get; set; }
	
		[InverseProperty("RelatedPort")] 
		[Description("Reference to a port that is connected by the objectified relationship.")]
		[MaxLength(1)]
		public ISet<IfcRelConnectsPorts> ConnectedFrom { get; protected set; }
	
		[InverseProperty("RelatingPort")] 
		[Description("Reference to the port connection relationship. The relationship then refers to the other port to which this port is connected.")]
		[MaxLength(1)]
		public ISet<IfcRelConnectsPorts> ConnectedTo { get; protected set; }
	
	
		protected IfcPort(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ConnectedFrom = new HashSet<IfcRelConnectsPorts>();
			this.ConnectedTo = new HashSet<IfcRelConnectsPorts>();
		}
	
	
	}
	
}
