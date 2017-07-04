using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// NOME DO PROGRAMA: Calculadora 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: Utilizando os conceitos de formularios, foi implementada uma calculadora 
// com as quatros operações básicas
namespace Calculadora
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
