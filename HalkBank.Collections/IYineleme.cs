//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HalkBank.Collections
//{
//    public class IYineleme<T>
//    {

//        public static String Join(this IYineleme<String> values, String separator)
//        => string.Join(separator, values);

        
//        //public static IYineleme<T> yineleme<T>(this IYineleme<T> values, int splitCount)
//        //{
//        //    var count = values.Count() / splitCount;
//        //    var remainingCount = values.Count() % splitCount;

//        //    for (int i = 0; i < count; i++)
//        //        yield return values.Skip(i * splitCount).Take(splitCount);

//        //    yield return values.Skip(count * splitCount).Take(remainingCount);
//        //}

//        public override bool Equals(object obj)
//        {
//            return base.Equals(obj);
//        }

//        public override int GetHashCode()
//        {
//            return base.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return base.ToString();
//        }
//    }
//}
