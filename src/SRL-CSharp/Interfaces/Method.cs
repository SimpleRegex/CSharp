﻿using SRL_CSharp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL_CSharp.Interfaces
{
    /// <summary>
    /// Abstract Method class. Method strings recognized by the Matcher will result in an object of type Method.
    /// </summary>
    public abstract class Method
    {
        /** @var string Contains the original method name (case-sensitive). */
        protected string Original { get; set; }

        /** @var string Contains the method name to execute. */
        protected string MethodName { get; set; }

        /** @var array Contains the parsed parameters to pass on execution. */
        protected List<string> Parameters { get; set; }

        /** @var int[] Contains all executed callbacks for that method. Helps finding "lost" groups. */
        private List<int> executedCallbacks = new List<int>();

        public Method(string original, string methodName)
        {
            this.Original = original;
            this.MethodName = methodName;
            this.Parameters = new List<string>();
        }

        public void callMethodOn(Builder builder)
        {
            try
            {

            } 
            catch (Exception ex)
            {
                //Fix Exception handling
                throw new SyntaxException();
            }
        }
    }
}