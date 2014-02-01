using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    //interface the all observer classes should implement
    public interface IObserver
    {
        void Notify(object anObject);
    }//IObserver

    //interface that all observable classes should implement
    public interface IObservable
    {
        void Register(IObserver anObserver);
        void UnRegister(IObserver anObserver);
    }//IObservable

}
