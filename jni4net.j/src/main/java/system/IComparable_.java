// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class IComparable_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.IComparable_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.IComparable_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IComparable extends system.Object implements system.IComparable {
    
    protected __IComparable(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int CompareTo(system.Object obj);
}
//</generated-proxy>
