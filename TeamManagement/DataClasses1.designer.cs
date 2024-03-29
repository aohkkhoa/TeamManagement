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

namespace TeamManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TeamManagement")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment_tb(Department_tb instance);
    partial void UpdateDepartment_tb(Department_tb instance);
    partial void DeleteDepartment_tb(Department_tb instance);
    partial void InsertTeam_tb(Team_tb instance);
    partial void UpdateTeam_tb(Team_tb instance);
    partial void DeleteTeam_tb(Team_tb instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::TeamManagement.Properties.Settings.Default.TeamManagementConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department_tb> Department_tbs
		{
			get
			{
				return this.GetTable<Department_tb>();
			}
		}
		
		public System.Data.Linq.Table<Team_tb> Team_tbs
		{
			get
			{
				return this.GetTable<Team_tb>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department_tb")]
	public partial class Department_tb : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _department_id;
		
		private string _department_name;
		
		private string _descriptions;
		
		private EntitySet<Team_tb> _Team_tbs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ondepartment_idChanging(string value);
    partial void Ondepartment_idChanged();
    partial void Ondepartment_nameChanging(string value);
    partial void Ondepartment_nameChanged();
    partial void OndescriptionsChanging(string value);
    partial void OndescriptionsChanged();
    #endregion
		
		public Department_tb()
		{
			this._Team_tbs = new EntitySet<Team_tb>(new Action<Team_tb>(this.attach_Team_tbs), new Action<Team_tb>(this.detach_Team_tbs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_id", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string department_id
		{
			get
			{
				return this._department_id;
			}
			set
			{
				if ((this._department_id != value))
				{
					this.Ondepartment_idChanging(value);
					this.SendPropertyChanging();
					this._department_id = value;
					this.SendPropertyChanged("department_id");
					this.Ondepartment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string department_name
		{
			get
			{
				return this._department_name;
			}
			set
			{
				if ((this._department_name != value))
				{
					this.Ondepartment_nameChanging(value);
					this.SendPropertyChanging();
					this._department_name = value;
					this.SendPropertyChanged("department_name");
					this.Ondepartment_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descriptions", DbType="VarChar(100)")]
		public string descriptions
		{
			get
			{
				return this._descriptions;
			}
			set
			{
				if ((this._descriptions != value))
				{
					this.OndescriptionsChanging(value);
					this.SendPropertyChanging();
					this._descriptions = value;
					this.SendPropertyChanged("descriptions");
					this.OndescriptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_tb_Team_tb", Storage="_Team_tbs", ThisKey="department_id", OtherKey="department_id")]
		public EntitySet<Team_tb> Team_tbs
		{
			get
			{
				return this._Team_tbs;
			}
			set
			{
				this._Team_tbs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Team_tbs(Team_tb entity)
		{
			this.SendPropertyChanging();
			entity.Department_tb = this;
		}
		
		private void detach_Team_tbs(Team_tb entity)
		{
			this.SendPropertyChanging();
			entity.Department_tb = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Team_tb")]
	public partial class Team_tb : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _team_id;
		
		private string _team_name;
		
		private string _department_id;
		
		private EntityRef<Department_tb> _Department_tb;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onteam_idChanging(string value);
    partial void Onteam_idChanged();
    partial void Onteam_nameChanging(string value);
    partial void Onteam_nameChanged();
    partial void Ondepartment_idChanging(string value);
    partial void Ondepartment_idChanged();
    #endregion
		
		public Team_tb()
		{
			this._Department_tb = default(EntityRef<Department_tb>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_team_id", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string team_id
		{
			get
			{
				return this._team_id;
			}
			set
			{
				if ((this._team_id != value))
				{
					this.Onteam_idChanging(value);
					this.SendPropertyChanging();
					this._team_id = value;
					this.SendPropertyChanged("team_id");
					this.Onteam_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_team_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string team_name
		{
			get
			{
				return this._team_name;
			}
			set
			{
				if ((this._team_name != value))
				{
					this.Onteam_nameChanging(value);
					this.SendPropertyChanging();
					this._team_name = value;
					this.SendPropertyChanged("team_name");
					this.Onteam_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_id", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string department_id
		{
			get
			{
				return this._department_id;
			}
			set
			{
				if ((this._department_id != value))
				{
					if (this._Department_tb.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondepartment_idChanging(value);
					this.SendPropertyChanging();
					this._department_id = value;
					this.SendPropertyChanged("department_id");
					this.Ondepartment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_tb_Team_tb", Storage="_Department_tb", ThisKey="department_id", OtherKey="department_id", IsForeignKey=true)]
		public Department_tb Department_tb
		{
			get
			{
				return this._Department_tb.Entity;
			}
			set
			{
				Department_tb previousValue = this._Department_tb.Entity;
				if (((previousValue != value) 
							|| (this._Department_tb.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department_tb.Entity = null;
						previousValue.Team_tbs.Remove(this);
					}
					this._Department_tb.Entity = value;
					if ((value != null))
					{
						value.Team_tbs.Add(this);
						this._department_id = value.department_id;
					}
					else
					{
						this._department_id = default(string);
					}
					this.SendPropertyChanged("Department_tb");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
