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


namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("94dc877b-0f35-43d9-97af-b81360e8f4e0")]
	public enum IfcPermitTypeEnum
	{
		[Description("Enables access to an identified area.")]
		ACCESS = 1,
	
		[Description("Enables work to proceed by getting regulatory permissions.")]
		BUILDING = 2,
	
		[Description("Enables work to be carried out in an identified area.")]
		WORK = 3,
	
		[Description("User-defined type.")]
		USERDEFINED = -1,
	
		[Description("Undefined type.")]
		NOTDEFINED = 0,
	
	}
}
