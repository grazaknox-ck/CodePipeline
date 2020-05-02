using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;


namespace TestPipeline
{
 
    public class NewFunc
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string NewFunctionHandler(FunctionInput fn, ILambdaContext context)
        {
            return "This is diffrent project that needs to be deployed";
        }
    }
}
