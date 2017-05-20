using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Lo primero que hay que hacer es importar la libreria del tema
using MetroFramework;

namespace El_Buen_Precio
{
    // Luego tenes que sustituir el   : Form   por: MetroFramework.Forms.MetroForm
    // y con eso cambia el tema... luego tendrias que mover un poco los elementos en el editor
    // por que cambia un poco el tamaño de algunos controles
    public partial class buscar_productos : MetroFramework.Forms.MetroForm
    {
        public buscar_productos()
        {
            InitializeComponent();
        }

        
    }
}
