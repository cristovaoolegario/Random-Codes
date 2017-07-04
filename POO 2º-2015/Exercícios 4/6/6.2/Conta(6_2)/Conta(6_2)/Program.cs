using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//
// NOME DO PROGRAMA: Conta(6_1) 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 08/11/2015 
// DESCRIÇÃO: Utilizando os conceitos de formularios, tratamentos de erros e eventos foi implementada 
// o programa Conta(6_1) um aplicativo melhorado do exercício 7.2 do lab2  
namespace Conta_6_2_
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
            Application.Run(new Menu());
        }
    }
}
