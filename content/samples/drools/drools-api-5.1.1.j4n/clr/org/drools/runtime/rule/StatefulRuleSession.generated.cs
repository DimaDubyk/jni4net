//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface StatefulRuleSession {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        int fireAllRules(int par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/AgendaFilter;)I")]
        int fireAllRules(global::org.drools.runtime.rule.AgendaFilter par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int fireAllRules();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/AgendaFilter;)V")]
        void fireUntilHalt(global::org.drools.runtime.rule.AgendaFilter par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void fireUntilHalt();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class StatefulRuleSession_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.rule.StatefulRuleSession), typeof(global::org.drools.runtime.rule.StatefulRuleSession_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.rule.StatefulRuleSession), typeof(global::org.drools.runtime.rule.StatefulRuleSession_))]
    internal sealed partial class @__StatefulRuleSession : global::java.lang.Object, global::org.drools.runtime.rule.StatefulRuleSession {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _fireAllRules0;
        
        internal static global::net.sf.jni4net.jni.MethodId _fireAllRules1;
        
        internal static global::net.sf.jni4net.jni.MethodId _fireAllRules2;
        
        internal static global::net.sf.jni4net.jni.MethodId _fireUntilHalt3;
        
        internal static global::net.sf.jni4net.jni.MethodId _fireUntilHalt4;
        
        private @__StatefulRuleSession(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass = @__class;
            global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules0 = @__env.GetMethodID(global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass, "fireAllRules", "(I)I");
            global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules1 = @__env.GetMethodID(global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass, "fireAllRules", "(Lorg/drools/runtime/rule/AgendaFilter;)I");
            global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules2 = @__env.GetMethodID(global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass, "fireAllRules", "()I");
            global::org.drools.runtime.rule.@__StatefulRuleSession._fireUntilHalt3 = @__env.GetMethodID(global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass, "fireUntilHalt", "(Lorg/drools/runtime/rule/AgendaFilter;)V");
            global::org.drools.runtime.rule.@__StatefulRuleSession._fireUntilHalt4 = @__env.GetMethodID(global::org.drools.runtime.rule.@__StatefulRuleSession.staticClass, "fireUntilHalt", "()V");
        }
        
        public int fireAllRules(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        public int fireAllRules(global::org.drools.runtime.rule.AgendaFilter par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.AgendaFilter>(@__env, par0))));
            }
        }
        
        public int fireAllRules() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.runtime.rule.@__StatefulRuleSession._fireAllRules2)));
            }
        }
        
        public void fireUntilHalt(global::org.drools.runtime.rule.AgendaFilter par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.rule.@__StatefulRuleSession._fireUntilHalt3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.AgendaFilter>(@__env, par0));
            }
        }
        
        public void fireUntilHalt() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.rule.@__StatefulRuleSession._fireUntilHalt4);
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__StatefulRuleSession);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "fireAllRules", "fireAllRules0", "(I)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "fireAllRules", "fireAllRules1", "(Lorg/drools/runtime/rule/AgendaFilter;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "fireAllRules", "fireAllRules2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "fireUntilHalt", "fireUntilHalt3", "(Lorg/drools/runtime/rule/AgendaFilter;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "fireUntilHalt", "fireUntilHalt4", "()V"));
            return methods;
        }
        
        private static int fireAllRules0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0) {
            // (I)I
            // (I)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.runtime.rule.StatefulRuleSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.StatefulRuleSession>(@__env, @__obj);
            @__return = ((int)(@__real.fireAllRules(par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int fireAllRules1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/rule/AgendaFilter;)I
            // (Lorg/drools/runtime/rule/AgendaFilter;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.runtime.rule.StatefulRuleSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.StatefulRuleSession>(@__env, @__obj);
            @__return = ((int)(@__real.fireAllRules(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.AgendaFilter>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int fireAllRules2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.runtime.rule.StatefulRuleSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.StatefulRuleSession>(@__env, @__obj);
            @__return = ((int)(@__real.fireAllRules()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void fireUntilHalt3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/rule/AgendaFilter;)V
            // (Lorg/drools/runtime/rule/AgendaFilter;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.rule.StatefulRuleSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.StatefulRuleSession>(@__env, @__obj);
            @__real.fireUntilHalt(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.AgendaFilter>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void fireUntilHalt4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.rule.StatefulRuleSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.StatefulRuleSession>(@__env, @__obj);
            @__real.fireUntilHalt();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.rule.@__StatefulRuleSession(@__env);
            }
        }
    }
    #endregion
}
