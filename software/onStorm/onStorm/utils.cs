using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace onStorm
{
    public class utils
    {
        public static class Folder
        {
            public static string AppDataFolder ()
            {
                var userPath = Environment.GetEnvironmentVariable(
                    RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                    "LOCALAPPDATA" : "Home");

                var assy = System.Reflection.Assembly.GetEntryAssembly();
                var companyName = assy.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault();
                var path = System.IO.Path.Combine(userPath, companyName.Company);

                return path;
            }
        }

        public static class Obj
        {
            private static string universalDateFormat = "ddMMyyyyHHmmss";
            public static string Nome<T> (Expression<Func<T>> memberExpression)
            {
                MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
                return expressionBody.Member.Name;
            }

            public static string Tipo<T> (T parametros)
            {
                return typeof(T).Name;
            }

            public static string ToStr<T> (T parametro)
            {
                if( typeof(T) == typeof(string) )
                {
                    return parametro.ToString();
                }
                else if( typeof(T) == typeof(int) )
                {
                    return parametro.ToString();
                }
                else if( typeof(T) == typeof(DateTime) )
                {
                    var data = Convert.ToDateTime(parametro);
                    return data.ToString(universalDateFormat);
                }
                else if( typeof(T) == typeof(string) )
                {
                    return parametro.ToString();
                }
                else
                {
                    return parametro.ToString();
                }
            }

            //public static T ToObj<T>(T parametro, string nome, string data)
            //{
            //    //if( typeof(T) == typeof(string) )
            //    //{
            //    //    return parametro = data;
            //    //}
            //    //else if( typeof(T) == typeof(int) )
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //    //else if( typeof(T) == typeof(DateTime) )
            //    //{
            //    //    var data = Convert.ToDateTime(parametro);
            //    //    return data.ToString(universalDateFormat);
            //    //}
            //    //else if( typeof(T) == typeof(string) )
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //    //else
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //}
        }
    }
}
