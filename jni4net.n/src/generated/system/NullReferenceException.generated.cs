//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class NullReferenceException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__NullReferenceException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.NullReferenceException))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.NullReferenceException))]
    internal sealed partial class @__NullReferenceException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__NullReferenceException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__NullReferenceException.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__NullReferenceException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNullReferenceException0", "__ctorNullReferenceException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNullReferenceException1", "__ctorNullReferenceException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNullReferenceException2", "__ctorNullReferenceException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorNullReferenceException0(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NullReferenceException @__real = new global::System.NullReferenceException();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNullReferenceException1(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NullReferenceException @__real = new global::System.NullReferenceException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNullReferenceException2(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message, global::System.IntPtr innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NullReferenceException @__real = new global::System.NullReferenceException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, innerException));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__NullReferenceException(@__env);
            }
        }
    }
    #endregion
}
