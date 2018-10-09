using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    // Déclaration du type du délégué
    internal delegate void MonDelegate();

    public static class Delegates
    {
        // Implémentation du délégué classique
        static void monImplementationDeDelegate()
        {
            Console.WriteLine("Mon implementation classique");
        }

        // Implémentation du délégué classique avec 1 argument
        static void monImplementationDeDelegate(string chaine)
        {
            Console.WriteLine("Mon implementation classique avec 1 parametre : " + chaine);
        }

        public static void Run()
        {
            // 1 - Délégué classique
            // Assignation
            MonDelegate monDelegate = monImplementationDeDelegate;
            // Appel au délégué.
            monDelegate();

            // 2 - Délégué anonyme
            // Exemple de delegué anonyme
            MonDelegate monDelegateAnonyme = delegate ()
            {
                // Implémentation du délégué anonyme
                Console.WriteLine("Mon implementation anonyme");
            };
            // Appel au délégué anonyme
            monDelegateAnonyme();

            // 3 - Expression Lambda
            MonDelegate monDelegateLambda = () =>
            {
                // Implémentation du délégué Lambda
                Console.WriteLine("Mon implementation Lambda");
            };
            // Appel au délégué Lambda
            monDelegateLambda();


            // 4 - Utilisation des delegués définis par le framework
            // Assignation
            Action monDelegateAction = monImplementationDeDelegate;
            // Appel au délégué.
            monDelegate();

            // 5 - Utilisation d'une action avec un parametre
            Action<string> monDelegateActionString = monImplementationDeDelegate;
            monDelegateActionString("Jean-Pierre");

            // 6 - Utilisation d'une fonction
            Func<string, int> maFunc = delegate (string chaine)
            {
                Console.WriteLine("Mon implementation Func");
                return 0;
            };
            int result = maFunc("Fonction");

            // 7 - Function + Lambda
            Func<int, int, int> maFuncLamda = (int a, int b) =>
            {
                Console.WriteLine("Mon implementation FuncLamda");
                return a + b;
            };
            int resultmaFuncLamda = maFuncLamda(2, 3);
            Console.WriteLine("Resultat = " + resultmaFuncLamda);

            // 8 - Expression Lambda passée au framework dotnet
            List<int> l = new List<int>() { 4, 6, 8, 2, 1 };
            //bool resultExist = l.Exists(x => l.Contains(8));
            //bool resultExist = l.Exists(x => { return l.Contains(8); });
            //bool resultExist = l.Exists(delegate (int x) { return l.Contains(8); });
            listeCapturee = l;
            bool resultExist = l.Exists(monImplementationExist);

            // 9 - Exemple 2 :
            //var listeInferieurA5 = l.Where(x => x < 5);
            var listeInferieurA5 = from x in l where x < 5 select x;
            Console.WriteLine("Liste <5");
            foreach (var item in listeInferieurA5)
                Console.WriteLine("  " + item);

            Console.WriteLine("Exemple de Predicat : " + resultExist);

        }

        // Pour l'exemple N°8, le compilateur génére un champ private caché pour "capturer" la variable
        private static List<int> listeCapturee = null;

        private static bool monImplementationExist(int obj)
        {
            return listeCapturee.Contains(8);
        }
    }
}
