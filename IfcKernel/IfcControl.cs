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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("a489edd2-988b-4611-b523-8dfabdd442b8")]
	public abstract partial class IfcControl : IfcObject
	{
		[InverseProperty("RelatingControl")] 
		[Description("Reference to the relationship that associates the control to the object(s) being controlled.")]
		public ISet<IfcRelAssignsToControl> Controls { get; protected set; }
	
	
		protected IfcControl(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.Controls = new HashSet<IfcRelAssignsToControl>();
		}
	
	
	}
	
}
