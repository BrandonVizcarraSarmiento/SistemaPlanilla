using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CapaEntidad;

namespace CapaPresentacion.Vistas_Planillas
{
    public partial class FrmPlanillas : Form
    {
        private Usuario usuarioActual;
        private CN_Planilla cnPlanilla;

        public FrmPlanillas(Usuario usuario)
        {
            InitializeComponent();
            CargarComboBoxMeses();
            CargarComboBoxAños();
            cnPlanilla = new CN_Planilla(); // Instanciar la clase de la capa de negocio
            MostrarTodosLosDatos();
            usuarioActual = usuario;
        }

        private void CargarComboBoxMeses()
        {
            // Agregar los números de los meses al ComboBox, del 1 al 12
            for (int mes = 1; mes <= 12; mes++)
            {
                cmbBoxMesPlanilla.Items.Add(mes);
            }
        }

        private void CargarComboBoxAños()
        {
            // Obtener el año actual
            int añoActual = DateTime.Now.Year;

            // Agregar los años al ComboBox, por ejemplo, desde el año actual hasta 10 años atrás
            for (int año = añoActual; año >= añoActual - 10; año--)
            {
                cmbBoxAñoPlanilla.Items.Add(año);
            }
        }

        private void btnCargarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener mes y año seleccionados en los ComboBox
                int mes = Convert.ToInt32(cmbBoxMesPlanilla.SelectedItem);
                int ano = Convert.ToInt32(cmbBoxAñoPlanilla.SelectedItem);

                // Instanciar la clase de la capa de negocio
                CN_Planilla cnPlanilla = new CN_Planilla();

                // Obtener los datos de la planilla
                DataTable planilla = cnPlanilla.ObtenerSalariosNetos(mes, ano);

                // Mostrar los datos en un DataGridView u otro control apropiado en tu formulario
                // Por ejemplo, si tienes un DataGridView llamado dtgvPlanilla:
                dtgvPlanilla.DataSource = planilla;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrando un mensaje de error al usuario
                MessageBox.Show("Error al cargar la planilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTodosLosDatos()
        {
            try
            {
                // Obtener los datos de la planilla
                DataTable planilla = cnPlanilla.ObtenerDatosPlanilla();

                // Mostrar los datos en el DataGridView
                dtgvPlanilla.DataSource = planilla;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrando un mensaje de error al usuario
                MessageBox.Show("Error al cargar la planilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDFPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar el cuadro de diálogo para guardar el archivo PDF
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Planilla_{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));
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
                        // Crear un Chunk para el título con estilo de fuente personalizado
                        Chunk tituloChunk = new Chunk("Planilla ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24f));

                        // Crear un párrafo para el título y agregar el Chunk
                        Paragraph title = new Paragraph(tituloChunk);
                        title.Alignment = Element.ALIGN_CENTER;

                        // Agregar el título al documento
                        document.Add(title);

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.ETLOGO, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(50, 50);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(document.LeftMargin, document.Top - 50);
                        document.Add(img);
                        document.Add(new iTextSharp.text.Chunk("\n"));

                        // Agregar el nombre del usuario al PDF
                        Paragraph usuario = new Paragraph();
                        usuario.Add(new Chunk("Usuario: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        usuario.Add(usuarioActual.Nombre);

                        document.Add(usuario);

                        // Obtener la fecha y hora actual
                        DateTime fechaActual = DateTime.Now;

                        // Crear un párrafo para mostrar la fecha
                        Paragraph fecha = new Paragraph();
                        fecha.Add(new Chunk("Fecha de creación del reporte: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        fecha.Add(fechaActual.ToString("dd/MM/yyyy"));
                        document.Add(fecha);

                        // Agregar un espacio en blanco
                        document.Add(new Paragraph(""));

                        // Crear un párrafo para mostrar la hora
                        Paragraph hora = new Paragraph();
                        hora.Add(new Chunk("Hora de creación del reporte: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        hora.Add(fechaActual.ToString("HH:mm:ss"));
                        document.Add(hora);

                        document.Add(new iTextSharp.text.Chunk("\n"));

                        // Crear una tabla para mostrar los datos
                        PdfPTable table = new PdfPTable(dtgvPlanilla.Columns.Count);
                        table.WidthPercentage = 100; // Establecer el ancho de la tabla al 100% del ancho de la página

                        // Establecer propiedades de la tabla
                        table.DefaultCell.BorderWidth = 1;
                        table.DefaultCell.Padding = 5;
                        table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


                        // Agregar encabezados de columna
                        for (int i = 0; i < dtgvPlanilla.Columns.Count; i++)
                        {
                            table.AddCell(new PdfPCell(new Phrase(dtgvPlanilla.Columns[i].HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                        }

                        // Agregar filas y celdas con datos
                        for (int i = 0; i < dtgvPlanilla.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgvPlanilla.Columns.Count; j++)
                            {
                                if (dtgvPlanilla.Rows[i].Cells[j].Value != null)
                                {
                                    table.AddCell(new PdfPCell(new Phrase(dtgvPlanilla.Rows[i].Cells[j].Value.ToString())));
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
