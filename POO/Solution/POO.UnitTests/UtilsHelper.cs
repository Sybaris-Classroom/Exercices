using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO.UnitTests
{
    public static class UtilsHelper
    {
        public static bool ClassExists(Assembly assembly, string classname)
        {
            return (from type in assembly.GetTypes()
                    where type.Name == classname
                    select type).Any();
        }

        public static Type GetClassType(Assembly assembly, string classname)
        {
            return (from type in assembly.GetTypes()
                    where type.Name == classname
                    select type).SingleOrDefault();
        }

    }
}
