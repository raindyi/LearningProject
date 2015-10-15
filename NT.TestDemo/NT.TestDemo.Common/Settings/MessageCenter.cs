using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.Common.Settings
{
    public static class MessageCenter
    {
        #region
        /// <summary>
        /// 操作成功
        /// </summary>
        public const String MC_INFO_COM_PROCESSSUCCESSED = "操作成功";
        /// <summary>
        /// 操作失败
        /// </summary>
        public const String MC_ERR_COM_PROCESSUNSUCCESS = "操作失败";
        #endregion

        #region LoginInfo
        /// <summary>
        /// 请输入用户名和密码！
        /// </summary>
        public const String MC_ERR_LOGININFORMISSED = "请输入用户名和密码！";
        /// <summary>
        /// 用户名或密码错误
        /// </summary>
        public const String MC_ERR_LOGININFORLOGINERROR = "用户名或密码错误！";
        /// <summary>
        /// 用户不存在
        /// </summary>
        public const String MC_ERR_LOGININFORUNKNOWNUSER = "用户不存在!";
        /// <summary>
        /// 用户登录成功
        /// </summary>
        public const String MC_INFO_LOGININFORLOGINSUCCESSED = "用户登录成功!";
        #endregion

        #region Employee
        /// <summary>
        /// 旧密码错误
        /// </summary>
        public const String MC_ERR_EMPLOYEE_OLDPWNOTCORRECT = "旧密码错误!";
        /// <summary>
        /// 请输入旧密码、新密码以及确认密码！
        /// </summary>
        public const String MC_ERR_EMPLOYEE_NODIFYPWINFORMISS = "请输入旧密码、新密码以及确认密码！";
        /// <summary>
        /// 新密码不能与旧密码相同！
        /// </summary>
        public const String MC_ERR_EMPLOYEE_OLDPWEQUALSNEWPW = "新密码不能与旧密码相同！";
        /// <summary>
        /// 新密码和确认密码输入不一致,请检查！
        /// </summary>
        public const String MC_ERR_EMPLOYEE_NEWNOTQUUALSCONFIRM = "新密码和确认密码输入不一致,请检查！";

        #endregion

        #region LogMsg

        public const String MC_LOGMSG_LOGINOP = "系统登录操作";

        #endregion
    }
}
