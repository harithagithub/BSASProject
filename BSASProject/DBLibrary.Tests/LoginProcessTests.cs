using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using Xunit;

namespace DBLibrary.Tests
{
     public class LoginProcessTests
    {
        [Theory]
        [InlineData("j","c",true)]
        [InlineData("jjj","ccc", true)]
        [InlineData("","",false)]
        [InlineData("1","password",false)]
        [InlineData("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq", "password", false)]
        [InlineData("1", "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq", false)]
        [InlineData("-user", "password", true)]
        public void ValidateUserInput_StringsShouldVerify(string un, string pwd, bool exp)
        {
            //Arrange

            LoginProcess Lp = new LoginProcess();

            //bool expected = true;

            //Act
            bool actual = Lp.ValidateUserInput(un,pwd);

            //Access

            Assert.Equal(exp, actual);
        }
    }
}
