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
	[Guid("a431388c-2787-440c-aeb1-229142deaf2a")]
	public partial class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Slippage in x-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLengthMeasure? SlippageX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Slippage in y-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLengthMeasure? SlippageY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Slippage in z-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLengthMeasure? SlippageZ { get; set; }
	
	
		public IfcSlippageConnectionCondition()
		{
		}
	
	
	}
	
}
