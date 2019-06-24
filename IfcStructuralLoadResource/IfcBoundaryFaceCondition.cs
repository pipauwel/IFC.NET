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

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("4ba2918e-ce3b-4abc-85e7-561cd722c1c2")]
	public partial class IfcBoundaryFaceCondition : IfcBoundaryCondition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Linear stiffness value in x-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Linear stiffness value in y-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Linear stiffness value in z-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaZ { get; set; }
	
	
		public IfcBoundaryFaceCondition()
		{
		}
	
	
	}
	
}
