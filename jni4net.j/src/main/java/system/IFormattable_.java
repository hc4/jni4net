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
public final class IFormattable_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.IFormattable_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.IFormattable_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IFormattable extends system.Object implements system.IFormattable {
    
    protected __IFormattable(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider formatProvider);
}
//</generated-proxy>
