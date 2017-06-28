using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagerDAL;
using System.Data;
using GameManagerModel;

namespace GameManagerBLL
{
    /// <summary>
    /// 业务逻辑类
    /// </summary>
   public class GameBLL
    {

        /// <summary>
        /// 游戏类型查询
        /// </summary>
        public static DataSet GetGameLxBLL()
        {
            return GameDAL.GetGameLxDAL();
        }


        /// <summary>
        /// 显示内容
        /// </summary>
        /// <returns></returns>
        public static DataSet GetShowLxDAL(int num)
        {
            return GameDAL.GetShowLxDAL(num);
        }


        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataSet BlurryBLL(string name)
        {
            return GameDAL.BlurryDAL(name);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="ga"></param>
        /// <returns></returns>
        public static int AddBLL(Gaming ga)
        {
            return GameDAL.AddDAL(ga);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static int DeleteBLL(int pid)
        {
            return GameDAL.DeleteDAL(pid);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="ga"></param>
        /// <returns></returns>
        public static int ModificationBLL(Gaming ga)
        {
            return GameDAL.ModificationDAL(ga);
        }


        }
}
