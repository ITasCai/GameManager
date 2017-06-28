using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerModel
{
    /// <summary>
    /// 游戏表
    /// </summary>
  public  class Gaming
    {
        /// <summary>
        /// 游戏卡号
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 游戏名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// 游戏公司
        /// </summary>
        public string Pgs { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public double Pje { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        public int Gid { get; set; }
    }
}
