﻿using SistemaVentas.GUILayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    static class Program
    {
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmFactura());
        }
    }
}
