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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("4a5f68b7-087c-470e-a743-bc7f5f8b3e48")]
	public partial class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem
	{
		[DataMember(Order = 0)] 
		[Required()]
		[MinLength(1)]
		public ISet<IfcShell> SbsmBoundary { get; protected set; }
	
	
		public IfcShellBasedSurfaceModel(IfcShell[] sbsmBoundary)
		{
			this.SbsmBoundary = new HashSet<IfcShell>(sbsmBoundary);
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
