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


namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("bf6d0f45-b574-4318-aa51-e300ba47d079")]
	public enum IfcResourceConsumptionEnum
	{
		CONSUMED = 1,
	
		PARTIALLYCONSUMED = 2,
	
		NOTCONSUMED = 3,
	
		OCCUPIED = 4,
	
		PARTIALLYOCCUPIED = 5,
	
		NOTOCCUPIED = 6,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
