// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.util;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Iterator_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.util.Iterator_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.util.Iterator_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Iterator extends system.Object implements java.util.Iterator {
    
    protected __Iterator(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void remove();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean hasNext();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Object;")
    public native java.lang.Object next();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void forEachRemaining(java.util.function.Consumer arg0);
}
//</generated-proxy>
