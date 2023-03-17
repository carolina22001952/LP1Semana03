using System;


namespace PlayerPerks
{
    [Flags]
    public enum Perks
    {
        WaterBreathing = 1 << 1,
        Stealth = 1 << 2,
        AutoHeal = 1 << 4,
        DoubleJump = 1 << 8    
    }
}