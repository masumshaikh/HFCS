using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ObserverPattern
{
    //helper class that implements observable interface
    public class ObservableImpl : IObservable
    {
        //container to store the observer instance (is not synchronized for this example)
        protected Hashtable _observerContainer=new Hashtable();
   
        //add the observer
        public void Register(IObserver anObserver)
        {
            _observerContainer.Add(anObserver,anObserver); 
        }//Register
      
        //remove the observer
        public void UnRegister(IObserver anObserver)
        {
            _observerContainer.Remove(anObserver); 
        }//UnRegister

        //common method to notify all the observers
        public void NotifyObservers(object anObject)
        { 
            //enumeration the observers and invoke their notify method
            foreach(IObserver anObserver in _observerContainer.Keys)
            { 
                anObserver.Notify(anObject); 
            }//foreach
        }//NotifyObservers
    }//ObservableImpl
}
