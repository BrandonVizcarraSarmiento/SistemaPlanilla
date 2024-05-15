using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Vistas_Cargo;
using CapaPresentacion.Vistas_Banco;
using CapaPresentacion.Vistas_FondoPension;
using CapaPresentacion.Vistas_Conceptos;
using CapaPresentacion.Vistas_Empleados;
using CapaPresentacion.Vistas_Asistencias;
using CapaPresentacion.Vistas_Planillas;
using CapaPresentacion.Vistas_Usuarios;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            ContraerMenu();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ContraerMenu();
        }
        private void ContraerMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                imgLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expande el menu
                panelMenu.Width = 230;
                imgLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Obtener la lista de permisos del usuario actual
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.Id);

            // Recorrer todos los controles en el panelMenu
            foreach (Control control in panelMenu.Controls)
            {
                // Verificar si el control es un IconButton
                if (control is IconButton iconButton)
                {
                    // Si el botón es diferente de btnSalir y el usuario no tiene permiso para este botón, ocultarlo
                    if (iconButton.Name != "btnSalir" && !ListaPermisos.Any(m => m.NombreMenu == iconButton.Name))
                    {
                        iconButton.Visible = false;
                    }
                }
            }

            // Establecer el texto del label de usuario
            lblUsuario.Text = usuarioActual.Nombre;
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            lblhora.Visible = false;
            lblFecha.Visible = false;
            pcbLogoImagen.Visible = false;

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(98, 102, 244); // Restaurar el color del botón anterior
                MenuActivo.ForeColor = SystemColors.ButtonHighlight; // Restaurar el color de texto del botón anterior
            }
            menu.BackColor = Color.FromArgb(109, 136, 255);
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void btnBanco_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmBanco());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmCargo());
        }

        private void btnFondoPension_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmFondoPension());
        }

        private void btnConceptos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmConceptos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEmpleados());
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmAsistencias(usuarioActual));
        }

        private void btnPlanillas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPlanillas(usuarioActual));
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmUsuarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            FormularioActivo.Close();
            MenuActivo.BackColor = Color.FromArgb(98, 102, 244); // Restaurar el color del botón anterior
            MenuActivo.ForeColor = SystemColors.ButtonHighlight; // Restaurar el color de texto del botón anterior

            lblhora.Visible = true;
            lblFecha.Visible = true;
            pcbLogoImagen.Visible = true;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }
    }
}
