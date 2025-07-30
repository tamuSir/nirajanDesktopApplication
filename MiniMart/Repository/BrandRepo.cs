using Dapper;
using MiniMart.App_Code;
using MiniMart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Repository
{
    public class BrandRepo
    {
		GlobalConnection g = new GlobalConnection();
        public List<BrandModel> GetALLBrandList() 
        {
			try
			{
				g.cn.Open();
				DynamicParameters param= new DynamicParameters();
				param.Add("@flag", "BrandList");

				var data = SqlMapper.Query<BrandModel>(g.cn, "procBrand",param,commandType: System.Data.CommandType.StoredProcedure).ToList();
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
		public int AddBrand(BrandModel bm)
		{
			try
			{
				g.cn.Open();
				DynamicParameters param = new DynamicParameters();
				param.Add("@brandName",bm.brandName);
				param.Add("@status",bm.status);
				param.Add("@flag","InsertBrand");

				var data = SqlMapper.Query<int>(g.cn, "procBrand",param,commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
		public int UpdateBrand(BrandModel bm)
		{
			try
			{
				g.cn.Open();
				DynamicParameters param=new DynamicParameters();
				param.Add("@brandId",bm.brandId);
				param.Add("brandName",bm.brandName);
				param.Add("@status",bm.status);
				param.Add("@flag","updateBrand");

				var data = SqlMapper.Query<int>(g.cn, "procBrand",param,commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
		public BrandModel getBrandById(int brandId)
		{
			try
			{
				g.cn.Open();
				DynamicParameters param=new DynamicParameters();
				param.Add("@brandId",brandId);
				param.Add("@flag", "getBrandById");

				var data = SqlMapper.Query<BrandModel>(g.cn,"procBrand",param,commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
		public int deleteBrand(int id)
		{
			try
			{
				g.cn.Open();
				DynamicParameters param = new DynamicParameters();
				param.Add("@brandId", id);
				param.Add("@flag", "deleteBrand");

				var data = SqlMapper.Query<int>(g.cn, "procBrand", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
