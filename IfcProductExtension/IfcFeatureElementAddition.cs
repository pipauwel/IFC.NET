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
	[Guid("6fc15ef2-60b4-4c45-a80f-88e9e7f1c2fe")]
	public abstract partial class IfcFeatureElementAddition : IfcFeatureElement
	{
		[InverseProperty("RelatedFeatureElement")] 
		[Description("<EPM-HTML>  Reference to the <I>IfcRelProjectsElement</I> relationship that uses this <I>IfcFeatureElementAddition</I> to create a volume addition at an element. The <I>IfcFeatureElementAddition</I> can only be used to create a single addition at a single element using Boolean addition operation.  </EPM-HTML>")]
		public IfcRelProjectsElement ProjectsElements { get; set; }
	
	
		protected IfcFeatureElementAddition(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
