﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace El_Buen_Precio
{
    public partial class Empleados : MetroFramework.Forms.MetroForm
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleado pempleados = new empleado();
            pempleados.Nombre_Empleado = txt_nombre.Text.Trim();
            pempleados.Apellido_Empleado = txt_apellido.Text.Trim();
            pempleados.Numero_Telf_Empleado = txt_telefono.Text.Trim();
            pempleados.Estado_Civil = txt_estado_civil.Text.Trim();
            pempleados.Direccion = txt_direccion.Text;

            int resultado = empleadoDal.agregar(pempleados);
            if (resultado > 0)
            {
                MessageBox.Show("Empleado Agregado con Exito!!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Empleado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
