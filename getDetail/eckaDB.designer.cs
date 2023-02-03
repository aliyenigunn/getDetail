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

namespace getDetail
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="eckaMuhasebe")]
	public partial class eckaDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPazYakitlar(PazYakitlar instance);
    partial void UpdatePazYakitlar(PazYakitlar instance);
    partial void DeletePazYakitlar(PazYakitlar instance);
    partial void InsertPazAraclar(PazAraclar instance);
    partial void UpdatePazAraclar(PazAraclar instance);
    partial void DeletePazAraclar(PazAraclar instance);
    #endregion
		
		public eckaDBDataContext() : 
				base(global::getDetail.Properties.Settings.Default.eckaMuhasebeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public eckaDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eckaDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eckaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eckaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PazYakitlar> PazYakitlars
		{
			get
			{
				return this.GetTable<PazYakitlar>();
			}
		}
		
		public System.Data.Linq.Table<PazAraclar> PazAraclars
		{
			get
			{
				return this.GetTable<PazAraclar>();
			}
		}
		
		public System.Data.Linq.Table<VW_ARACYAKITDETAY> VW_ARACYAKITDETAYs
		{
			get
			{
				return this.GetTable<VW_ARACYAKITDETAY>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PazYakitlar")]
	public partial class PazYakitlar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _yakitID;
		
		private System.Nullable<int> _aracID;
		
		private System.Nullable<decimal> _litre;
		
		private System.Nullable<decimal> _tutar;
		
		private string _tarih;
		
		private System.Nullable<int> _ay;
		
		private System.Nullable<int> _periyod;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnyakitIDChanging(int value);
    partial void OnyakitIDChanged();
    partial void OnaracIDChanging(System.Nullable<int> value);
    partial void OnaracIDChanged();
    partial void OnlitreChanging(System.Nullable<decimal> value);
    partial void OnlitreChanged();
    partial void OntutarChanging(System.Nullable<decimal> value);
    partial void OntutarChanged();
    partial void OntarihChanging(string value);
    partial void OntarihChanged();
    partial void OnayChanging(System.Nullable<int> value);
    partial void OnayChanged();
    partial void OnperiyodChanging(System.Nullable<int> value);
    partial void OnperiyodChanged();
    #endregion
		
		public PazYakitlar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yakitID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int yakitID
		{
			get
			{
				return this._yakitID;
			}
			set
			{
				if ((this._yakitID != value))
				{
					this.OnyakitIDChanging(value);
					this.SendPropertyChanging();
					this._yakitID = value;
					this.SendPropertyChanged("yakitID");
					this.OnyakitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracID", DbType="Int")]
		public System.Nullable<int> aracID
		{
			get
			{
				return this._aracID;
			}
			set
			{
				if ((this._aracID != value))
				{
					this.OnaracIDChanging(value);
					this.SendPropertyChanging();
					this._aracID = value;
					this.SendPropertyChanged("aracID");
					this.OnaracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_litre", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> litre
		{
			get
			{
				return this._litre;
			}
			set
			{
				if ((this._litre != value))
				{
					this.OnlitreChanging(value);
					this.SendPropertyChanging();
					this._litre = value;
					this.SendPropertyChanged("litre");
					this.OnlitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tutar", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> tutar
		{
			get
			{
				return this._tutar;
			}
			set
			{
				if ((this._tutar != value))
				{
					this.OntutarChanging(value);
					this.SendPropertyChanging();
					this._tutar = value;
					this.SendPropertyChanged("tutar");
					this.OntutarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="NVarChar(20)")]
		public string tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ay", DbType="Int")]
		public System.Nullable<int> ay
		{
			get
			{
				return this._ay;
			}
			set
			{
				if ((this._ay != value))
				{
					this.OnayChanging(value);
					this.SendPropertyChanging();
					this._ay = value;
					this.SendPropertyChanged("ay");
					this.OnayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_periyod", DbType="Int")]
		public System.Nullable<int> periyod
		{
			get
			{
				return this._periyod;
			}
			set
			{
				if ((this._periyod != value))
				{
					this.OnperiyodChanging(value);
					this.SendPropertyChanging();
					this._periyod = value;
					this.SendPropertyChanged("periyod");
					this.OnperiyodChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PazAraclar")]
	public partial class PazAraclar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _aracID;
		
		private string _aracPlaka;
		
		private string _aracAciklama;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnaracIDChanging(int value);
    partial void OnaracIDChanged();
    partial void OnaracPlakaChanging(string value);
    partial void OnaracPlakaChanged();
    partial void OnaracAciklamaChanging(string value);
    partial void OnaracAciklamaChanged();
    #endregion
		
		public PazAraclar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int aracID
		{
			get
			{
				return this._aracID;
			}
			set
			{
				if ((this._aracID != value))
				{
					this.OnaracIDChanging(value);
					this.SendPropertyChanging();
					this._aracID = value;
					this.SendPropertyChanged("aracID");
					this.OnaracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracPlaka", DbType="NVarChar(50)")]
		public string aracPlaka
		{
			get
			{
				return this._aracPlaka;
			}
			set
			{
				if ((this._aracPlaka != value))
				{
					this.OnaracPlakaChanging(value);
					this.SendPropertyChanging();
					this._aracPlaka = value;
					this.SendPropertyChanged("aracPlaka");
					this.OnaracPlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracAciklama", DbType="NVarChar(50)")]
		public string aracAciklama
		{
			get
			{
				return this._aracAciklama;
			}
			set
			{
				if ((this._aracAciklama != value))
				{
					this.OnaracAciklamaChanging(value);
					this.SendPropertyChanging();
					this._aracAciklama = value;
					this.SendPropertyChanged("aracAciklama");
					this.OnaracAciklamaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VW_ARACYAKITDETAY")]
	public partial class VW_ARACYAKITDETAY
	{
		
		private int _yakitID;
		
		private System.Nullable<int> _aracID;
		
		private string _aracPlaka;
		
		private string _aracAciklama;
		
		private System.Nullable<decimal> _litre;
		
		private System.Nullable<decimal> _tutar;
		
		private string _AY;
		
		private string _PERIYOD;
		
		public VW_ARACYAKITDETAY()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yakitID", DbType="Int NOT NULL")]
		public int yakitID
		{
			get
			{
				return this._yakitID;
			}
			set
			{
				if ((this._yakitID != value))
				{
					this._yakitID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracID", DbType="Int")]
		public System.Nullable<int> aracID
		{
			get
			{
				return this._aracID;
			}
			set
			{
				if ((this._aracID != value))
				{
					this._aracID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracPlaka", DbType="NVarChar(50)")]
		public string aracPlaka
		{
			get
			{
				return this._aracPlaka;
			}
			set
			{
				if ((this._aracPlaka != value))
				{
					this._aracPlaka = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aracAciklama", DbType="NVarChar(50)")]
		public string aracAciklama
		{
			get
			{
				return this._aracAciklama;
			}
			set
			{
				if ((this._aracAciklama != value))
				{
					this._aracAciklama = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_litre", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> litre
		{
			get
			{
				return this._litre;
			}
			set
			{
				if ((this._litre != value))
				{
					this._litre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tutar", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> tutar
		{
			get
			{
				return this._tutar;
			}
			set
			{
				if ((this._tutar != value))
				{
					this._tutar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AY", DbType="VarChar(7)")]
		public string AY
		{
			get
			{
				return this._AY;
			}
			set
			{
				if ((this._AY != value))
				{
					this._AY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERIYOD", DbType="VarChar(14)")]
		public string PERIYOD
		{
			get
			{
				return this._PERIYOD;
			}
			set
			{
				if ((this._PERIYOD != value))
				{
					this._PERIYOD = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
