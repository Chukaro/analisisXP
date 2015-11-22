using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisXP
{
    public partial class BuscarCliente : UserControl
    {
        public BuscarCliente()
        {
            InitializeComponent();

            dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
            dgv_ListClient.Columns[0].Visible = false;
        }
    }
}
