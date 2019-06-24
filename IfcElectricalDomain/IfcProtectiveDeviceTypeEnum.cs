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


namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("46116d76-16c1-4e48-9c71-5a22626083c4")]
	public enum IfcProtectiveDeviceTypeEnum
	{
		FUSEDISCONNECTOR = 1,
	
		CIRCUITBREAKER = 2,
	
		EARTHFAILUREDEVICE = 3,
	
		RESIDUALCURRENTCIRCUITBREAKER = 4,
	
		RESIDUALCURRENTSWITCH = 5,
	
		VARISTOR = 6,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
