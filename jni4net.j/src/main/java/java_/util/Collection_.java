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
public final class Collection_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.util.Collection_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.util.Collection_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Collection extends system.Object implements java.util.Collection {
    
    protected __Collection(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Iterator;")
    public native java.util.Iterator iterator();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int hashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean add(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void clear();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean equals(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean contains(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean addAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int size();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/Object;")
    public native java.lang.Object[] toArray();
    
    @net.sf.jni4net.attributes.ClrMethod("([Ljava/lang/Object;)[Ljava/lang/Object;")
    public native java.lang.Object[] toArray(java.lang.Object[] par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean remove(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isEmpty();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean containsAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean removeAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean retainAll(java.util.Collection par0);
}
//</generated-proxy>
