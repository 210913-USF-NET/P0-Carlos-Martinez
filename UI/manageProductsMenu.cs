using BL;
using System;

namespace UI
{
    public class manageProductsMenu : IMenu
    {
        private IBL _bl;

        public manageProductsMenu(IBL bl)
        {
            _bl = bl;
        }

        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Entered Store. Press anything to leave.");
                Console.ReadLine();
                exit = true;
            } while(!exit);
        }
    }
}