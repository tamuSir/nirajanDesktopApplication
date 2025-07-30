using Dapper;
using MiniMart.App_Code;
using MiniMart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Repository
{
    public class ProductRepo
    {
        GlobalConnection g=new GlobalConnection();
        public int addProduct(ProductModel pm)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@productName", pm.productName);
                param.Add("@price", pm.price);
                param.Add("@quantity", pm.quantity);
                param.Add("@production_date", pm.production_date);
                param.Add("@expiry_date", pm.expiry_date);
                param.Add("@intRoleId", pm.intRoleId);
                param.Add("@categoryId", pm.categoryId);
                param.Add("@brandId", pm.brandId);
                param.Add("@status", pm.status);
                param.Add("@flag", "insertProduct");

                var data = SqlMapper.Query<int>(g.cn, "procProduct", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                g.cn.Close();
            }
        }
        public int productUpdate(ProductModel pm)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@@productId", pm.productId);
                param.Add("@productName", pm.productName);
                param.Add("@price", pm.price);
                param.Add("@quantity", pm.quantity);
                param.Add("@production_date", pm.production_date);
                param.Add("@expiry_date", pm.expiry_date);
                param.Add("@intRoleId", pm.intRoleId);
                param.Add("@categoryId", pm.categoryId);
                param.Add("@brandId", pm.brandId);
                param.Add("@status", pm.status);
                param.Add("@flag", "updateProduct");

                var data = SqlMapper.Query<int>(g.cn, "procProduct", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
        public ProductModel productGetById(int id)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@productId", id);
                param.Add("@flag", "getProductById");

                var data = SqlMapper.Query<ProductModel>(g.cn, "procProduct", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                g.cn.Close();
            }
        }
        public List<ProductModel> productAllList()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@flag", "productList");

                var data = SqlMapper.Query<ProductModel>(g.cn, "procProduct", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
        public int productDelete(int productId)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@productId", productId);
                param.Add("@flag", "deleteProduct");

                var data = SqlMapper.Query<int>(g.cn, "procProduct", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
        public List<CategoryModel> categoryDropDown()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@flag", "dropDownCategory");

                var data = SqlMapper.Query<CategoryModel>(g.cn, "procCategory", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
        public List<BrandModel> brandDropDown()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@flag", "dropdownBrand");

                var data = SqlMapper.Query<BrandModel>(g.cn, "procBrand", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
    }
}
