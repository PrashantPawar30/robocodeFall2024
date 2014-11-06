/**
 * Copyright (c) 2001-2014 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package robocode.control.snapshot;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ITurnSnapshot_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return robocode.control.snapshot.ITurnSnapshot_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        robocode.control.snapshot.ITurnSnapshot_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ITurnSnapshot extends system.Object implements robocode.control.snapshot.ITurnSnapshot {
    
    protected __ITurnSnapshot(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lrobocode/control/snapshot/IRobotSnapshot;")
    public native robocode.control.snapshot.IRobotSnapshot[] getRobots();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lrobocode/control/snapshot/IBulletSnapshot;")
    public native robocode.control.snapshot.IBulletSnapshot[] getBullets();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getTPS();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getRound();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getTurn();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lrobocode/control/snapshot/IScoreSnapshot;")
    public native robocode.control.snapshot.IScoreSnapshot[] getSortedTeamScores();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lrobocode/control/snapshot/IScoreSnapshot;")
    public native robocode.control.snapshot.IScoreSnapshot[] getIndexedTeamScores();
}
//</generated-proxy>
