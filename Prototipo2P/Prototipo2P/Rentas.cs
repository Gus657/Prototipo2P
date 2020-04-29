using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo2P
{
	public partial class Rentas : Form
	{
		
		string usuario = "";
		conexion cn = new conexion();
		int realTotal = 0;

		public Rentas(string usuarioActivo)
		{
			InitializeComponent();
			usuario = usuarioActivo;
			combo1.llenarse("clientes","codigo_cliente");
			combo2.llenarse("vendedores", "codigo_vendedor");
			combo3.llenarse("productos", "codigo_producto");
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd";

		}
		public OdbcDataAdapter LlenarTabla(string table, string ID)
		{
			string sql = "SELECT * FROM "+table+" WHERE codigo_encabezado = '"+ID+"';";
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar("FilmMagic"));
			return dataTable;
		}
		public void ejecutarQuery(string query)// ejecuta un query en la BD
		{
			try
			{
				OdbcCommand consulta = new OdbcCommand(query, cn.conectar("FilmMagic"));
				consulta.ExecuteNonQuery();
			}
			catch (OdbcException ex)
			{
				Console.WriteLine(ex.Errors.ToString());
				Console.WriteLine("---------------------------------------");
				Console.WriteLine(query);
			}

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void Navegador1_Load(object sender, EventArgs e)
		{
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			int devolucion = 0;

			string sql = "INSERT INTO factura VALUES(NULL,'"+combo1.obtener()+"', '"+combo2.obtener()+"','"+dateTimePicker1.Text.ToString()+"', 1)";
			ejecutarQuery(sql);
			MessageBox.Show("Guardado");
			groupBox1.Enabled = false;
			groupBox2.Enabled = true;
			button3.Enabled = true;
			dataGridView1.Enabled = true;

		}
		public string ObtenerPrecio(string no)
		{
			string id = "";
			OdbcCommand command = new OdbcCommand("SELECT precio FROM productos WHERE codigo_producto = '" + no + "' ;", cn.conectar("FilmMagic"));
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{

				id = reader.GetValue(0).ToString();
			}


			return id;
		}
		public string Obtenerencabezado()
		{
			string id = "";
			OdbcCommand command = new OdbcCommand("SELECT MAX(codigo_encabezado) FROM factura;", cn.conectar("FilmMagic"));
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{

				id = reader.GetValue(0).ToString();
			}


			return id;
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			string precio = ObtenerPrecio(combo3.obtener());
			int total = Convert.ToInt32(precio) * Convert.ToInt32(textBox5.Text.ToString());
			realTotal += total;
			lbltotal.Text = realTotal.ToString();
			dataGridView1.Rows.Add(textBox5.Text.ToString(), combo3.obtener(), precio,total);
		}

		private void Combo3_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void Combo3_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		
		}

		private void Combo3_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

		void exportarTabla(DataGridView dtg, string name)
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdftable = new PdfPTable(dtg.Columns.Count);
			pdftable.DefaultCell.Padding = 3;
			pdftable.WidthPercentage = 100;
			pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdftable.DefaultCell.BorderWidth = 1;

			iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
			foreach (DataGridViewColumn col in dtg.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
				pdftable.AddCell(cell);
			}

			foreach (DataGridViewRow row in dtg.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
				}
			}


			var savefeldialoge = new SaveFileDialog();
			savefeldialoge.FileName = name;
			savefeldialoge.DefaultExt = ".pdf";
			if (savefeldialoge.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefeldialoge.FileName, FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
					PdfWriter.GetInstance(pdfdoc, stream);
					pdfdoc.Open();
					pdfdoc.Add(pdftable);
					pdfdoc.Close();
					stream.Close();
				}

			}


		}
		private void Button3_Click(object sender, EventArgs e)
		{
			string sql = "";
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				sql = "INSERT INTO factura_det VALUES(NULL,'" + Obtenerencabezado() + "', '" + row.Cells[1].Value.ToString()+ "'," + textBox5.Text + ")";
				ejecutarQuery(sql);
			}
			MessageBox.Show("Guardados");
			OdbcDataAdapter dt = LlenarTabla("factura_det", Obtenerencabezado());
			DataTable table = new DataTable();
			dt.Fill(table);
			dataGridView2.DataSource = table;
			MessageBox.Show("Generando Comprobante");
			exportarTabla(dataGridView2, Obtenerencabezado());
			dataGridView1.Rows.Clear();
			textBox5.Text = "";
			groupBox1.Enabled = true;
			groupBox2.Enabled = false;
			dataGridView1.Enabled = false;
			button3.Enabled = false;
			MessageBox.Show("Comprobante Generado");
		}
	}
}
