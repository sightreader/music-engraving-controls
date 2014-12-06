using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Model.MVVM
{
    public abstract class ListViewModel<TCollection, TElement> : ViewModel where TCollection : IEnumerable<TElement>, new()
    {
        private TCollection _elements;
        public TCollection Elements
        {
            get { return _elements; }
            set { _elements = value; OnPropertyChanged(() => Elements); }
        }

        private ListViewModelStates _state;
        public ListViewModelStates State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged(() => State); }
        }

        protected ListViewModel()
        {
            Elements = new TCollection();
            State = ListViewModelStates.Idle;
        }
    }
}
