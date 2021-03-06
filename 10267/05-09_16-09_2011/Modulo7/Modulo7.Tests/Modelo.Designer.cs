﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Modulo7.Tests
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MOC10267Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MOC10267Entities object using the connection string found in the 'MOC10267Entities' section of the application configuration file.
        /// </summary>
        public MOC10267Entities() : base("name=MOC10267Entities", "MOC10267Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MOC10267Entities object.
        /// </summary>
        public MOC10267Entities(string connectionString) : base(connectionString, "MOC10267Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MOC10267Entities object.
        /// </summary>
        public MOC10267Entities(EntityConnection connection) : base(connection, "MOC10267Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Usuario> Usuarios
        {
            get
            {
                if ((_Usuarios == null))
                {
                    _Usuarios = base.CreateObjectSet<Usuario>("Usuarios");
                }
                return _Usuarios;
            }
        }
        private ObjectSet<Usuario> _Usuarios;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Usuarios EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsuarios(Usuario usuario)
        {
            base.AddObject("Usuarios", usuario);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MOC10267Model", Name="Usuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Usuario : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Usuario object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="senha">Initial value of the Senha property.</param>
        public static Usuario CreateUsuario(global::System.Int32 id, global::System.String email, global::System.String senha)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            usuario.Email = email;
            usuario.Senha = senha;
            return usuario;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                OnSenhaChanging(value);
                ReportPropertyChanging("Senha");
                _Senha = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Senha");
                OnSenhaChanged();
            }
        }
        private global::System.String _Senha;
        partial void OnSenhaChanging(global::System.String value);
        partial void OnSenhaChanged();

        #endregion
    
    }

    #endregion
    
}
