/**
 * Copyright (c) 2001-2014 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RobotSpecification : global::java.lang.Object, global::java.io.Serializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getName0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getClassName1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getJarFile2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getVersion3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getNameAndVersion4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getDescription5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobocodeVersion6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getWebpage7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getAuthorName8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTeamId9;
        
        protected RobotSpecification(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.RobotSpecification.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.RobotSpecification.staticClass = @__class;
            global::robocode.control.RobotSpecification.j4n_getName0 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getName", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getClassName1 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getClassName", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getJarFile2 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getJarFile", "()Ljava/io/File;");
            global::robocode.control.RobotSpecification.j4n_getVersion3 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getVersion", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getNameAndVersion4 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getNameAndVersion", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getDescription5 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getDescription", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getRobocodeVersion6 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getRobocodeVersion", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getWebpage7 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getWebpage", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getAuthorName8 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getAuthorName", "()Ljava/lang/String;");
            global::robocode.control.RobotSpecification.j4n_getTeamId9 = @__env.GetMethodID(global::robocode.control.RobotSpecification.staticClass, "getTeamId", "()Ljava/lang/String;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getName0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getClassName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getClassName1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getJarFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getJarFile2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getVersion() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getVersion3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getNameAndVersion() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getNameAndVersion4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getDescription() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getDescription5));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getRobocodeVersion() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getRobocodeVersion6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getWebpage() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getWebpage7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getAuthorName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getAuthorName8));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getTeamId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotSpecification.j4n_getTeamId9));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.RobotSpecification(@__env);
            }
        }
    }
    #endregion
}
