using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class Parameters
    {
        public static requestParameters convertListToParameters(Object item)
        {
            var parameters = new requestParameters();
            foreach (var directoryinfo in item.GetType().GetProperties())
            {
                if(directoryinfo.GetValue(item) != null)
                {
                    foreach (CustomAttributeData att in directoryinfo.CustomAttributes)
                    {
                        foreach (CustomAttributeTypedArgument arg in att.ConstructorArguments)
                        {
                            parameters.Add(arg.Value.ToString(), directoryinfo.GetValue(item, null));
                        }
                    }
                }
                
            }
            return parameters;
        }
        //public static Dictionary<string, object> ObjectToDictionary(object value)
        //{
        //    Dictionary<string, object> dictionary = new Dictionary<string, object>();
        //    if (value != null)
        //    {
        //        foreach (System.ComponentModel.PropertyDescriptor descriptor in System.ComponentModel.TypeDescriptor.GetProperties(value))
        //        {
        //            if (descriptor != null && descriptor.Name != null)
        //            {
        //                object propValue = descriptor.GetValue(value);
        //                if (propValue != null)
        //                    dictionary.Add(descriptor.Name, String.Format("{0}", propValue));
        //            }
        //        }                
        //    }
        //    return dictionary;
        //}
        public static string convertToNewline(string item)
        {
            return item.Replace(',', '\n');
        }

        public class requestParameters : Dictionary<string, object>
        {

        }
    }
}
