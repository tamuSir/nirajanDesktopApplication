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
    public class CategoryRepo
    {
        public static readonly GlobalConnection g = new GlobalConnection();
        public List<CategoryModel> GetCategoryList()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("flag", "categoryList");

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
        public int addCategory(CategoryModel cm)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@categoryName", cm.categoryName);
                param.Add("@status", cm.status);
                param.Add("@flag", "insertCategory");

                var data = SqlMapper.Query<int>(g.cn, "procCategory", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public int updateCategory(CategoryModel cm)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@catId", cm.catId);
                param.Add("@categoryName", cm.categoryName);
                param.Add("@status", cm.status);
                
                param.Add("@flag", "updateCategory");

                var data = SqlMapper.Query<int>(g.cn, "procCategory", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public CategoryModel categoryGetById(int catId)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@catId", catId);
                param.Add("flag", "getCategoryById");

                var data = SqlMapper.Query<CategoryModel>(g.cn, "procCategory", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public int deleteCategory(int id)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@catId",id);
                param.Add("flag", "deleteCategory");

                var data = SqlMapper.Query<int>(g.cn, "procCategory", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
