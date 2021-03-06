﻿using NorthwindNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTablaCategorias();
        }

        private void cargarTablaCategorias()
        {
            try
            {
                dataGridView1.DataSource = new CategoryDelegado().consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = new CategoryDelegado()
                                    .insertar(txtNombre.Text, txtDescripcion.Text);
                cargarTablaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CategoryDelegado().consultar(txtFiltro.Text);
        }
    }
}
