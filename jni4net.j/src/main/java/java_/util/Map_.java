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
public final class Map_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.util.Map_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.util.Map_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Map extends system.Object implements java.util.Map {
    
    protected __Map(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int hashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")
    public native java.lang.Object put(java.lang.Object par0, java.lang.Object par1);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void clear();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean equals(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Set;")
    public native java.util.Set entrySet();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/lang/Object;")
    public native java.lang.Object get(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Map;)V")
    public native void putAll(java.util.Map par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int size();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Collection;")
    public native java.util.Collection values();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/lang/Object;")
    public native java.lang.Object remove(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean containsKey(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean containsValue(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isEmpty();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Set;")
    public native java.util.Set keySet();
}
//</generated-proxy>
