// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.reflection;

@net.sf.jni4net.attributes.ClrType
public class FieldInfo extends system.reflection.MemberInfo {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected FieldInfo(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected FieldInfo() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Type;")
    public native system.Type getFieldType();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)LSystem/Object;")
    public native system.Object GetValue(system.Object obj);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Globalization/CultureInfo;)V")
    public native void SetValue(system.Object obj, system.Object value, system.reflection.BindingFlags invokeAttr, system.Object binder, system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/RuntimeFieldHandle;")
    public native system.ValueType getFieldHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/FieldAttributes;")
    public native system.Enum getAttributes();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;)V")
    public native void SetValue(system.Object obj, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPublic();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPrivate();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamily();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamilyAndAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamilyOrAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isStatic();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isInitOnly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isLiteral();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isNotSerialized();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSpecialName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPinvokeImpl();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/RuntimeFieldHandle;)LSystem/Reflection/FieldInfo;")
    public native static system.reflection.FieldInfo GetFieldFromHandle(system.ValueType handle);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/RuntimeFieldHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/FieldInfo;")
    public native static system.reflection.FieldInfo GetFieldFromHandle(system.ValueType handle, system.ValueType declaringType);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Type;")
    public native system.Type[] GetRequiredCustomModifiers();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Type;")
    public native system.Type[] GetOptionalCustomModifiers();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object GetRawConstantValue();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSecurityCritical();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSecuritySafeCritical();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSecurityTransparent();
    
    public static system.Type typeof() {
        return system.reflection.FieldInfo.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.reflection.FieldInfo.staticType = staticType;
    }
    //</generated-proxy>
}
