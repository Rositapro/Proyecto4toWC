﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using LiveCharts.Definitions.Charts;
using ScottPlot;
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using QuestPDF.Elements;
using ScottPlotColors = ScottPlot.Colors;
using PdfColors = QuestPDF.Helpers.Colors;

namespace ProyectoFinal4S
{
    public partial class FrmDataSet : Form
    {
        // Lista para guardar todas las filas leídas del CSV quesos
        private List<string[]> allRows = new List<string[]>();
        public FrmDataSet()
        {
            InitializeComponent();
            //// Asociar eventos
            this.Load += Form2_Load;
            btnFilterClass.Click += btnFilterClass_Click;
            //btnOpen.Click += btnOpen_Click;
            //btnSave.Click += btnSave_Click;
            //btnExport.Click += btnExport_Click;
        }
        // Evento Load: llenar ComboBox con opciones de clase
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbClassFilter.Items.Clear();
            cmbClassFilter.Items.AddRange(new string[] { "ALL", "STAR", "GALAXY", "QSO" });
            cmbClassFilter.SelectedIndex = 0; // Por defecto "TODOS"

            cmbExportFormat.Items.Clear();
            cmbExportFormat.Items.AddRange(new string[] { "CSV", "TXT", "JSON", "XML" });
            cmbExportFormat.SelectedIndex = 0;

            cmbDeleteType.Items.Clear();
            cmbDeleteType.Items.AddRange(new string[] { "Row", "Column" });
            cmbDeleteType.SelectedIndex = 0;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV and TXT files (*.csv;*.txt)|*.csv;*.txt";
            openFileDialog.Title = "Open file";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            try
            {
                var lines = File.ReadAllLines(filePath);

                dgvData.Rows.Clear();
                dgvData.Columns.Clear();
                allRows.Clear();

                if (lines.Length > 0)
                {
                    char delimiter = ',';

                    var headers = lines[0].Split(delimiter);
                    foreach (var header in headers)
                    {
                        dgvData.Columns.Add(header, header);
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        var row = lines[i].Split(delimiter);
                        allRows.Add(row);
                    }

                    DisplayRows(allRows);
                    CountData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }
        // Función para mostrar filas en DataGridView
        private void DisplayRows(List<string[]> rows)
        {
            dgvData.Rows.Clear();
            foreach (var row in rows)
            {
                dgvData.Rows.Add(row);
            }
        }
        private void btnFilterClass_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbClassFilter.SelectedItem.ToString();

            // Buscar índice de la columna "class"
            int indexClass = -1;
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col.HeaderText.Equals("class", StringComparison.OrdinalIgnoreCase))
                {
                    indexClass = col.Index;
                    break;
                }
            }

            if (indexClass == -1)
            {
                MessageBox.Show("No se encontró la columna 'class'.");
                return;
            }

            // Mostrar todas las filas si seleccionó "TODOS"
            if (filtroSeleccionado.Equals("TODOS", StringComparison.OrdinalIgnoreCase))
            {
                DisplayRows(allRows);
                return;
            }

            // Filtrar filas que coincidan exactamente con el filtro seleccionado (insensible a mayúsculas)
            var filasFiltradas = allRows.Where(row =>
                row.Length > indexClass &&
                row[indexClass].Equals(filtroSeleccionado, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            DisplayRows(filasFiltradas);
            CountData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cmbExportFormat.SelectedItem == null)
                return;

            string formato = cmbExportFormat.SelectedItem.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            switch (formato)
            {
                case "CSV":
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    saveFileDialog.Title = "Exportar a CSV";
                    break;
                case "TXT":
                    saveFileDialog.Filter = "TXT files (*.txt)|*.txt";
                    saveFileDialog.Title = "Exportar a TXT";
                    break;
                case "JSON":
                    saveFileDialog.Filter = "JSON files (*.json)|*.json";
                    saveFileDialog.Title = "Exportar a JSON";
                    break;
                case "XML":
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    saveFileDialog.Title = "Exportar a XML";
                    break;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;

            try
            {
                switch (formato)
                {
                    case "CSV":
                        GuardarArchivoCSV(ruta);
                        break;
                    case "TXT":
                        GuardarArchivoTXT(ruta);
                        break;
                    case "JSON":
                        ExportarAJSON(ruta);
                        break;
                    case "XML":
                        ExportarAXML(ruta);
                        break;
                }
                MessageBox.Show($"Archivo exportado correctamente en formato {formato}.");

                // Abrir el archivo con la aplicación predeterminada
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exportando archivo: " + ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|TXT files (*.txt)|*.txt";
            saveFileDialog.Title = "Save file";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;
            string ext = Path.GetExtension(ruta).ToLower();

            try
            {
                if (ext == ".txt")
                    GuardarArchivoTXT(ruta);
                else
                    GuardarArchivoCSV(ruta);

                MessageBox.Show("Archivo guardado correctamente.");

                // Abrir el archivo guardado automáticamente
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando archivo: " + ex.Message);
            }
        }

        public void GuardarArchivoCSV(string ruta)
        {
            var lines = new List<string>();

            var headers = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
            lines.Add(string.Join(",", headers));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>().Select(cell => EscapeForCsv(cell.Value?.ToString() ?? ""));
                    lines.Add(string.Join(",", cells));
                }
            }

            File.WriteAllLines(ruta, lines);
        }
        private string EscapeForCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }
            return value;
        }

        public void GuardarArchivoTXT(string ruta)
        {
            var lines = new List<string>();

            var headers = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
            lines.Add(string.Join("\t", headers));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                    lines.Add(string.Join("\t", cells));
                }
            }

            File.WriteAllLines(ruta, lines);
        }

        public void ExportarAJSON(string ruta)
        {
            var listaObjetos = new List<Dictionary<string, string>>();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dict = new Dictionary<string, string>();
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value?.ToString() ?? "";
                        dict[col.HeaderText] = valor;
                    }
                    listaObjetos.Add(dict);
                }
            }

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(listaObjetos, opciones);

            File.WriteAllText(ruta, jsonString);
        }

        public void ExportarAXML(string ruta)
        {
            var root = new XElement("Registros");

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var registro = new XElement("Registro");
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value?.ToString() ?? "";
                        registro.Add(new XElement(col.HeaderText, valor));
                    }
                    root.Add(registro);
                }
            }

            var doc = new XDocument(root);
            doc.Save(ruta);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentCell == null)
            {
                MessageBox.Show("Selecciona una celda para eliminar la fila o columna correspondiente.");
                return;
            }

            string opcion = cmbDeleteType.SelectedItem.ToString();

            if (opcion == "Fila")
            {
                int rowIndex = dgvData.CurrentCell.RowIndex;

                var confirm = MessageBox.Show($"¿Eliminar fila {rowIndex + 1}?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dgvData.Rows.RemoveAt(rowIndex);
                    CountData();
                    if (rowIndex < allRows.Count)
                        allRows.RemoveAt(rowIndex);
                }
            }
            else if (opcion == "Columna")
            {
                int colIndex = dgvData.CurrentCell.ColumnIndex;
                string colName = dgvData.Columns[colIndex].HeaderText;

                var confirm = MessageBox.Show($"¿Eliminar columna '{colName}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dgvData.Columns.RemoveAt(colIndex);

                    // Actualizar allRows para eliminar esa columna
                    for (int i = 0; i < allRows.Count; i++)
                    {
                        var listRow = allRows[i].ToList();
                        if (colIndex < listRow.Count)
                            listRow.RemoveAt(colIndex);
                        allRows[i] = listRow.ToArray();
                    }
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Seguro que quieres limpiar toda la tabla?",
                                       "Confirmar limpieza",
                                       MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dgvData.Rows.Clear();
                dgvData.Columns.Clear();
                allRows.Clear();
            }
        }

        private void cmbClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void FrmDataSet_Load(object sender, EventArgs e)
        {

        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            if (allRows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados.");
                return;
            }

            try
            {
                Dictionary<string, int> conteos = new Dictionary<string, int>
                {
                    { "STAR", 0 },
                    { "GALAXY", 0 },
                    { "QSO", 0 }
                };

                foreach (var fila in allRows)
                {
                    if (fila.Length > 13)
                    {
                        string clase = fila[13].Trim().ToUpper();

                        if (conteos.ContainsKey(clase))
                            conteos[clase]++;
                    }
                }

                string[] etiquetas = conteos.Keys.ToArray();
                double[] valores = conteos.Values.Select(c => (double)c).ToArray();

                GraphicPie(etiquetas, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar: " + ex.Message);
            }

        }


        private void GraphicPie(string[] etiquetas, double[] valores)
        {
            var plt = formsPlot1.Plot;
            plt.Clear();

            var pie = plt.Add.Pie(valores);

            double total = valores.Sum();
            pie.ExplodeFraction = 0.1;
            pie.SliceLabelDistance = 0.5;

            for (int i = 0; i < pie.Slices.Count && i < etiquetas.Length; i++)
            {
                pie.Slices[i].LabelFontSize = 16; // tamaño dentro del pastel
                pie.Slices[i].Label = $"{valores[i]}"; // etiqueta dentro del pastel
                pie.Slices[i].LegendText = $"{etiquetas[i]} ({valores[i] / total:p1})"; // leyenda
            }

            pie.DonutFraction = 0;
            pie.Rotation = ScottPlot.Angle.FromDegrees(0);

            // Ocultar ejes y grilla para estética limpia
            plt.Axes.Frameless();
            plt.HideGrid();

            formsPlot1.Refresh();
        }

        private void btnScatterPlot_Click(object sender, EventArgs e)
        {
            if (allRows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados.");
                return;
            }

            try
            {
                List<double> raList = new List<double>();
                List<double> decList = new List<double>();
                int count = 0;

                foreach (var fila in allRows)
                {
                    if (fila.Length > 13 && fila[13].Trim().ToUpper() == "STAR")
                    {
                        if (double.TryParse(fila[1], out double ra) &&
                            double.TryParse(fila[2], out double dec))
                        {
                            raList.Add(ra);
                            decList.Add(dec);
                            count++;
                        }

                        if (count >= 1000)
                            break;
                    }
                }

                var plt = formsPlot2.Plot;
                plt.Clear();

                var scatter = plt.Add.ScatterPoints(raList.ToArray(), decList.ToArray());
                scatter.MarkerSize = 5;
                scatter.Color = ScottPlot.Colors.Blue;
                scatter.MarkerShape = MarkerShape.FilledCircle;

                plt.Title("Primeras 1000 Estrellas (RA vs DEC)");
                plt.XLabel("Ascensión Recta (ra)");
                plt.YLabel("Declinación (dec)");

                plt.Axes.SetLimits(0, 360, -90, 90);
                formsPlot2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar estrellas: " + ex.Message);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";
            saveFileDialog.FileName = "export.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;

            try
            {
                var headers = dgvData.Columns.Cast<DataGridViewColumn>()
                                .Select(c => c.HeaderText)
                                .ToList();

                var rows = new List<List<string>>();

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => cell.Value?.ToString() ?? "")
                            .ToList();

                        rows.Add(cells);
                    }
                }

                QuestPDF.Settings.License = LicenseType.Community;

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(30);
                        page.Size(PageSizes.A4);
                        page.PageColor(QuestPDF.Helpers.Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(9));

                        page.Content().Table(table =>
                        {
                            // Definir columnas
                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < headers.Count; i++)
                                    columns.RelativeColumn();
                            });

                            // Encabezados
                            table.Header(header =>
                            {
                                foreach (var headerText in headers)
                                {
                                    header.Cell()
                                          .Background(QuestPDF.Helpers.Colors.Grey.Lighten2)
                                          .Padding(5)
                                          .Text(headerText)
                                          .SemiBold()
                                          .FontColor(QuestPDF.Helpers.Colors.Blue.Darken2);
                                }
                            });

                            // Celdas de datoss
                            foreach (var row in rows)
                            {
                                foreach (var cell in row)
                                {
                                    table.Cell().Padding(5).Text(cell);
                                }
                            }
                        });
                    });
                });

                document.GeneratePdf(ruta);

                MessageBox.Show("PDF exportado correctamente.");
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exportando a PDF: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string texto = txtSearch.Text.Trim().ToLower();
            int coincidencias = 0;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(texto))
                    {
                        cell.Style.BackColor = System.Drawing.Color.LightPink;
                        coincidencias++;
                    }
                    else
                    {
                        cell.Style.BackColor = System.Drawing.Color.White;
                    }
                }
            }

            MessageBox.Show($"{coincidencias} coincidencias encontradas.");
        }

        private void btnRedshift_Click(object sender, EventArgs e)
        {
            // Buscar índice de la columna "redshift"
            int indexRedshift = -1;

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col.HeaderText.Equals("redshift", StringComparison.OrdinalIgnoreCase))
                {
                    indexRedshift = col.Index;
                    break;
                }
            }

            if (indexRedshift == -1)
            {
                MessageBox.Show("No se encontró la columna 'redshift'.");
                return;
            }

            // Ordenar
            List<string[]> filasOrdenadas;

            if (rbClose.Checked)
            {
                filasOrdenadas = allRows
                    .Where(row => row.Length > indexRedshift && double.TryParse(row[indexRedshift], out _))
                    .OrderBy(row => double.Parse(row[indexRedshift]))
                    .ToList();

                MessageBox.Show("Sorted by closest objects (low redshift).");
            }
            else if (rbDistant.Checked)
            {
                filasOrdenadas = allRows
                    .Where(row => row.Length > indexRedshift && double.TryParse(row[indexRedshift], out _))
                    .OrderByDescending(row => double.Parse(row[indexRedshift]))
                    .ToList();

                MessageBox.Show("Sorted by most distant objects (high redshift).");
            }
            else
            {
                MessageBox.Show("Select an order option: Near or Far.");
                return;
            }

            // Mostrar resultado en el DataGridView
            DisplayRows(filasOrdenadas);
            CountData();
        }


        private void CountData()
        {
            int total = dgvData.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
            lblData.Text = $"Data: {total}";
        }

        private void rbClose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
