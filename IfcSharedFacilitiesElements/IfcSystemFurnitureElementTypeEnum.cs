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


namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("a6f535ba-a833-411b-bdf0-64c5772af3b1")]
	public enum IfcSystemFurnitureElementTypeEnum
	{
		[Description("Vertical panel used to divide work spaces.")]
		PANEL = 1,
	
		[Description("Workstation countertop.")]
		WORKSURFACE = 2,
	
		[Description("User-defined type.")]
		USERDEFINED = -1,
	
		[Description("Undefined type.")]
		NOTDEFINED = 0,
	
	}
}
