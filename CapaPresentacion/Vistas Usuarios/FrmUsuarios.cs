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
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo"});
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo"});
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dtgvUsuario.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusquedaUsuario.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusquedaUsuario.DisplayMember = "Texto";
            cboBusquedaUsuario.ValueMember = "Valor";
            cboBusquedaUsuario.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dtgvUsuario.Rows.Add(new object[] {"",item.Id,item.Nombre,item.Correo,item.Clave,
                    item.oRol.Id,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Correo = txtNombre.Text,
                Clave = txtClave.Text,
                oRol = new Rol() { Id = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.Id == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {

                    dtgvUsuario.Rows.Add(new object[] {"",idusuariogenerado,txtNombre.Text,txtCorreo.Text,txtClave.Text,
                       ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                       ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()});

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dtgvUsuario.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtId.Text = "0";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        private void dtgvUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dtgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvUsuario.Columns["btnseleccionar"].Index)
            {
                int indice = e.RowIndex;

                txtindice.Text = indice.ToString();
                txtId.Text = dtgvUsuario.Rows[indice].Cells["Id"].Value.ToString();
                txtNombre.Text = dtgvUsuario.Rows[indice].Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dtgvUsuario.Rows[indice].Cells["Correo"].Value.ToString();
                txtClave.Text = dtgvUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                txtConfirmarClave.Text = dtgvUsuario.Rows[indice].Cells["Clave"].Value.ToString();

                foreach (OpcionCombo oc in cboRol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgvUsuario.Rows[indice].Cells["IdRol"].Value))
                    {
                        cboRol.SelectedItem = oc;
                        break;
                    }
                }

                foreach (OpcionCombo oc in cboEstado.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgvUsuario.Rows[indice].Cells["EstadoValor"].Value))
                    {
                        cboEstado.SelectedItem = oc;
                        break;
                    }
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        Id = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dtgvUsuario.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusquedaUsuario.SelectedItem).Valor.ToString();

            if (dtgvUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvUsuario.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaUsuario.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusquedaUsuario.Text = "";
            foreach (DataGridViewRow row in dtgvUsuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
