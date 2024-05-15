using CapaEntidad;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas_Asistencias
{
    public partial class FrmAsistencias : Form
    {
        public FrmAsistencias()
        {
            InitializeComponent();
            CargarComboBoxMeses();
            CargarComboBoxAños();
        }
        private void CargarComboBoxMeses()
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                cmbBoxMesAsistencia.Items.Add(mes);
            }
        }
        private void CargarComboBoxAños()
        {
            int añoActual = DateTime.Now.Year;

            for (int año = añoActual; año >= añoActual - 10; año--)
            {
                cmbBoxAñoAsistencia.Items.Add(año);
            }
        }
        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                CN_Asistencia cnAsistencia = new CN_Asistencia();
                DataTable dtAsistencia = cnAsistencia.ObtenerDatosAsistencia();
                dtgvAsistencia.DataSource = dtAsistencia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiarAsistencias_Click(object sender, EventArgs e)
        {
            if (dtgvAsistencia.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dtgvAsistencia.SelectedRows[0];

                // Elimina la fila seleccionada
                dtgvAsistencia.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para limpiar.");
            }
        }
        private void btnGuardarAsistencias_Click(object sender, EventArgs e)
        {
            if (dtgvAsistencia.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea guardar o actualizar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea guardar o actualizar este registro?", "Confirmar Guardar/Actualizar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dtgvAsistencia.SelectedRows[0];

                    // Crear un objeto Asistencia y asignarle los valores desde la fila seleccionada
                    Asistencia asistencia = new Asistencia();
                    asistencia.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    asistencia.Mes = Convert.ToInt32(selectedRow.Cells["Mes"].Value);
                    asistencia.Ano = Convert.ToInt32(selectedRow.Cells["Ano"].Value);
                    asistencia.DiasLaborados = Convert.ToInt32(selectedRow.Cells["DiasLaborados"].Value);
                    asistencia.DiasNoLaborados = Convert.ToInt32(selectedRow.Cells["DiasNoLaborados"].Value);
                    asistencia.DiasEfectivos = Convert.ToInt32(selectedRow.Cells["DiasEfectivos"].Value);

                    // Aquí puedes asignar la propiedad oEmpleado si es necesario
                    asistencia.oEmpleado = new Empleado(); // Ejemplo de inicialización de oEmpleado

                    // Llamar al método para guardar o actualizar la asistencia
                    CN_Asistencia.GuardarOActualizarAsistencia(asistencia);

                    // Volver a cargar los datos en el DataGridView (opcional, si es necesario refrescar la vista)
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para guardar o actualizar.");
            }
        }
        private void btnCargarAsistencias_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el mes y año seleccionados en los ComboBox
                int mesSeleccionado = Convert.ToInt32(cmbBoxMesAsistencia.SelectedItem);
                int añoSeleccionado = Convert.ToInt32(cmbBoxAñoAsistencia.SelectedItem);

                // Llamar al método para obtener los datos de asistencia filtrados por mes y año
                CN_Asistencia cnAsistencia = new CN_Asistencia();
                DataTable dtAsistencia = cnAsistencia.ObtenerDatosAsistenciaPorMesYAño(mesSeleccionado, añoSeleccionado);
                // Verificar si se encontraron datos
                if (dtAsistencia.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron datos
                    MessageBox.Show("No se encontraron datos para el mes " + mesSeleccionado + " y año " + añoSeleccionado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Mostrar los datos en el DataGridView
                dtgvAsistencia.DataSource = dtAsistencia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDFAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar el cuadro de diálogo para guardar el archivo PDF
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Asistencias_{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));
                savefile.Filter = "PDF files (*.pdf)|*.pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    // Crear un nuevo documento PDF
                    using (FileStream fs = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document document = new Document();
                        PdfWriter.GetInstance(document, fs);
                        document.Open();

                        // Agregar título al documento
                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("ASISTENCIAS DE EMPLEADOS");
                        title.Alignment = Element.ALIGN_CENTER;
                        title.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                        document.Add(title);

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.ETLOGO, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(50, 50);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(document.LeftMargin, document.Top - 50);
                        document.Add(img);

                        // Agregar un espacio en blanco
                        document.Add(new iTextSharp.text.Chunk("\n"));

                        // Crear una tabla para mostrar los datos
                        PdfPTable table = new PdfPTable(dtgvAsistencia.Columns.Count);
                        table.WidthPercentage = 100; // Establecer el ancho de la tabla al 100% del ancho de la página

                        // Establecer propiedades de la tabla
                        table.DefaultCell.BorderWidth = 1;
                        table.DefaultCell.Padding = 5;
                        table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


                        // Agregar encabezados de columna
                        for (int i = 0; i < dtgvAsistencia.Columns.Count; i++)
                        {
                            table.AddCell(new PdfPCell(new Phrase(dtgvAsistencia.Columns[i].HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                        }

                        // Agregar filas y celdas con datos
                        for (int i = 0; i < dtgvAsistencia.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgvAsistencia.Columns.Count; j++)
                            {
                                if (dtgvAsistencia.Rows[i].Cells[j].Value != null)
                                {
                                    table.AddCell(new PdfPCell(new Phrase(dtgvAsistencia.Rows[i].Cells[j].Value.ToString())));
                                }
                            }
                        }

                        // Agregar la tabla al documento
                        document.Add(table);

                        // Cerrar el documento
                        document.Close();
                    }

                    MessageBox.Show("Archivo PDF creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}