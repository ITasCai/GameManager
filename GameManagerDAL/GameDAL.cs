using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagerCommon;
using GameManagerModel;
using System.Data.SqlClient;
using System.Data;


namespace GameManagerDAL
{
    /// <summary>
    /// 游戏点卡管理系统数据访问类
    /// </summary>
    public class GameDAL
    {

        /// <summary>
        /// 游戏类型查询
        /// </summary>
        public  static DataSet GetGameLxDAL() {
            string sql = "SELECT * FROM gamelx";
            DataSet da= SqlHelper.ExecuteDataSet(CommandType.Text, sql,null);
            return da;
        }


        /// <summary>
        /// 显示内容
        /// </summary>
        /// <returns></returns>
        public static DataSet GetShowLxDAL(int num) {
    
            string str ="SELECT pid,pname,gname,pgs,pje FROM dbo.Play, dbo.gamelx WHERE dbo.Play.gid=dbo.gamelx.gid" ;

            if (num!=-1)
            {
                str += string.Format(" and gamelx.gid='{0}'",num);
            }
            DataSet da=SqlHelper.ExecuteDataSet(CommandType.Text,str,null);
            return da;
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataSet BlurryDAL(string name) {
            string str =string.Format("SELECT pid,pname,gname,pgs,pje FROM dbo.Play,dbo.gamelx   WHERE dbo.Play.gid=dbo.gamelx.gid and pname like '%{0}%'",name);

            DataSet ds=SqlHelper.ExecuteDataSet(CommandType.Text, str, null);
            return ds;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="ga"></param>
        /// <returns></returns>
        public static int AddDAL(Gaming ga)
        {
            string str = "INSERT INTO dbo.Play(pname, pgs, pje, gid)VALUES(@pname, @pgs, @pje, @gid)";
            SqlParameter[] pa = new SqlParameter[] {
                 new SqlParameter("@pname",ga.Pname),
                 new SqlParameter("@pgs",ga.Pgs),
                 new SqlParameter("@pje",ga.Pje),
                 new SqlParameter("@gid",ga.Gid),
            };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, str, pa);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static int DeleteDAL(int pid) {
            string str = "DELETE dbo.Play  where pid=@pid";
            SqlParameter pa = new SqlParameter("@pid", pid);
            return SqlHelper.ExecuteNonQuery(CommandType.Text,str,pa);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="ga"></param>
        /// <returns></returns>
        public static int ModificationDAL(Gaming ga) {
            string str = "UPDATE dbo.Play SET  pname=@pname, pgs=@pgs, pje=@pje, gid=@gid where pid=@pid";

            SqlParameter[] pa = new SqlParameter[] {
                 new SqlParameter("@pname",ga.Pname),
                 new SqlParameter("@pgs",ga.Pgs),
                 new SqlParameter("@pje",ga.Pje),
                 new SqlParameter("@gid",ga.Gid),
                 new SqlParameter("@pid",ga.Pid)
            };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, str, pa);
        }


        
    }
}
