﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgManagement
{
    class MyException : ApplicationException
    {
        private string error;
        private Exception innerException;
        //无参数构造函数
        public MyException() { }

        public MyException(string msg) : base(msg)
        {
            this.error = msg; 
        }
        //带有一个字符串参数和一个内部异常信息参数的构造函数
        public MyException(string msg, Exception innerException) : base(msg)
        {
            this.innerException= innerException;
            this.error= msg;
        }
        public string GetError()
        {
           return error; 
        }
    }
}
