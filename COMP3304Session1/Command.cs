﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Non-generic Command class, executes an action with no parameters.
    /// </summary>
    public class Command : ICommand
    {
        //Declare an action to be executed by this command, call it _action:
        private Action _action;

        /// <summary>
        /// Constructor of objects of type Command
        /// </summary>
        /// <param name="action">The action to be executed by this command</param>
        public Command(Action action) 
        {
            // Assign action and size:
            _action = action;
        }

        /// <summary>
        /// Executes the Command
        /// </summary>
        public void Execute() 
        {
            _action();
        }
    }

    /// <summary>
    /// Generic command class, which provides for a single parameter of type T for execution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Command<T> : ICommand 
    {
        //Declare an action<T> to be executed by this command, call it _action;
        private Action<T> _action;

        //Declare a variable of type T to represent the required data, call it _data:
        private T _data;

        /// <summary>
        /// Constructor of objects of type Command<typeparamref name="T"/>
        /// </summary>
        /// <param name="action">The action to be executed by this command</param>
        /// <param name="data">The parameter for the action</param>
        public Command(Action<T> action, T data) 
        {
            //Assign action and size:
            _action = action;
            _data = data;
        }

        /// <summary>
        /// Executes the Command
        /// </summary>
        public void Execute()
        {
            _action(_data);
        }
    }
}
