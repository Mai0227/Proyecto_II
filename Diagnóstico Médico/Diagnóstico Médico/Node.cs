using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//Proyecto final 
//Mailyn Rojas Gonzalez 

namespace Diagnóstico_Médico
{



    public class Node
    {
        public string pregunta;
        public Node si;
        public Node no;

        public Node(string preg)
        {
            pregunta = preg;
        }
    }

    class DecisionTree
    {
        private Node root;

        public DecisionTree()
        {
            // Inicializar el árbol de decisiones
            root = new Node("¿Qué síntomas presentas?");
            root.si = new Node("¿También presentas fiebre?");
            root.no = new Node("¿También presentas congestión nasal?");
            root.no.si = new Node("¿También presentas tos persistente?");
            root.no.no = new Node("¿También presentas dolor de cabeza?");
            root.no.no.si = new Node("¿También presentas dolor de garganta?");
            root.no.no.no = new Node("¿También presentas fatiga?");
            root.no.no.no.si = new Node("Tu resultado médico es que presentas una alergia.");
            root.no.no.no.no = new Node("Tu resultado médico es que presentas bronquitis.");
            root.no.no.no.no.si = new Node("Tu resultado médico es que presentas sinusitis.");
            root.no.no.no.no.no = new Node("Tu resultado médico es que presentas resfriado común.");
        }

        // Método para iniciar el diagnóstico
        public void Diagnostico()
        {
            Console.WriteLine("Bienvenido al sistema de diagnóstico médico");
            //Decision(root);//////////
        }

        // Método  para evaluar las decisiones que va a tomar el paciente 
        private void Decision()
        {
            // Pregunta inicial
            Console.WriteLine("¿El paciente tiene fiebre?");
            string Decision = Console.ReadLine().ToLower();

            // Comenzar el diagnóstico basado en la respuesta
            if (Decision == "sí")//
            {
                // Gripe o Sinusitis
                Console.WriteLine("¿El paciente tiene dolor de cabeza?");
                Decision = Console.ReadLine().ToLower();
                if (Decision == "sí")
                {
                    // Gripe
                    Console.WriteLine("El paciente podría tener Gripe.");
                    Console.WriteLine("Tratamiento: descanso, líquidos, medicamentos para reducir la fiebre y aliviar los síntomas.");
                }
                else
                {
                    // Sinusitis
                    Console.WriteLine("¿El paciente tiene dolor facial?");
                    Decision = Console.ReadLine().ToLower();
                    if (Decision == "sí")
                    {
                        // Sinusitis
                        Console.WriteLine("El paciente podría tener Sinusitis.");
                        Console.WriteLine("Tratamiento: analgésicos, descongestionantes, irrigación nasal, humidificadores.");
                    }
                    else
                    {
                        // Gripe
                        Console.WriteLine("El paciente podría tener Gripe.");
                        Console.WriteLine("Tratamiento: descanso, líquidos, medicamentos para reducir la fiebre y aliviar los síntomas.");
                    }
                }
            }
            else
            {
                // Resfriado común, Alergia o Bronquitis
                Console.WriteLine("¿El paciente tiene congestión nasal?");
                Decision = Console.ReadLine().ToLower();
                if (Decision == "sí")
                {
                    // Resfriado común
                    Console.WriteLine("¿El paciente tiene estornudos?");
                    Decision = Console.ReadLine().ToLower();
                    if (Decision == "sí")
                    {
                        // Resfriado común
                        Console.WriteLine("El paciente podría tener un resfriado común.");
                        Console.WriteLine("Tratamiento: Se le recomienda al paciente tener descanso,consumir líquidos y medicamentos recetados por su Doctor, para aliviar la congestión y la tos.");
                        return;
                    }
                    else
                    {
                        // Sinusitis
                        Console.WriteLine("El paciente podría tener Sinusitis.");
                        Console.WriteLine("Tratamiento: Se le recomienda conumir analgésicos, descongestionantes, irrigación nasal, humidificadores, recetados por su Doctor");
                        return; 
                        
                    }

                }
                else
                {
                    // Alergia o Bronquitis
                    Console.WriteLine("¿El paciente tiene tos persistente?");
                    Decision = Console.ReadLine().ToLower();
                    if (Decision == "sí")
                    {
                        // Bronquitis
                        Console.WriteLine("El paciente podría tener Bronquitis.");
                        Console.WriteLine("Tratamiento: Se le recomienda al paciente tener descanso,consumir bastantes  líquidos, inhaladores broncodilatadores y medicamentos recetados por su medico para aliviar la tos");
                        return;

                    }
                    else
                    {
                        // Alergia
                        Console.WriteLine("El paciente podría tener Alergia.");
                        Console.WriteLine("Tratamiento:Se le recomienda al paciente consumir antihistamínicos, descongestionantes recetados por el Doctor y se le recomienda  evitar los alérgenos");
                        return;
                    }
                }
            }
            //DecisionTree tree = new DecisionTree(root);

            //// Evaluar el árbol de decisión
            //Console.WriteLine("Responde 'si' o 'no' a las siguientes preguntas:");
            //string mejorOpcion = tree.Decision();
            //Console.WriteLine($"La mejor opción es: {mejorOpcion}");

            //// Imprimir el árbol en orden
            //Console.WriteLine("Árbol binario en orden:");
            //Console.Read();
            //return; // Detiene la ejecución aquí
        }
    }

}