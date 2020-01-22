using Common;
using PersonReader.Service;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer.Presentation
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        // TODO 1-3 : Changer le type ServiceReader en IRepository pour abstraire le type de stockage de données utilisé.
        protected IRepository Reader;

        private IEnumerable<Person> _people;
        public IEnumerable<Person> People
        {
            get { return _people; }
            set
            {
                if (_people == value)
                    return;
                _people = value;
                RaisePropertyChanged("People");
            }
        }

        // TODO 1-4 : Rajouter un paramètre au constructeur de type IRepository. Désormais, ce n'est plus de la responsabilité du ViewModel que de créer le repository...
        // TODO 1-5 : Supprimer la création du ServiceReader, et à la place stocker le nouveau paramètre. Cette étape va "casser" la compilation.
        public PeopleViewModel(IRepository reader)
        {
            Reader = reader;
        }

        public void RefreshPeople()
        {
            People = Reader.GetPeople();
        }

        public void ClearPeople()
        {
            People = new List<Person>();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
