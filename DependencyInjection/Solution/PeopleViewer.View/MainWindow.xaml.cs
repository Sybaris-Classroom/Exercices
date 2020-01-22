using PeopleViewer.Presentation;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PeopleViewModel ViewModel { get; set; }

        // TODO 2 : L'idée est de découpler la couche "01-Application View" de la couche "02-Presentation"
        // TODO 2-1 : Rajouter un paramètre au constructeur de type PeopleViewModel. Désormais, ce n'est plus de la responsabilité de la MainWindow que de créer cet objet...
        // TODO 2-2 : Supprimer la création du PeopleViewModel, et à la place stocker le nouveau paramètre. 
        public MainWindow(PeopleViewModel viewModel)
        {
            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.RefreshPeople();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ClearPeople();
        }
    }
}
