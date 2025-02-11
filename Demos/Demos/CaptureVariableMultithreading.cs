using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public static class CaptureVariableMultithreading
    {
        public static void Run()
        {
            Exemple1();
            Thread.Sleep(100);
            Console.WriteLine("------------");
            Exemple2();
        }

        static void Exemple1()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(() =>
                {
                    Console.WriteLine("Thread_" + i); // Ici, i est capturé par référence
                });
                thread.Start();
            }

            // Résultat attendu : 
            //  Thread_0
            //  Thread_1
            //  Thread_2
            //  Thread_3
            //  Thread_4

            // Mais en réalité : 
            //  Thread_3
            //  Thread_3
            //  Thread_4
            //  Thread_5
            //  Thread_5

            // Cela se produit parce que tous les threads accèdent à la même variable i, et lorsque les threads exécutent leur code,
            // la boucle for a déjà avancé ou terminé.
        }

        static void Exemple2()
        {
            for (int i = 0; i < 5; i++)
            {
                int threadNumber = i; // Variable capturée
                Thread thread = new Thread(() =>
                {
                    Console.WriteLine("Thread_" + threadNumber); // Variable capturée
                });
                thread.Start();
            }

            // Résultat attendu & en réalité : 
            //  Thread_0
            //  Thread_1
            //  Thread_2
            //  Thread_3
            //  Thread_4
            // Pourquoi cela fonctionne?
            //  En créant une nouvelle variable locale (threadNumber dans cet exemple), vous forcez l’expression lambda ou
            //  le délégué à capturer la valeur de la variable, et non la référence à la variable utilisée dans la boucle.
            //  Ainsi, chaque thread conserve la bonne valeur indépendamment des autres.
        }



        // -----------------------------------------------------------------------------------------------
        // Conclusion
        // - La variable de boucle dans for est partagée par toutes les itérations, ce qui pose un problème
        //   si elle est capturée par des threads.
        // - Une variable locale capturée permet de fixer la valeur actuelle à chaque itération, garantissant que
        //   chaque thread utilise la bonne valeur.
        // -----------------------------------------------------------------------------------------------
        // Exemple 1 : 
        //   ┌───────────────┐
        //   │   Variable i  │  (partagée par toutes les itérations)
        //   └───────────────┘
        //           │
        //           │ Référence capturée par les threads
        //           │
        //    ┌──────┴──────┐
        //    │             │
        //    ▼             ▼
        //Thread 1      Thread 2
        // (i = 5)      (i = 5)
        // -----------------------------------------------------------------------------------------------
        // Exemple 2 : 
        //          ┌───────────────────────┐
        //          │ i(variable de boucle) │
        //          └───────────────────────┘
        //                       │
        //                       ▼
        //             Nouvelle variable locale
        //┌──────────────┐  ┌──────────────┐  ┌──────────────┐
        //│ threadNumber │  │ threadNumber │  │ threadNumber │
        //│   (0)        │  │   (1)        │  │   (2)        │
        //└──────────────┘  └──────────────┘  └──────────────┘
        //       │                 │                 │
        //       │                 │                 │
        //       ▼                 ▼                 ▼        
        //   Thread 1           Thread 2          Thread 3
        //(threadNumber = 0)(threadNumber = 1)(threadNumber = 2)
    }
}
