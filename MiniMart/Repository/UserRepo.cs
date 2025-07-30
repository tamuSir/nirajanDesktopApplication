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
    public class UserRepo
    {
        public static readonly GlobalConnection g = new GlobalConnection();
        public List<UserModel> GetUserList()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("flag", "userList");

                var data = SqlMapper.Query<UserModel>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
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
        public int addUser(UserModel um) 
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@username",um.userName);
                param.Add("@firstName",um.firstName);
                param.Add("@lastName",um.lastName);
                param.Add("@email",um.email);
                param.Add("@address",um.address);
                param.Add("@phone",um.phone);
                param.Add("@roleId",um.roleId);
                param.Add("@hasPassword",um.hasPassword);
                param.Add("@dtFromDate",um.dtFromDate);
                param.Add("@dtToDate",um.dtToDate);
                param.Add("@designation",um.designation);
                param.Add("@status",um.status);
                param.Add("@flag", "insertUser");

                var data = SqlMapper.Query<int>(g.cn, "userLogin",param,commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public int updateUser(UserModel um)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@userId", um.userId);
                param.Add("@firstName", um.firstName);
                param.Add("@lastName", um.lastName);
                param.Add("@email", um.email);
                param.Add("@address", um.address);
                param.Add("@phone", um.phone);
                param.Add("@roleId", um.roleId);
                param.Add("@hasPassword", um.hasPassword);
                param.Add("@dtFromDate", um.dtFromDate);
                param.Add("@dtToDate", um.dtToDate);
                param.Add("@designation", um.designation);
                param.Add("@status", um.status);
                param.Add("@flag", "updateUser");

                var data = SqlMapper.Query<int>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public UserModel UserGetById(int userId)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@userId", userId);
                param.Add("flag", "getUserById");

                var data = SqlMapper.Query<UserModel>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        public int deleteUser(int id)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@userId", id);
                param.Add("flag", "deleteUser");

                var data = SqlMapper.Query<int>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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

        //role list for drop down
        public List<UserModel> GetRolelist()
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("flag", "roleList");

                var data = SqlMapper.Query<UserModel>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
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

        //for validation username
        public UserModel usernameValidation(string userNamee)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@userName", userNamee);
                param.Add("flag", "checkUsername");

                var data = SqlMapper.Query<UserModel>(g.cn, "userLogin", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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

        //for login 
        public UserModel Login(string userName,string password)
        {
            try
            {
                g.cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@userName",userName);
                param.Add("@hasPassword",password);
                param.Add("@flag", "getUserLogin");
                var data = SqlMapper.Query<UserModel>(g.cn,"userLogin",param,commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
