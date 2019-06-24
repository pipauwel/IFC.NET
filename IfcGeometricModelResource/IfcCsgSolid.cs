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

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("274baa9b-e977-4d41-b4ed-98f3fe7fc3ad")]
	public partial class IfcCsgSolid : IfcSolidModel
	{
		[DataMember(Order = 0)] 
		[Description("Boolean expression of regularized operators describing the solid. The root of the tree of Boolean expressions is given explicitly as an IfcBooleanResult (the only item in the Select IfcCsgSelect).")]
		[Required()]
		public IfcCsgSelect TreeRootExpression { get; set; }
	
	
		public IfcCsgSolid(IfcCsgSelect treeRootExpression)
		{
			this.TreeRootExpression = treeRootExpression;
		}
	
	
	}
	
}
