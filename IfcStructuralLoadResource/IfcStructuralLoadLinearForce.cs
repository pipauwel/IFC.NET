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
	[Guid("337b2339-33ef-4def-b276-c720ed947f57")]
	public partial class IfcStructuralLoadLinearForce : IfcStructuralLoadStatic
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Linear force value in x-direction.")]
		public IfcLinearForceMeasure? LinearForceX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Linear force value in y-direction.")]
		public IfcLinearForceMeasure? LinearForceY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Linear force value in z-direction.")]
		public IfcLinearForceMeasure? LinearForceZ { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Linear moment about the x-axis.")]
		public IfcLinearMomentMeasure? LinearMomentX { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Linear moment about the y-axis.")]
		public IfcLinearMomentMeasure? LinearMomentY { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Linear moment about the z-axis.")]
		public IfcLinearMomentMeasure? LinearMomentZ { get; set; }
	
	
		public IfcStructuralLoadLinearForce()
		{
		}
	
	
	}
	
}
