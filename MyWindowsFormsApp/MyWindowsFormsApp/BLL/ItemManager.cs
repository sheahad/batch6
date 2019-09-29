using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(string name, double price)
        {
            return _itemRepository.Add(name, price);
        }
        public bool IsNameExists(string name)
        {
            return _itemRepository.IsNameExists(name);
        }
        public bool Update(string name, double price, int id)
        {
            return _itemRepository.Update(name, price, id);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
    }
}
