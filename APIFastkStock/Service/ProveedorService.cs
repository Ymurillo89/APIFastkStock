using APIFastkStock.Models.Interfaz;
using APIFastkStock.Models.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APIFastkStock.Service
{
    public class ProveedorService
    {
        private IDapperConsultasDB dapper;

        public ProveedorService(IDapperConsultasDB dapper)
        {
            this.dapper = dapper;
        }

        public List<GetProveedores> GetProveedor()
        {
            var parametros = new DynamicParameters();
            //parametros.Add("@Option", "GetLocation");
            //parametros.Add("@Block", block);
            return dapper.GetAll<GetProveedores>($"SPLlenarDatagridProveedor", parametros, commandType: CommandType.StoredProcedure);
        }

        public int SetProveedor(List<GetProveedores> setProveedor)
        {
            foreach (var item in setProveedor)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@idNit", item.idNit);
                parameters.Add("@strNombre", item.strNombre);
                parameters.Add("@bigC_Bancaria", item.bigintC_Bancaria);
                parameters.Add("@bigTelefono", item.bigintTelefono);
                parameters.Add("@bigCelular", item.bigintMovil);



                dapper.Insert<int>($"SPGuardarProveedor", parameters, commandType: System.Data.CommandType.StoredProcedure);

            }



            return 1;
        }

    }
}
