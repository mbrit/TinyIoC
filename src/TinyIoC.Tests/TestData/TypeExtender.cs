using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if NETFX_CORE
using System.Reflection;
#endif

namespace TinyIoC.Tests
{
    internal static class TypeExtender
    {
#if !NETFX_CORE
        internal static Assembly GetAssembly(this Type type)
        {
            return type.Assembly;
        }
#else
        internal static Assembly GetAssembly(this Type type)
        {
            return type.GetTypeInfo().Assembly;
        }
#endif
    }
}
