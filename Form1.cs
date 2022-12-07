using System;
using System.Collections;
using System.Net;
using System.Text;

namespace d_TPsLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // EXO ARRAYLIST:
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList.Add(12.56);
            myList.Add("toto");
            myList.Add(null);
            myList.Add('a');
            myList.Add(1234);
            // VAR important ici car type différents
            foreach (var i in myList)
            {
                MessageBox.Show(Convert.ToString(i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList { 12.56, "toto", null, 'a', 1234 };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            créer un tableau de 5 int
            créer une ArrayList avec 3 double
            ajouter le tableau dans l’ArrayList avec la méthode AddRange
            créer une autre ArrayList avec 3 int et l’ajouter à l’ArrayList précédente(AddRange)
            */

            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 1.5, 2.5, 3.5 };
            //addrange demande une collection, array semble être une collection.
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 2, 3, 4 };
            maListe.AddRange(myList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //utiliser une boucle for pour calculer la moyenne des éléments de l’ArrayList créée en Q3(la
            //dernière, celle qui contient 8 int et 3 double)
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5 , 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20 , 15 };
            maListe.AddRange(myList);
            double somme = 0;
            foreach (var item in maListe)
            {
                somme+= Convert.ToDouble(item);
            }
            MessageBox.Show(Convert.ToString(somme / maListe.Count));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5, 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20, 15 };
            maListe.AddRange(myList);
            double somme = 0;
            foreach (var item in maListe)
            {
                somme += Convert.ToDouble(item);
            }
            MessageBox.Show(Convert.ToString(somme / maListe.Count));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5, 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20, 15 };
            maListe.AddRange(myList);

            maListe.Insert(0, 50);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5, 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20, 15 };
            maListe.AddRange(myList);

            maListe.Insert(4, 10);
            maListe.Insert(4, 12);
            maListe.Insert(4, 15);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5, 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20, 15 };
            maListe.AddRange(myList);

            maListe.RemoveAt(3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[5];
            ArrayList myList = new ArrayList { 10.5, 10.5, 20.5, 20.5 };
            myList.AddRange(myInt);
            ArrayList maListe = new ArrayList { 10, 15, 20, 15 };
            maListe.AddRange(myList);

            maListe.RemoveAt(maListe.Count);
            maListe.RemoveAt(maListe.Count);
            maListe.RemoveAt(maListe.Count);
        }

        // EXO LISTE:
        private void button10_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1);nombres.Add(2);nombres.Add(3);nombres.Add(5);nombres.Add(7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);
            int somme = 0;
            for (int i = 0; i < maListeInt.Count; i++)
            {
                somme+= maListeInt[i];
            }
            MessageBox.Show(Convert.ToString("Moyenne: "+ (somme / maListeInt.Count)));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);
            int somme = 0;
            foreach (var item in maListeInt)
            {
                somme += Convert.ToInt32(item);
            }
            MessageBox.Show(Convert.ToString("Moyenne: " + (somme / maListeInt.Count)));
        }

        /*
        idem Q5 en utilisant la méthode LINQ Foreach et une expression lambda
         */
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);

            maListeInt.Insert(0, 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);

            maListeInt.Remove(3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<int> nombres = new List<int>();
            nombres.Add(1); nombres.Add(2); nombres.Add(3); nombres.Add(5); nombres.Add(7);
            var maListeInt = new List<int>() { 1, 2, 3, 4, 5 };
            maListeInt.AddRange(nombres);

            bool haveZero = false;
            bool haveSeven = false;
            for ( int i = 0; i < maListeInt.Count; i++ ) 
            {
                if (maListeInt[i] == 0) haveZero = true;
                if (maListeInt[i] == 7) haveSeven = true;
                MessageBox.Show(Convert.ToString(maListeInt[i]));
            }
            MessageBox.Show("Contient 0 ? " + haveZero);
            MessageBox.Show("Contient 7 ? " + haveSeven);            
        }
    }
}