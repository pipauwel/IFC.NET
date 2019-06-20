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
	[Guid("49277f4f-612d-4a85-9867-b4b6ab0e1750")]
	public enum IfcSolarDeviceTypeEnum
	{
		[Description("A device that converts solar radiation into thermal energy (heating water, etc.)." +
	    "")]
		SOLARCOLLECTOR = 1,
	
		[Description("A device that converts solar radiation into electric current.")]
		SOLARPANEL = 2,
	
		[Description("User-defined type.")]
		USERDEFINED = -1,
	
		[Description("Undefined type.")]
		NOTDEFINED = 0,
	
	}
}
