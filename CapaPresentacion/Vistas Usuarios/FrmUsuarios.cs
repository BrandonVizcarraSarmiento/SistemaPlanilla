using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Vistas_Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cdoEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo"});
            cdoEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo"});
            cdoEstado.DisplayMember = "Texto";
            cdoEstado.ValueMember = "Valor";
            cdoEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;
        }
    }
}
