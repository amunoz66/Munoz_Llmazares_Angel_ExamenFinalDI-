using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ListaPedidosUC : UserControl
    {
        private List<PedidoDTO> listaPedidos;
        private DataGridView dg;
        public ListaPedidosUC(String nombreCliente)
        {
            InitializeComponent();
            // TODO: haz la peticion de los clientes y asociala a la lista y cargalo en el DataGridView
            dg = new DataGridView();
            dg.DataSource(dGV_Pedidos);
         
        }

        public List<PedidoDTO> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }


    }
}
