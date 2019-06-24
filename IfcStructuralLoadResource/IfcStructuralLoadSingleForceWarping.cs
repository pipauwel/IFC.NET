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
	[Guid("440d6400-de8a-4274-8229-ee279cc35d4e")]
	public partial class IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The warping moment at the point load.")]
		public IfcWarpingMomentMeasure? WarpingMoment { get; set; }
	
	
		public IfcStructuralLoadSingleForceWarping()
		{
		}
	
	
	}
	
}
