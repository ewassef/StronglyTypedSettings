

using System;
using System.Linq;
using System.Reflection;

//-----------------------------------------------------------
// Do not modified this file. This content is auto generated.
// Modify the T4 template instead.
//-----------------------------------------------------------
namespace StronglyTypedSettings
{
    public sealed class Configs
    {
        private static Func<string, string> _lookupFunc;
        private static Action<string, string> _writebackAction;
        public static Func<string, string> Lookup
        {
            set { _lookupFunc = value; }
        }

        public static Action<string, string> WriteBack
        {
            set { _writebackAction = value; }
        }
        public GlobalContext Global = new GlobalContext();
        public class GlobalContext
        {
            /// <summary>
            /// Defines whether to save or not
            /// </summary>
            public string ShouldSave
            {
                get
                {
                    if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                    return _lookupFunc("Global.ShouldSave");
                }
                set
                {
                    _writebackAction("Global.ShouldSave", value.ToString());
                }
            }
            public LoginContext Login = new LoginContext();
            public class LoginContext
            {
                /// <summary>
                /// Defines the global username for determining how to get in
                /// </summary>
                public string Username
                {
                    get
                    {
                        if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                        return _lookupFunc("Global.Login.Username");
                    }
                    set
                    {
                        _writebackAction("Global.Login.Username", value.ToString());
                    }
                }
                /// <summary>
                /// Defines the global password for determining how to get in
                /// </summary>
                public string Password
                {
                    get
                    {
                        if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                        return _lookupFunc("Global.Login.Password");
                    }
                    set
                    {
                        _writebackAction("Global.Login.Password", value.ToString());
                    }
                }
                /// <summary>
                /// Defines the global Domain for determining how to get in
                /// </summary>
                public string Domain
                {
                    get
                    {
                        if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                        return _lookupFunc("Global.Login.Domain");
                    }
                    set
                    {
                        _writebackAction("Global.Login.Domain", value.ToString());
                    }
                }
                /// <summary>
                /// Defines the global number of allowed retries
                /// </summary>
                public Int32 Retries
                {
                    get
                    {
                        if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                        return Int32.Parse(_lookupFunc("Global.Login.Retries"));
                    }
                    set
                    {
                        _writebackAction("Global.Login.Retries", value.ToString());
                    }
                }
                /// <summary>
                /// Defines the global username for determining how to get in
                /// </summary>
                public string FallBack
                {
                    get
                    {
                        if (_lookupFunc == null) throw new InvalidOperationException("You must set the lookup func before using this class");
                        return _lookupFunc("Global.Login.FallBack");
                    }
                    set
                    {
                        _writebackAction("Global.Login.FallBack", value.ToString());
                    }
                }
            }
        }
    }
}
