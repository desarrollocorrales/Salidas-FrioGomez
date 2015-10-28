using System;
using System.Collections.Generic;
using System.Data;
using SelectivasEnSucursales.DB;
using System.Linq;

namespace SelectivasEnSucursales.Modelos.SqliteDal
{
    public class SqliteDAL
    {
        public string AgregarArticulo(string clave, string nombre)
        {
            try
            {
                SalidaEntities Contexto = new SalidaEntities();
                articulos ArticuloNuevo = new articulos();
                ArticuloNuevo.clave = clave;
                ArticuloNuevo.nombre = nombre;
                Contexto.articulos.AddObject(ArticuloNuevo);
                Contexto.SaveChanges();

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }            
        }

        public List<ArticuloExtra> ObtenerArticulosExtra()
        {
            try
            {
                SalidaEntities Contexto = new SalidaEntities();
                List<ArticuloExtra> lstArticulosExtra = new List<ArticuloExtra>();
                List<articulos> lstArticulos = Contexto.articulos.OrderBy(o=>o.nombre).ToList();

                ArticuloExtra articuloex;
                foreach (articulos art in lstArticulos)
                {
                    articuloex = new ArticuloExtra();
                    articuloex.Clave = art.clave;
                    articuloex.Nombre = art.nombre;
                    lstArticulosExtra.Add(articuloex);
                }

                return lstArticulosExtra;
            }
            catch
            {
                return null;
            }            
        }

        public string EliminarArticulo(string clave)
        {
            try
            {
                SalidaEntities Contexto = new SalidaEntities();
                
                articulos articuloeliminar = Contexto.articulos.FirstOrDefault(o => o.clave == clave);
                Contexto.articulos.DeleteObject(articuloeliminar);
                Contexto.SaveChanges();

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
