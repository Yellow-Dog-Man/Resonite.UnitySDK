using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public struct PlaybackState
{
    public bool Playing;
    public bool Loop;
    public double Position;
    public float Speed;

    public void Play(float speed = 1f)
    {
        Playing = true;
        Speed = speed;
    }

    public void Stop()
    {
        Playing = false;
        Position = 0;
    }

    public ResoniteLink.SyncPlayback ToResoniteLink()
    {
        return new ResoniteLink.SyncPlayback()
        {
            Play = Playing,
            Loop = Loop,
            Position = Position,
            Speed = Speed
        };
    }
}