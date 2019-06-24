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
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("0c4cfc00-0efe-4c96-a196-91b077d40492")]
	public partial class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem,
		BuildingSmart.IFC.IfcGeometricConstraintResource.IfcSurfaceOrFaceSurface
	{
		[DataMember(Order = 0)] 
		[Description("The set of connected face sets comprising the face based surface model.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcConnectedFaceSet> FbsmFaces { get; protected set; }
	
	
		public IfcFaceBasedSurfaceModel(IfcConnectedFaceSet[] fbsmFaces)
		{
			this.FbsmFaces = new HashSet<IfcConnectedFaceSet>(fbsmFaces);
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
