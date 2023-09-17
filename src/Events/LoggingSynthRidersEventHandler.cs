﻿using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthRidersWebsockets.Events
{
    // Just logs when we get messages. Useful for testing.
    public class LoggingSynthRidersEventHandler : ISynthRidersEventHandler
    {
        private readonly MelonLogger.Instance logger;

        public LoggingSynthRidersEventHandler(MelonLogger.Instance logger)
        {
            this.logger = logger;
        }

        public void OnSongStart(EventDataSongStart data) { logger.Msg("OnSongStart"); }
        public void OnSongEnd(EventDataSongEnd data) { logger.Msg("OnSongEnd"); }
        public void OnPlayTime(EventDataPlayTime data) { logger.Msg("OnPlayTime"); }
        public void OnNoteHit(EventDataNoteHit data) { logger.Msg("OnNoteHit"); }
        public void OnNoteMiss(EventDataNoteMiss data) { logger.Msg("OnNoteMiss"); }
        public void OnSceneChange(EventDataSceneChange data) { logger.Msg("OnSceneChange"); }
        public void OnReturnToMenu() { logger.Msg("OnReturnToMenu"); }
    }
}
