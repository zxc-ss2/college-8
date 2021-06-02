﻿using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Controllers
{
    class QuantityController
    {
        readonly DbHelper dbHelper = new DbHelper();

        public List<quantity> GetQuantity(int selectBook)
        {
            return dbHelper.context.quantity.Where(t => t.book_id == selectBook).ToList();
        }

        public bool ChangeQuantityMinus(int selectBook, List<quantity> bookQuantityList)
        {
            var book = dbHelper.context.quantity.Where(t => t.book_id == selectBook).First().library_quantity;

            foreach (var item in bookQuantityList)
            {
                item.library_quantity = book -= 1;
            }

            dbHelper.context.SaveChanges();
            return true;
        }

        public bool ChangeQuantityPlus(int selectBook, List<quantity> bookQuantityList)
        {
            var book = dbHelper.context.quantity.Where(t => t.book_id == selectBook).First().library_quantity;

            foreach (var item in bookQuantityList)
            {
                item.library_quantity = book += 1;
            }

            dbHelper.context.SaveChanges();
            return true;
        }
    }
}
