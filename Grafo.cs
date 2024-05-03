using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Grafo x = new Grafo();

x.inserirVertice('a');
 x.inserirAresta('a', 'b');
 x.inserirAresta('b', 'c', 2);
foreach (Vertice? vertice in x.vertices)
{
    Console.Write(vertice.elemento+ " ");
}
class Vertice
    {
        public char elemento;
        List<Vertice?> vizinhos;
        List<int> pesos;
        Vertice? anc;
        public Vertice(char a)
        {
            this.elemento = a;
            vizinhos = new List<Vertice?>();
            pesos = new List<int>();
            anc = null;
        }
        public void addVizinho(Vertice dt, int peso = 1)
        {
            vizinhos.Add(dt);
            pesos.Add(peso);
        }
    }
    class Grafo
    {
        public List<Vertice?> vertices = new List<Vertice?>();
        public void inserirVertice(char a)
        {
            foreach (Vertice? vertice in vertices)
            {
                if (vertice?.elemento == a)
                {
                    Console.WriteLine("Já existente");
                    return;
                }
            }
            vertices.Add(new Vertice(a));
        }
        public void inserirAresta(char origem, char destino, int peso = 1)
        {
            Vertice? or = null;
            Vertice? dt = null;
            foreach (Vertice? vertice in vertices)
            {
                if (vertice.elemento == origem)
                {
                    or = vertice;
                }
                if (vertice.elemento == destino)
                {
                    dt = vertice;
                }
            }
            if (dt == null)
            {
                dt = new Vertice(destino);
                vertices.Add(dt);
            }
            or.addVizinho(dt, peso);
        }
    }

//    class Principal
//    {
//        public static void Main(string[] args)
//        {
//            Grafo x = new Grafo();

//            //x.inserirVertice('a');
//            // x.inserirAresta('a', 'b');
//            // x.inserirAresta('b', 'c', 2);
//            foreach (Vertice vertice in x.vertices)
//            {
//                Console.WriteLine(vertice.elemento);
//            }
//        }
//    }
//}