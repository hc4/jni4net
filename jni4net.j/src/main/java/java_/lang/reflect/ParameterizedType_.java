// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.lang.reflect;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ParameterizedType_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.reflect.ParameterizedType_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.reflect.ParameterizedType_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ParameterizedType extends system.Object implements java.lang.reflect.ParameterizedType {
    
    protected __ParameterizedType(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/reflect/Type;")
    public native java.lang.reflect.Type[] getActualTypeArguments();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/reflect/Type;")
    public native java.lang.reflect.Type getOwnerType();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/reflect/Type;")
    public native java.lang.reflect.Type getRawType();
}
//</generated-proxy>
