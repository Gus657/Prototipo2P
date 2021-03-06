﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace Prototipo2P
{
	public partial class MDI_Proyecto2P : Form
	{
		private int childFormNumber = 0;

		public MDI_Proyecto2P()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Ventana " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void MDI_Proyecto2P_Load(object sender, EventArgs e)
		{
			frm_login log = new frm_login();
			log.ShowDialog();
			
		}

		private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
		{

			MessageBox.Show(lbl_usuario.Text);
			MDI_Seguridad seg = new MDI_Seguridad(lbl_usuario.Text);
			seg.Show();
		}

		private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clientes cli = new Clientes(lbl_usuario.Text);
			cli.Show();
		}

		private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Marca cli = new Marca(lbl_usuario.Text);
			cli.Show();
		}

		private void BodegasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Linea cli = new Linea(lbl_usuario.Text);
			cli.Show();
		}

		private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Productos pr = new Productos(lbl_usuario.Text);
			pr.Show();
		}

		private void FacturacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Rentas pr = new Rentas(lbl_usuario.Text);
			pr.Show();
		}
	}
}
