using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(Item item)
        {
            return _itemRepository.Add(item);
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
        public bool Delete(int id) {
            return _itemRepository.Delete(id);
        }
        public List<Item> Search(string name)
        {
            return _itemRepository.Search(name);
        }

        public DataTable ItemCombo()
        {
            return _itemRepository.ItemCombo();
        }
    }
}
