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
	[Guid("eca9e451-2662-4a57-8f8a-2638170a1b97")]
	public partial class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Slippage of that connection. Defines the maximum displacement in x-direction without any loading applied.")]
		public IfcLengthMeasure? SlippageX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Slippage of that connection. Defines the maximum displacement in y-direction without any loading applied.")]
		public IfcLengthMeasure? SlippageY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Slippage of that connection. Defines the maximum displacement in z-direction without any loading applied.")]
		public IfcLengthMeasure? SlippageZ { get; set; }
	
	
		public IfcSlippageConnectionCondition()
		{
		}
	
	
	}
	
}
