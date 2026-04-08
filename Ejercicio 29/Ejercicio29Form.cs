using Ejercicio_29;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaClases
{
    public partial class Ejercicio29Form : Form
    {
        //            29.Simulación de Cajero Automático(Enfoque en Objetos y Registros)
        //Enunciado Adaptado: Desarrolla una aplicación con interfaz gráfica para simular un cajero automático.
        //Crea las clases Usuario y Cuenta.El formulario debe tener controles para ingresar un monto y botones
        //para "Depositar" y "Retirar", validando que no se retire más del saldo disponible.Utiliza un DataGridView
        //para mostrar el historial de transacciones de la sesión actual(Tipo de Movimiento, Monto, y Saldo Resultante).
        public Ejercicio29Form()
        {
            InitializeComponent();
        }

        public List<Usuario> DevolverListaUsuarios()
        {
            List<Usuario> us1 = new List<Usuario>();
            us1.Add(new Usuario(001, "Lucas", "Pico"));
            us1.Add(new Usuario(002, "Ana", "Gomez"));
            us1.Add(new Usuario(003, "Carlos", "Ruiz"));
            us1.Add(new Usuario(004, "Maria", "Velez"));
            us1.Add(new Usuario(005, "Luis", "Perez"));
            us1.Add(new Usuario(006, "Roberto", "Mendez"));
            return us1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = DevolverListaUsuarios();

            


        }
    }
}
