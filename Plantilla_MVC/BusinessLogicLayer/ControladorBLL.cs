using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using ObjetosTransferencia.DTO;

namespace BusinessLogicLayer
{
    public class ControladorBLL
    {

        #region Atributos
        private List<ClienteDTO> lista;

        #endregion

        #region Constructores
        public ControladorBLL()
        {

        }
        #endregion

        #region Propiedades

        #endregion

        #region Metodos


        /// <summary>
        /// Pedir datos de la lista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public List<ClienteDTO> PedirListaClientes()
        {
            // TODO: llama al metodo que pide la lista de clientes
            //throw new Exception();
            AccesoDatosDAL accesoDAL = new AccesoDatosDAL();
            lista = accesoDAL.ListadoClientesNorthWind();
            return lista;
        }


        /// <summary>
        /// Pedir la lista de pedidos de un clientelista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<PedidoDTO> ListarPedidosCliente(String nombreCliente)
        {
            // TODO: llamar al metodo que lista los pedidos
            throw new Exception();
        }


        #endregion


    }
}
