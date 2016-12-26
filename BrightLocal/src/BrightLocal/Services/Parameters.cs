using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BrightLocal.Services
{
    public class Parameters
    {
        public static requestParameters convertListToParameters(Object item)
        {
            var parameters = new requestParameters();
            foreach (var directoryinfo in item.GetType().GetProperties())
            {
                foreach (CustomAttributeData att in directoryinfo.CustomAttributes)
                {
                    foreach (CustomAttributeTypedArgument arg in att.ConstructorArguments)
                    {
                        parameters.Add(arg.Value.ToString(), directoryinfo.GetValue(item, null));

                    }
                }
            }
            return parameters;
        }

        public class requestParameters : Dictionary<string, object>
        {

        }
    }
}
