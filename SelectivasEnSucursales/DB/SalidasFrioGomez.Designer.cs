﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SelectivasEnSucursales.DB
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class SalidaEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto SalidaEntities usando la cadena de conexión encontrada en la sección 'SalidaEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public SalidaEntities() : base("name=SalidaEntities", "SalidaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto SalidaEntities.
        /// </summary>
        public SalidaEntities(string connectionString) : base(connectionString, "SalidaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto SalidaEntities.
        /// </summary>
        public SalidaEntities(EntityConnection connection) : base(connection, "SalidaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<articulos> articulos
        {
            get
            {
                if ((_articulos == null))
                {
                    _articulos = base.CreateObjectSet<articulos>("articulos");
                }
                return _articulos;
            }
        }
        private ObjectSet<articulos> _articulos;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet articulos. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToarticulos(articulos articulos)
        {
            base.AddObject("articulos", articulos);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SalidasFrioGomezModel", Name="articulos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class articulos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto articulos.
        /// </summary>
        /// <param name="clave">Valor inicial de la propiedad clave.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        public static articulos Createarticulos(global::System.String clave, global::System.String nombre)
        {
            articulos articulos = new articulos();
            articulos.clave = clave;
            articulos.nombre = nombre;
            return articulos;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String clave
        {
            get
            {
                return _clave;
            }
            set
            {
                if (_clave != value)
                {
                    OnclaveChanging(value);
                    ReportPropertyChanging("clave");
                    _clave = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("clave");
                    OnclaveChanged();
                }
            }
        }
        private global::System.String _clave;
        partial void OnclaveChanging(global::System.String value);
        partial void OnclaveChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();

        #endregion

    
    }

    #endregion

    
}
