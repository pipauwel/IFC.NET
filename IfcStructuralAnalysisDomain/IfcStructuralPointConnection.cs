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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("f8d48d8e-a2e9-4035-bba5-7b4e3b7f75d9")]
	public partial class IfcStructuralPointConnection : IfcStructuralConnection
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Defines a coordinate system used for the description of the support condition properties in <em>SELF\\IfcStructuralConnection.SupportCondition</em>, specified relative to the global coordinate system (global to the structural analysis model) established by <em>SELF.\\IfcProduct.ObjectPlacement</em>.  If left unspecified, the placement <em>IfcAxis2Placement3D</em>((x,y,z), ?, ?) is implied with x,y,z being the coordinates of the reference point of this <em>IfcStructuralPointConnection</em> and the default axes directions being in parallel with the global axes.")]
		public IfcAxis2Placement3D ConditionCoordinateSystem { get; set; }
	
	
		public IfcStructuralPointConnection(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
