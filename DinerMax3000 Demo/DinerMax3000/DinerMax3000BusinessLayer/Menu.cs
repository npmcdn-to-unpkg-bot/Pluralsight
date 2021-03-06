﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinerMax3000TableAdapters;
namespace DinerMax3000.Business
{
    public class Menu
    {
        public Menu() {
            Items = new List<MenuItem>();

        }

        private int _databaseId;
        public int DatabaseId
        {
            get { return _databaseId; }
            set { _databaseId = value; }
        }
        public void SaveNewMenuItem(string Name, string Description, double Price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.AddMenuItem(Name, Description, Price, DatabaseId);
        }
        
        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach(dsDinerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu.DatabaseId = menuRow.ID;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuItem(menuRow.ID);
                foreach(dsDinerMax3000.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);

                }

                
            }

            return allMenus;
        }
       

        public void AddMenuItem(string Title, string Description, double Price) 
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
        }

        public string Name
        {
            get; set;
        }
        public List<MenuItem> Items { get; set; }
    }
}
