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
	[Guid("c501d0e9-6233-4df9-859a-4a2adf4a47b3")]
	public partial class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Force value in x-direction.")]
		public IfcForceMeasure? ForceX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Force value in y-direction.")]
		public IfcForceMeasure? ForceY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Force value in z-direction.")]
		public IfcForceMeasure? ForceZ { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Moment about the x-axis.")]
		public IfcTorqueMeasure? MomentX { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Moment about the y-axis.")]
		public IfcTorqueMeasure? MomentY { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Moment about the z-axis.")]
		public IfcTorqueMeasure? MomentZ { get; set; }
	
	
		public IfcStructuralLoadSingleForce()
		{
		}
	
	
	}
	
}
