using System.Windows;
using PeopleViewer.Presentation;
using PersonReader.Service;
using PersonReader.CSV;
using PersonReader.Caching;
using Ninject;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObject();
            Application.Current.MainWindow.Show();
        }

        IKernel Container = new StandardKernel(); // Ceci créé le container pour l'IOC

        private void ComposeObject()
        {
            // Application.Current.MainWindow = new MainWindow();
            // TODO 3 : C'est désormais l'application qui va créer et choisir le repository  ainsi que le Viewmodel
            // TODO 4-3 : Au lieu d'intancier un ServiceReader, instancier un CSVReader
            //var repository = new CSVReader();
            // TODO 3-1 : Créer le repository (i.e. instancier ServiceReader)
            //var repository = new ServiceReader();
            // TODO 3-2 : Créer le view model (PeopleViewModel)
            //var viewModel = new PeopleViewModel(repository);
            // TODO 3-3 : Vérifier que le code compile et que l'application a les mêmes fonctionnalitées
            //Application.Current.MainWindow = new MainWindow(viewModel);
            // TODO 4-4 : Tester et vérifier qu'une personne supplémentaire est trouvée
            // TODO 5-3 : Au lieu d'intancier un CSVReader, instancier un CachingReader qui va utiliser un ServiceReader
            //var serviceReader = new ServiceReader();
            //var repository = new CachingReader(serviceReader);
            // TODO 5-4 : Tester, couper le service web "People.Service". Vérifier qu'il est encore possible de récupérer les personnes encore pendant 30 secondes (durée du cache)
            // TODO 8 : Utiliser un container IOC (NInject dans notre exemple)
            // TODO 8-1 : Rajouter le package Nuget "Ninject"
            // TODO 8-2 : Créer un champ dans la classe App avec cette déclaration : IKernel Container = new StandardKernel(); // Ceci créé le container pour l'IOC
            // TODO 8-3 : Commenter le contenu de cette méthode (ComposeObject), et rajouter le code suivant : Application.Current.MainWindow = Container.Get<MainWindow>();
            // TODO 8-4 : Rajouter avant la précédente ligne de code ajoutée, la configuration du container : Container.Bind<IRepository>().To<ServiceReader>(); // Configure le container pour qu'une demande d'un IRepository fournisse un ServiceReader
            // TODO 8-5 : Vérifier que l'application fonctionne toujours correctement
            // TODO 8-6 : Changer le binding du container pour fournir un CSVReader à la place du ServiceReader
            // TODO 8-7 : Configurer le binding pour qu'il utilise "InSingletonScope" (C.F. https://github.com/ninject/Ninject/wiki/Object-Scopes)
            // TODO 8-8 : Vérifier que l'application fonctionne toujours correctement et qu'elle utilise le fichier csv
            //Application.Current.MainWindow = new MainWindow(viewModel);

            //Container.Bind<IRepository>().To<ServiceReader>();
            Container.Bind<IRepository>().To<CSVReader>().InSingletonScope();
            Application.Current.MainWindow = Container.Get<MainWindow>();
        }
    }
}
