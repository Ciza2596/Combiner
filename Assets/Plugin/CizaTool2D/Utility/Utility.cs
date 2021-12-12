using System;

namespace CizaTool2D.Utility
{
    public class Utility 
    {
        public static bool GetIsObjectNull(object obj, Action log) {
            if(obj == null){
                log();
                return true;
            }
            return false;
        }
    }
}
