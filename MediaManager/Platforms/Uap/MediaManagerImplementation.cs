﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MediaManager.Audio;
using MediaManager.Media;
using MediaManager.Platforms.Uap.Media;
using MediaManager.Playback;
using MediaManager.Video;
using MediaManager.Volume;
using Windows.Media.Playback;

namespace MediaManager
{
    public class MediaManagerImplementation : MediaManagerBase<WindowsMediaPlayer, MediaPlayer>
    {
        public override IMediaPlayer MediaPlayer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IMediaExtractor MediaExtractor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IVolumeManager VolumeManager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override Playback.MediaPlayerState State => throw new NotImplementedException();

        public override TimeSpan Position => throw new NotImplementedException();

        public override TimeSpan Duration => throw new NotImplementedException();

        public override TimeSpan Buffered => throw new NotImplementedException();

        public override float Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Init()
        {
            throw new NotImplementedException();
        }

        public override Task Pause()
        {
            throw new NotImplementedException();
        }

        public override Task Play(IMediaItem mediaItem)
        {
            throw new NotImplementedException();
        }

        public override Task<IMediaItem> Play(string uri)
        {
            throw new NotImplementedException();
        }

        public override Task Play(IEnumerable<IMediaItem> items)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<IMediaItem>> Play(IEnumerable<string> items)
        {
            throw new NotImplementedException();
        }

        public override Task<IMediaItem> Play(FileInfo file)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<IMediaItem>> Play(DirectoryInfo directoryInfo)
        {
            throw new NotImplementedException();
        }

        public override Task Play()
        {
            throw new NotImplementedException();
        }

        public override Task PlayNext()
        {
            throw new NotImplementedException();
        }

        public override Task PlayPrevious()
        {
            throw new NotImplementedException();
        }

        public override Task SeekTo(TimeSpan position)
        {
            throw new NotImplementedException();
        }

        public override Task StepBackward()
        {
            throw new NotImplementedException();
        }

        public override Task StepForward()
        {
            throw new NotImplementedException();
        }

        public override Task Stop()
        {
            throw new NotImplementedException();
        }

        public override void ToggleRepeat()
        {
            throw new NotImplementedException();
        }

        public override void ToggleShuffle()
        {
            throw new NotImplementedException();
        }
    }
}
