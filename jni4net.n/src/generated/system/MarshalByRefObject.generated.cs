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
    public partial class MarshalByRefObject_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__MarshalByRefObject.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.MarshalByRefObject))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.MarshalByRefObject))]
    internal sealed partial class @__MarshalByRefObject : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MarshalByRefObject(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__MarshalByRefObject.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__MarshalByRefObject);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetLifetimeService", "GetLifetimeService0", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "InitializeLifetimeService", "InitializeLifetimeService1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateObjRef", "CreateObjRef2", "(Lsystem/Type;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::System.IntPtr GetLifetimeService0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.MarshalByRefObject @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.MarshalByRefObject>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.GetLifetimeService());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr InitializeLifetimeService1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.MarshalByRefObject @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.MarshalByRefObject>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.InitializeLifetimeService());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr CreateObjRef2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr requestedType) {
            // (Lsystem/Type;)Lsystem/Object;
            // (LSystem/Type;)LSystem/Runtime/Remoting/ObjRef;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.MarshalByRefObject @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.MarshalByRefObject>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Runtime.Remoting.ObjRef>(@__env, @__real.CreateObjRef(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, requestedType)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__MarshalByRefObject(@__env);
            }
        }
    }
    #endregion
}
