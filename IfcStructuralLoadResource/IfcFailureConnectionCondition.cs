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
	[Guid("73b41ca6-4101-4683-b783-ffbc11578bb0")]
	public partial class IfcFailureConnectionCondition : IfcStructuralConnectionCondition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Tension force in x-direction leading to failure of the connection.")]
		public IfcForceMeasure? TensionFailureX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Tension force in y-direction leading to failure of the connection.")]
		public IfcForceMeasure? TensionFailureY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Tension force in z-direction leading to failure of the connection.")]
		public IfcForceMeasure? TensionFailureZ { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Compression force in x-direction leading to failure of the connection.")]
		public IfcForceMeasure? CompressionFailureX { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Compression force in y-direction leading to failure of the connection.")]
		public IfcForceMeasure? CompressionFailureY { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Compression force in z-direction leading to failure of the connection.")]
		public IfcForceMeasure? CompressionFailureZ { get; set; }
	
	
		public IfcFailureConnectionCondition()
		{
		}
	
	
	}
	
}
