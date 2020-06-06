using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Goods
    {
        DAL_Goods dalGoods = new DAL_Goods();

        public List<Good> GetAllGoods()
        {
            return dalGoods.GetAllGoods();
        }

        public void AddGoods(Good newGoods)
        {
            dalGoods.AddGoods(newGoods);
        }

        public Good GetGoodsById(int id)
        {
            return dalGoods.GetGoodsById(id);
        }

        public void UpdateGoods(Good info)
        {
            dalGoods.UpdateGoods(info);
        }

        public void DeleteGoods(Good info)
        {
            dalGoods.DeleteGoods(info);
        }

        public void UpdateSaleGoods(Good info)
        {
            dalGoods.UpdateSaleGoods(info);
        }

        public void DeleteSaleGoods(Good info)
        {
            dalGoods.DeleteSaleGoods(info);
        }

        public List<Good> GetGoodsByImportDate(DateTime importDate, DateTime nowDate)
        {
            List<Good> goods = GetAllGoods();

            for(int i = 0; i < goods.Count; i++)
            {
                if(!(goods[i].Import_Date >= importDate && goods[i].Import_Date <= nowDate))
                {
                    goods.RemoveAt(i);
                    i--;
                }
            }

            return goods;

        }

        public Good GetGoodsByGoodsCode(string goodsCode)
        {
            Good selectedGoods = new Good();
            List<Good> goods = GetAllGoods();
            for (int i = 0; i < goods.Count; i++)
            {
                if (dalGoods.GetAllGoods()[i].GoodsCode == goodsCode)
                {
                    selectedGoods = goods[i];
                    break;
                }
            }

            return selectedGoods;
        }

        public List<Good> GetGoodsByFilter(int filteredColor, int filteredBrand, double filteredMinimumPrice, double filteredMaximumPrice, int filteredType, int filteredSize)
        {
            List<Good> filteredGoods = dalGoods.GetAllGoods();

            for (int i = 0; i < filteredGoods.Count; i++)
            {
                if ((filteredGoods[i].ID_Color == filteredColor || filteredColor == 0) && (filteredGoods[i].ID_Brand == filteredBrand || filteredBrand == 0) &&
                    (filteredGoods[i].Price >= filteredMinimumPrice && filteredGoods[i].Price <= filteredMaximumPrice || (filteredMinimumPrice == 0 && filteredMaximumPrice == 0)) &&
                    (filteredGoods[i].ID_Type == filteredType || filteredType == 0) && (filteredGoods[i].ID_Size == filteredSize || filteredSize == 0))
                {
                    continue;
                }
                else
                {
                    filteredGoods.RemoveAt(i);
                    i--;
                }
            }


            return filteredGoods;
        }

        public bool IsGoodsCodeValid(string goodsCode)
        {
            List<Good> goods = dalGoods.GetAllGoods();

            for(int i = 0; i < goods.Count; i++)
            {
                if(goods[i].GoodsCode == goodsCode)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
