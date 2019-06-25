using System;

namespace SingletonApp
{
    public sealed class Singleton
    {
        private static int counter = 0;

        #region not therad safe

        //private static Singleton instance = null;

        //public static Singleton GetInstance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Singleton();
        //        return instance;
        //    }
        //}
        #endregion


        #region fully lazy instantiation

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance { get { return lazy.Value; } }
        #endregion




        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
