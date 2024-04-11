﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class ItemsDAO
    {
        DBConnection db = DBConnection.getInstance();
        public List<Items> LoadItemsInfo()
        {
            string sqlStr = "SELECT * from ItemInfo";
            return db.LoadItem(sqlStr, "load");
        }

        public void AddItems(Items A)
        {
            //MemoryStream ms = new MemoryStream();
            //A.ItemImage.Save(ms, A.ItemImage.RawFormat);
            //byte[] bytes = ms.ToArray();
            string sqlStr = string.Format("INSERT INTO ItemInfo(ItemName, ItemQuantity, ItemDiscription, ItemPrice, " +
                "OwnerName, ItemImage, ItemImage1, ItemImage2, ItemYear, ItemQuanlity, ItemOldPrice, ItemRating)" +
                " VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                A.ItemName, A.ItemQuantity, A.ItemDescription, A.ItemPrice, A.UserName, A.ItemImage[0], A.ItemImage[1], 
                A.ItemImage[2], A.ItemYear, A.ItemQuality, A.ItemOldPrice, A.ItemRating);
            db.Execute(sqlStr, "add");
        }

        public void UpdateItem(Items A)
        {
            string sqlStr = string.Format($"UPDATE ItemInfo SET ItemQuantity = '{A.ItemQuantity}', ItemDiscription = '{A.ItemDescription}', ItemPrice = '{A.ItemPrice}'," +
                $" ItemImage1 = '{A.ItemImage[1]}', ItemImage2 = '{A.ItemImage[2]}', ItemImage = '{A.ItemImage[0]}', ItemYear = '{A.ItemYear}', ItemQuanlity = '{A.ItemQuality}'," +
                $" OwnerName = '{A.UserName}', ItemOldPrice= '{A.ItemOldPrice}', ItemRating = '{A.ItemRating}' WHERE ItemName = '{A.ItemName}'");
            db.Execute(sqlStr, "update");
        }

        public void UpdateRating(Items A)
        {
            string sqlStr = string.Format($"EXECUTE UpdateRating @ItemName = '{A.ItemName}', @ItemRating = '{A.ItemRating}';");
            db.Execute(sqlStr, "update");
        }
    }
}
