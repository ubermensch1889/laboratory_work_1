using System;
using _Source.Core;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceVisual : MonoBehaviour, IObserver<int>
    {
        private GameResource _gameResource;
        
        

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(int value)
        {
            throw new NotImplementedException();
        }
    }
}