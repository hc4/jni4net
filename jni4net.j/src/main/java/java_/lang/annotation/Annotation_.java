// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.lang.annotation;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Annotation_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.annotation.Annotation_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.annotation.Annotation_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Annotation extends system.Object implements java.lang.annotation.Annotation {
    
    protected __Annotation(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int hashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean equals(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String toString();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Class;")
    public native java.lang.Class annotationType();
}
//</generated-proxy>
