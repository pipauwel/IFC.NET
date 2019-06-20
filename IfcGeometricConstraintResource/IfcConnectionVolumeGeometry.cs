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


namespace BuildingSmart.IFC.IfcGeometricConstraintResource
{
	[Guid("0b7a3b78-5844-48d7-8cfa-af35fa085e67")]
	public partial class IfcConnectionVolumeGeometry : IfcConnectionGeometry
	{
		[DataMember(Order = 0)] 
		[Description("Volume at which related object overlaps with the relating element, given in the LCS of the relating element.")]
		[Required()]
		public IfcSolidOrShell VolumeOnRelatingElement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Volume at which related object overlaps with the relating element, given in the LCS of the related element.")]
		public IfcSolidOrShell VolumeOnRelatedElement { get; set; }
	
	
		public IfcConnectionVolumeGeometry(IfcSolidOrShell volumeOnRelatingElement)
		{
			this.VolumeOnRelatingElement = volumeOnRelatingElement;
		}
	
	
	}
	
}
