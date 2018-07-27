using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public class Singleton<T> where T : new()
    {
        public static T Instance
        {
            get => SingletonCreator.instance;
        }

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }
}
