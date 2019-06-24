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
	[Guid("0fa62e78-ff06-4166-8248-de91902a2313")]
	public enum IfcCostScheduleTypeEnum
	{
		BUDGET = 1,
	
		COSTPLAN = 2,
	
		ESTIMATE = 3,
	
		TENDER = 4,
	
		PRICEDBILLOFQUANTITIES = 5,
	
		UNPRICEDBILLOFQUANTITIES = 6,
	
		SCHEDULEOFRATES = 7,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
