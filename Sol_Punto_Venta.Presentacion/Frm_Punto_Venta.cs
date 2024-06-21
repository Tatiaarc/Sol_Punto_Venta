using Sol_Punto_Venta.Negocio;
using System;
using System.Windows.Forms;

namespace Sol_Punto_Venta.Presentacion
{
    public partial class Frm_Punto_Venta : Form
    {
        public Frm_Punto_Venta()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int nCodigo = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_pv()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_Listado.Columns[1].Width = 340;
            Dgv_Listado.Columns[1].HeaderText = "PUNTO DE VENTA";

        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Punto_Venta.Listado_pv(cTexto);
                this.Formato_pv();
                Lbl_total_registros.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Limpiart_Texto()
        {
            Txt_descripcion.Text = "";
        }
        private void Estado_Botones_Principales(bool lEstado)
        {
            Btn_Nuevo.Enabled = lEstado;
            Btn_Actualizar.Enabled = lEstado;
            Btn_Eliminar.Enabled = lEstado;
            Btn_Reporte.Enabled = lEstado;
            Btn_Salir.Enabled = lEstado;
        }
        private void Estado_Texto(bool lEstado)
        {
            Txt_descripcion.ReadOnly = !lEstado;
        }
        private void Estado_Botones_Procesos(bool lestado)
        {
            Btn_Cancelar.Visible = lestado;
            Btn_Guardar.Visible = lestado;
            Btn_Retornar.Visible = !lestado;


        }
        #endregion
        private void Frm_Punto_Venta_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Limpiart_Texto();
            this.Estado_Texto(true);
            Tbc_principal.SelectedIndex = 1;
            Txt_descripcion.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpiart_Texto();
            this.Estado_Texto(false);
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            Tbc_principal.SelectedIndex = 0;
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            Tbc_principal.SelectedIndex = 0;
        }
    }
}
