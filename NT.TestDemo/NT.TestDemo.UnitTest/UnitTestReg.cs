using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NT.TestDemo.Core.Lib;

namespace NT.TestDemo.UnitTest
{
    [TestClass]
    public class UnitTestReg
    {
        [TestMethod]
        public void Match_Y8()
        {
            String msg = "【海航】尾号为8021的卡已为苏星（票号【6663000032286】）/马楷然（票号【6663000032285】）/刘晁昊（票号【6663000032284】）/陈东海（票号【6663000032283】）旅客支付单程【舟山-天津】【02月22日16:05】【FU6601】航班，改期费共计384.0。客票退改签须通过订票时预留的联系方式致电【海航95339】办理，请不要轻信其他服务电话。安全投资首选海航聚宝匯（jbwchina.com）400158158。【海航95339】";
            RegexLib lib=new RegexLib();
            Int32 result= lib.Match(msg);
            Assert.IsTrue(result>0);
        }
    }
}
