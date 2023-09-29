using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Core
{
    class Dfs
    {
        public class node
        {
            public string valor;
            public node left;
            public node right;
            public node(string val)
            { //Creo un constructor para mi objeto, el cuál añade el valor deseado y deja nulos los vértices
                valor = val;
                left = null;
                right = null;
            }

        }
        public static void depthFirstValues(node root) //Partimos del nodo raíz
        {
            if (root == null)
            {
                return;
            }
            List<node> result = new List<node>();
            Stack<node> stack = new Stack<node>();

            stack.Push(root); //Añadimos el nodo a la pila
            while (stack.Count() > 0)
            {
                node current = stack.Pop(); //Obtiene el último nodo agregado y lo quita de la pila (así funciona Stack [últimas entradas, primeras salidas])

                //Console.WriteLine(current.valor);
                result.Add(current);

                if (current.right != null) { stack.Push(current.right); } //Sí existe un nodo derecha, lo asigna a la pila para recorrerlo próximamente
                if (current.left != null) { stack.Push(current.left); } //Sí existe un nodo izquierda, lo asigna a la pila para recorrerlo próximamente
            }
            //Con este algoritmo se recorre un arbol binario
            string[] resultado = result.Select(x => x.valor).ToArray();
            Console.WriteLine($"{string.Join(",", resultado)}");
        }
    }
}
