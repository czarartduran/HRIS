﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="database_tamplate")]
	public partial class hrisDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public hrisDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["database_tamplateConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public hrisDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hrisDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hrisDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hrisDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_RegisterTimeLog")]
		public int sp_RegisterTimeLog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EID", DbType="BigInt")] System.Nullable<long> eID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date_Registered", DbType="DateTime")] System.Nullable<System.DateTime> date_Registered, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Time_Registered", DbType="DateTime")] System.Nullable<System.DateTime> time_Registered)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eID, date_Registered, time_Registered);
			return ((int)(result.ReturnValue));
		}
	}
}
#pragma warning restore 1591
